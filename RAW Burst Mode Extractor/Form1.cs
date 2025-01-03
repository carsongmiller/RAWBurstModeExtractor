using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using ImageMagick;
using Microsoft.VisualBasic.FileIO;

namespace RAW_Burst_Mode_Extractor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				tbDNGLabExePath.Text = Properties.Settings.Default.DNGLabExePath;
				tbImageSourceDir.Text = Properties.Settings.Default.SourceImageDir;
				tbImageDestDir.Text = Properties.Settings.Default.DestImageDir;
				tbOptionsString.Text = Properties.Settings.Default.OptionsString;
				tbImagePrefixes.Text = Properties.Settings.Default.ImagePrefixes;
				tbImageExtensions.Text = Properties.Settings.Default.ImageExtensions;
			}
			catch (Exception ex)
			{
				showErrorMessage("Error loading settings", ex);
			}

			pictureBox.Height = pictureBox.Width * 2 / 3;
			repopulateCandidateImages(tbImageSourceDir.Text);
		}

		private void btnExtract_Click(object sender, EventArgs e)
		{
			if (!File.Exists(tbDNGLabExePath.Text))
			{
				showErrorMessage("DNGLab.exe does not exist at specified location");
				return;
			}

			var invalidImages = new List<string>();
			foreach (string fileName in clbCandidateImages.CheckedItems)
			{
				var path = tbImageSourceDir.Text + "\\" + fileName;
				if (!File.Exists(path))
				{
					invalidImages.Add(fileName);
				}
			}

			if (invalidImages.Count > 0)
			{
				string invalidImagesMessage = "Image(s) not found:\r\n\r\n";
				foreach (var image in invalidImages)
				{
					invalidImagesMessage += image + ", ";
				}

				invalidImagesMessage = invalidImagesMessage.Substring(0, invalidImagesMessage.Length - 2);
				showErrorMessage(invalidImagesMessage);
				return;
			}

			printMessage("Beginning Extraction. Expect approximately 2-3 seconds per image");

			var maxConcurrentThreads = (int)nudMaxPowerShellWindows.Value;

			//exe exists and images exist.  We're good to try extracting
			//run the DNGLab exe on all of these images
			try
			{
				string exePath = tbDNGLabExePath.Text;
				exePath = exePath.Replace(" ", "` ");

				var imagePaths = new List<string>();
				ConcurrentBag<Thread> processingThreads = new ConcurrentBag<Thread>();

				foreach (string imageFile in clbCandidateImages.CheckedItems)
				{
					string sourceImagePath = tbImageSourceDir.Text + "\\" + imageFile;
					sourceImagePath = sourceImagePath.Replace(" ", "` ");

					var imageFileNoExtension = Path.GetFileNameWithoutExtension(imageFile);
					string outputPathWithPrefix;

					if (cbExractToSourceDir.Checked)
					{
						outputPathWithPrefix = tbImageSourceDir.Text + "\\" + imageFileNoExtension;
					}
					else
					{
						outputPathWithPrefix = tbImageDestDir.Text + "\\" + imageFileNoExtension;
					}
					

					if (cbCreateOutputSubDirs.Checked)
					{
						//If we want to create sub dirs to put the photos in,
						//then the name we THOUGHT we would give to the images (excluding their suffixes which are added by DNGLab)
						//will actually be the new sub dir's name
						//So create that dir if necessary, then append the source file's name again to get the NEW output file's ACTUAL name
						var newOutputSubDir = outputPathWithPrefix;
						if (!Directory.Exists(newOutputSubDir))
						{
							Directory.CreateDirectory(newOutputSubDir);
						}

						outputPathWithPrefix += "\\" + imageFileNoExtension;
					}

					outputPathWithPrefix = outputPathWithPrefix.Replace(" ", "` ");

					string args = $"\"\"{exePath}\"\" convert {tbOptionsString.Text} {sourceImagePath} {outputPathWithPrefix}";

					Thread thread = new Thread(semaphore =>
					{
						BeginInvoke((Action)delegate
						{
							printMessage($"Beginning image extraction: {imageFile}");
						});

						var output = RunPowershellCommand(args).Replace("\r\n", "\r\n\t");
						BeginInvoke((Action)delegate
						{
							printMessage($"Processing of \"{imageFile}\" Complete:\r\n\t{output}");
						});

						try
						{
							((SemaphoreSlim)semaphore).Release();
						}
						catch (Exception ex)
						{
							//probably complaining that the semaphore was already disposed
							//This can be ignored because if it was disposed, then the final threads have been started, so the semaphore is done being used
						}
						if (cbRecycleProcessedFiles.Checked)
						{
							FileSystem.DeleteFile(tbImageSourceDir.Text + "\\" + imageFile, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
						}
					});

					processingThreads.Add(thread);
				}

				var spawnThread = new Thread(() => { SpawnThreads(processingThreads, maxConcurrentThreads); });
				spawnThread.Start();
			}
			catch (Exception ex)
			{
				showErrorMessage("Error attempting to use DNGLab.exe to process image(s)", ex);
			}
		}

		public void SpawnThreads(ConcurrentBag<Thread> threads, int maxConcurrentThreads)
		{
			using (SemaphoreSlim semaphore = new SemaphoreSlim(maxConcurrentThreads))
			{
				foreach (var thread in threads)
				{
					semaphore.Wait();
					thread.Start(semaphore);
				}
			}
		}

		private void btnSelectAllCandidates_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < clbCandidateImages.Items.Count; i++)
			{
				clbCandidateImages.SetItemChecked(i, true);
			}
		}

		private void btnDeselectAllCandidates_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < clbCandidateImages.Items.Count; i++)
			{
				clbCandidateImages.SetItemChecked(i, false);
			}
		}

		private void clbCandidateImages_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbAutoUpdatePreview.Checked)
			{
				refreshImagePreview();
			}
		}


		private void btnBrowseDNGLabExe_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = Directory.Exists(Path.GetDirectoryName(tbDNGLabExePath.Text)) ? tbDNGLabExePath.Text : Directory.GetCurrentDirectory();

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tbDNGLabExePath.Text = openFileDialog1.FileName;
			}
		}

		private void btnBrowseImageSourceDir_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = Directory.Exists(tbImageSourceDir.Text) ? tbDNGLabExePath.Text : Directory.GetCurrentDirectory();

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbImageSourceDir.Text = folderBrowserDialog1.SelectedPath;
				repopulateCandidateImages(folderBrowserDialog1.SelectedPath);
			}
		}

		private void btnBrowseImageDestinationDir_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = Directory.Exists(tbImageDestDir.Text) ? tbDNGLabExePath.Text : Directory.GetCurrentDirectory();

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbImageDestDir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnOpenDNGLabExeDir_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("explorer.exe", Path.GetDirectoryName(tbDNGLabExePath.Text));
			}
			catch (Exception ex)
			{
				showErrorMessage("Unable to open directory", ex);
			}
		}

		private void btnOpenSourceDir_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("explorer.exe", tbImageSourceDir.Text);
			}
			catch (Exception ex)
			{
				showErrorMessage("Unable to open directory", ex);
			}
		}

		private void btnOpenDestDir_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("explorer.exe", tbImageDestDir.Text);
			}
			catch (Exception ex)
			{
				showErrorMessage("Unable to open directory", ex);
			}
		}

		private void repopulateCandidateImages(string path)
		{
			if (!Directory.Exists(path))
			{
				return;
			}

			try
			{
				var validExtensions = tbImageExtensions.Text.Split(',').ToList();
				validExtensions.ForEach(ext => ext.Trim());

				var validPrefixes = tbImagePrefixes.Text.Split(',').ToList();
				validPrefixes.ForEach(pre => pre.Trim());

				clbCandidateImages.Items.Clear();

				var files = Directory.GetFiles(path).ToList();

				foreach (var file in files)
				{
					var filename = Path.GetFileName(file);
					//check extensions
					if (!validExtensions.Contains(Path.GetExtension(filename)))
						continue;

					//check prefixes
					bool prefixMatched = false;
					foreach (var prefix in validPrefixes)
					{
						if (filename.IndexOf(prefix) == 0)
						{
							prefixMatched = true;
							break;
						}
					}
					if (!prefixMatched) continue;

					//add to CLB
					clbCandidateImages.Items.Add(filename);
				}
			}
			catch (Exception ex)
			{
				showErrorMessage("Error populating list of candidate images", ex);

			}
		}

		private void tbDNGLabExePath_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.DNGLabExePath = tbDNGLabExePath.Text;
			saveSettings();
		}

		private void tbImageSourceDir_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.SourceImageDir = tbImageSourceDir.Text;
			saveSettings();
		}

		private void tbImageDestDir_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.DestImageDir = tbImageDestDir.Text;
			saveSettings();
		}

		private void tbOptionsString_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.OptionsString = tbOptionsString.Text;
			saveSettings();
		}

		private void tbImageExtensions_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ImageExtensions = tbImageExtensions.Text;
			saveSettings();
			repopulateCandidateImages(tbImageSourceDir.Text);
		}

		private void tbImagePrefixes_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ImagePrefixes = tbImagePrefixes.Text;
			saveSettings();
			repopulateCandidateImages(tbImageSourceDir.Text);
		}

		private void btnRefreshCandidateImages_Click(object sender, EventArgs e)
		{
			repopulateCandidateImages(tbImageSourceDir.Text);
		}

		private void saveSettings()
		{
			try
			{
				Properties.Settings.Default.Save();
			}
			catch (Exception ex)
			{
				showErrorMessage("Error saving settings", ex);
			}
		}

		private void btnRefreshPreview_Click(object sender, EventArgs e)
		{
			refreshImagePreview();
		}

		private void refreshImagePreview()
		{
			if (clbCandidateImages.SelectedIndex == -1)
			{
				showWarningMessage("No image selected");
				return;
			}

			var dir = tbImageSourceDir.Text;
			var file = clbCandidateImages.SelectedItem.ToString();
			var path = $"{dir}\\{file}";

			if (!File.Exists(path))
			{
				showWarningMessage("Selected file does not exist in specified source directory");
				return;
			}

			try
			{
				Cursor = Cursors.WaitCursor;
				using (MagickImage image = new MagickImage(path))
				{
					pictureBox.Image = image.ToBitmap();
				}
				Cursor = Cursors.Default;

				toolTip1.SetToolTip(pictureBox, file);
			}
			catch (Exception ex)
			{
				showErrorMessage("Error refreshing image preview", ex);
			}
		}

		private void showWarningMessage(string message, Exception ex)
		{
			showWarningMessage($"{message}\r\n\r\n{ex.Message}");
		}

		private void showWarningMessage(string message)
		{
			MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void showErrorMessage(string message, Exception ex)
		{
			showErrorMessage($"{message}\r\n\r\n{ex.Message}");
		}

		private void showErrorMessage(string message)
		{
			MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void openDNGLabGithubPageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://github.com/dnglab/dnglab",
				UseShellExecute = true
			});
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnOptionsHelp_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://github.com/dnglab/dnglab/blob/main/README.md",
				UseShellExecute = true
			});
		}

		private string RunPowershellCommand(string args)
		{
			var processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "powershell.exe";
			processStartInfo.Arguments = args;
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.CreateNoWindow = false;

			using var process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();

			return process.StandardOutput.ReadToEnd().Replace("\n", "\r\n").Trim();
		}

		private void printMessage(string message)
		{
			tbMessages.AppendText(message + "\r\n");
		}

		private void btnClearMessages_Click(object sender, EventArgs e)
		{
			tbMessages.Clear();
		}

		private void cbLimitPowershellWindows_CheckedChanged(object sender, EventArgs e)
		{
			nudMaxPowerShellWindows.Enabled = cbLimitPowershellWindows.Checked;
		}

		private void cbExractToSourceDir_CheckedChanged(object sender, EventArgs e)
		{
			lblDestDir.Enabled = !cbExractToSourceDir.Checked;
			tbImageDestDir.Enabled = !cbExractToSourceDir.Checked;
		}
	}
}