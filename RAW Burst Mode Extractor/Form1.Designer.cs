namespace RAW_Burst_Mode_Extractor
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			tbDNGLabExePath = new TextBox();
			lblDNGLabExePath = new Label();
			tbImageSourceDir = new TextBox();
			lblSourceDir = new Label();
			folderBrowserDialog1 = new FolderBrowserDialog();
			lblImageExtensions = new Label();
			tbImageExtensions = new TextBox();
			tbImagePrefixes = new TextBox();
			lblImagePrefixes = new Label();
			btnExtract = new Button();
			clbCandidateImages = new CheckedListBox();
			lblCandidateImages = new Label();
			btnSelectAllCandidates = new Button();
			btnDeselectAllCandidates = new Button();
			splitContainer1 = new SplitContainer();
			grpOptions = new GroupBox();
			cbRecycleProcessedFiles = new CheckBox();
			cbExractToSourceDir = new CheckBox();
			cbCreateOutputSubDirs = new CheckBox();
			nudMaxPowerShellWindows = new NumericUpDown();
			cbLimitPowershellWindows = new CheckBox();
			btnOptionsHelp = new Button();
			btnOpenDestDir = new Button();
			btnOpenSourceDir = new Button();
			btnOpenDNGLabExeDir = new Button();
			btnRefreshCandidateImages = new Button();
			lblOptionsString = new Label();
			tbOptionsString = new TextBox();
			cbAutoUpdatePreview = new CheckBox();
			lblDestDir = new Label();
			btnBrowseImageDestinationDir = new Button();
			tbImageDestDir = new TextBox();
			btnBrowseImageSourceDir = new Button();
			btnBrowseDNGLabExe = new Button();
			grpImagePreview = new GroupBox();
			pictureBox = new PictureBox();
			btnRefreshPreview = new Button();
			openFileDialog1 = new OpenFileDialog();
			toolTip1 = new ToolTip(components);
			btnClearMessages = new Button();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openDNGLabGithubPageToolStripMenuItem = new ToolStripMenuItem();
			quitToolStripMenuItem = new ToolStripMenuItem();
			tbMessages = new TextBox();
			splitContainer2 = new SplitContainer();
			grpMessages = new GroupBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			grpOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudMaxPowerShellWindows).BeginInit();
			grpImagePreview.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			grpMessages.SuspendLayout();
			SuspendLayout();
			// 
			// tbDNGLabExePath
			// 
			tbDNGLabExePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbDNGLabExePath.Location = new Point(236, 12);
			tbDNGLabExePath.Name = "tbDNGLabExePath";
			tbDNGLabExePath.Size = new Size(388, 23);
			tbDNGLabExePath.TabIndex = 0;
			tbDNGLabExePath.TextChanged += tbDNGLabExePath_TextChanged;
			// 
			// lblDNGLabExePath
			// 
			lblDNGLabExePath.AutoSize = true;
			lblDNGLabExePath.Location = new Point(89, 15);
			lblDNGLabExePath.Name = "lblDNGLabExePath";
			lblDNGLabExePath.Size = new Size(141, 15);
			lblDNGLabExePath.TabIndex = 1;
			lblDNGLabExePath.Text = "DNG Lab Executable Path";
			// 
			// tbImageSourceDir
			// 
			tbImageSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbImageSourceDir.Location = new Point(236, 41);
			tbImageSourceDir.Name = "tbImageSourceDir";
			tbImageSourceDir.Size = new Size(388, 23);
			tbImageSourceDir.TabIndex = 2;
			tbImageSourceDir.TextChanged += tbImageSourceDir_TextChanged;
			// 
			// lblSourceDir
			// 
			lblSourceDir.AutoSize = true;
			lblSourceDir.Location = new Point(136, 44);
			lblSourceDir.Name = "lblSourceDir";
			lblSourceDir.Size = new Size(94, 15);
			lblSourceDir.TabIndex = 3;
			lblSourceDir.Text = "Source Directory";
			// 
			// lblImageExtensions
			// 
			lblImageExtensions.AutoSize = true;
			lblImageExtensions.Location = new Point(1, 208);
			lblImageExtensions.Name = "lblImageExtensions";
			lblImageExtensions.Size = new Size(229, 15);
			lblImageExtensions.TabIndex = 5;
			lblImageExtensions.Text = "Image Extension Filter (comma separated)";
			// 
			// tbImageExtensions
			// 
			tbImageExtensions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbImageExtensions.Location = new Point(236, 205);
			tbImageExtensions.Name = "tbImageExtensions";
			tbImageExtensions.Size = new Size(388, 23);
			tbImageExtensions.TabIndex = 6;
			tbImageExtensions.TextChanged += tbImageExtensions_TextChanged;
			// 
			// tbImagePrefixes
			// 
			tbImagePrefixes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbImagePrefixes.Location = new Point(236, 176);
			tbImagePrefixes.Name = "tbImagePrefixes";
			tbImagePrefixes.Size = new Size(388, 23);
			tbImagePrefixes.TabIndex = 7;
			tbImagePrefixes.TextChanged += tbImagePrefixes_TextChanged;
			// 
			// lblImagePrefixes
			// 
			lblImagePrefixes.AutoSize = true;
			lblImagePrefixes.Location = new Point(22, 179);
			lblImagePrefixes.Name = "lblImagePrefixes";
			lblImagePrefixes.Size = new Size(208, 15);
			lblImagePrefixes.TabIndex = 8;
			lblImagePrefixes.Text = "Image Prefix Filter (comma separated)";
			// 
			// btnExtract
			// 
			btnExtract.Location = new Point(236, 454);
			btnExtract.Name = "btnExtract";
			btnExtract.Size = new Size(128, 23);
			btnExtract.TabIndex = 13;
			btnExtract.Text = "Begin Extraction";
			toolTip1.SetToolTip(btnExtract, "Begin Extraction");
			btnExtract.UseVisualStyleBackColor = true;
			btnExtract.Click += btnExtract_Click;
			// 
			// clbCandidateImages
			// 
			clbCandidateImages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			clbCandidateImages.FormattingEnabled = true;
			clbCandidateImages.Location = new Point(236, 234);
			clbCandidateImages.Name = "clbCandidateImages";
			clbCandidateImages.Size = new Size(388, 148);
			clbCandidateImages.TabIndex = 8;
			toolTip1.SetToolTip(clbCandidateImages, "Select the images from which you would like to extract DNG's");
			clbCandidateImages.SelectedIndexChanged += clbCandidateImages_SelectedIndexChanged;
			// 
			// lblCandidateImages
			// 
			lblCandidateImages.AutoSize = true;
			lblCandidateImages.Location = new Point(128, 235);
			lblCandidateImages.Name = "lblCandidateImages";
			lblCandidateImages.Size = new Size(102, 15);
			lblCandidateImages.TabIndex = 11;
			lblCandidateImages.Text = "Candidate Images";
			// 
			// btnSelectAllCandidates
			// 
			btnSelectAllCandidates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSelectAllCandidates.Location = new Point(630, 235);
			btnSelectAllCandidates.Name = "btnSelectAllCandidates";
			btnSelectAllCandidates.Size = new Size(92, 23);
			btnSelectAllCandidates.TabIndex = 9;
			btnSelectAllCandidates.Text = "Select All";
			btnSelectAllCandidates.UseVisualStyleBackColor = true;
			btnSelectAllCandidates.Click += btnSelectAllCandidates_Click;
			// 
			// btnDeselectAllCandidates
			// 
			btnDeselectAllCandidates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnDeselectAllCandidates.Location = new Point(630, 264);
			btnDeselectAllCandidates.Name = "btnDeselectAllCandidates";
			btnDeselectAllCandidates.Size = new Size(92, 23);
			btnDeselectAllCandidates.TabIndex = 10;
			btnDeselectAllCandidates.Text = "Deselect All";
			btnDeselectAllCandidates.UseVisualStyleBackColor = true;
			btnDeselectAllCandidates.Click += btnDeselectAllCandidates_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.BackColor = SystemColors.ControlDark;
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.FixedPanel = FixedPanel.Panel1;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.BackColor = SystemColors.Control;
			splitContainer1.Panel1.Controls.Add(grpOptions);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.BackColor = SystemColors.Control;
			splitContainer1.Panel2.Controls.Add(grpImagePreview);
			splitContainer1.Size = new Size(1375, 550);
			splitContainer1.SplitterDistance = 850;
			splitContainer1.TabIndex = 14;
			// 
			// grpOptions
			// 
			grpOptions.Controls.Add(cbRecycleProcessedFiles);
			grpOptions.Controls.Add(cbExractToSourceDir);
			grpOptions.Controls.Add(cbCreateOutputSubDirs);
			grpOptions.Controls.Add(nudMaxPowerShellWindows);
			grpOptions.Controls.Add(cbLimitPowershellWindows);
			grpOptions.Controls.Add(tbDNGLabExePath);
			grpOptions.Controls.Add(btnOptionsHelp);
			grpOptions.Controls.Add(tbImagePrefixes);
			grpOptions.Controls.Add(btnOpenDestDir);
			grpOptions.Controls.Add(lblImagePrefixes);
			grpOptions.Controls.Add(btnOpenSourceDir);
			grpOptions.Controls.Add(tbImageExtensions);
			grpOptions.Controls.Add(btnOpenDNGLabExeDir);
			grpOptions.Controls.Add(lblImageExtensions);
			grpOptions.Controls.Add(btnRefreshCandidateImages);
			grpOptions.Controls.Add(clbCandidateImages);
			grpOptions.Controls.Add(lblOptionsString);
			grpOptions.Controls.Add(lblSourceDir);
			grpOptions.Controls.Add(tbOptionsString);
			grpOptions.Controls.Add(lblCandidateImages);
			grpOptions.Controls.Add(cbAutoUpdatePreview);
			grpOptions.Controls.Add(tbImageSourceDir);
			grpOptions.Controls.Add(lblDestDir);
			grpOptions.Controls.Add(btnSelectAllCandidates);
			grpOptions.Controls.Add(btnBrowseImageDestinationDir);
			grpOptions.Controls.Add(lblDNGLabExePath);
			grpOptions.Controls.Add(tbImageDestDir);
			grpOptions.Controls.Add(btnDeselectAllCandidates);
			grpOptions.Controls.Add(btnBrowseImageSourceDir);
			grpOptions.Controls.Add(btnBrowseDNGLabExe);
			grpOptions.Controls.Add(btnExtract);
			grpOptions.Dock = DockStyle.Fill;
			grpOptions.Location = new Point(0, 0);
			grpOptions.Name = "grpOptions";
			grpOptions.Size = new Size(850, 550);
			grpOptions.TabIndex = 29;
			grpOptions.TabStop = false;
			grpOptions.Text = "Options";
			// 
			// cbRecycleProcessedFiles
			// 
			cbRecycleProcessedFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cbRecycleProcessedFiles.AutoSize = true;
			cbRecycleProcessedFiles.Location = new Point(630, 148);
			cbRecycleProcessedFiles.Name = "cbRecycleProcessedFiles";
			cbRecycleProcessedFiles.Size = new Size(146, 19);
			cbRecycleProcessedFiles.TabIndex = 33;
			cbRecycleProcessedFiles.Text = "Recycle processed files";
			toolTip1.SetToolTip(cbRecycleProcessedFiles, "After processing a roll image, send it to the recycle bin");
			cbRecycleProcessedFiles.UseVisualStyleBackColor = true;
			// 
			// cbExractToSourceDir
			// 
			cbExractToSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cbExractToSourceDir.AutoSize = true;
			cbExractToSourceDir.Location = new Point(630, 98);
			cbExractToSourceDir.Name = "cbExractToSourceDir";
			cbExractToSourceDir.Size = new Size(164, 19);
			cbExractToSourceDir.TabIndex = 32;
			cbExractToSourceDir.Text = "Extract to source directory";
			toolTip1.SetToolTip(cbExractToSourceDir, "Extract all images to the source directory (ignores the destination directory field)");
			cbExractToSourceDir.UseVisualStyleBackColor = true;
			cbExractToSourceDir.CheckedChanged += cbExractToSourceDir_CheckedChanged;
			// 
			// cbCreateOutputSubDirs
			// 
			cbCreateOutputSubDirs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cbCreateOutputSubDirs.AutoSize = true;
			cbCreateOutputSubDirs.Checked = true;
			cbCreateOutputSubDirs.CheckState = CheckState.Checked;
			cbCreateOutputSubDirs.Location = new Point(630, 123);
			cbCreateOutputSubDirs.Name = "cbCreateOutputSubDirs";
			cbCreateOutputSubDirs.Size = new Size(158, 19);
			cbCreateOutputSubDirs.TabIndex = 31;
			cbCreateOutputSubDirs.Text = "Extract to sub-directories";
			toolTip1.SetToolTip(cbCreateOutputSubDirs, "For each input image, create a new sub directory named after that image and place the extracted images in it");
			cbCreateOutputSubDirs.UseVisualStyleBackColor = true;
			// 
			// nudMaxPowerShellWindows
			// 
			nudMaxPowerShellWindows.Location = new Point(499, 416);
			nudMaxPowerShellWindows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudMaxPowerShellWindows.Name = "nudMaxPowerShellWindows";
			nudMaxPowerShellWindows.Size = new Size(70, 23);
			nudMaxPowerShellWindows.TabIndex = 30;
			nudMaxPowerShellWindows.Value = new decimal(new int[] { 5, 0, 0, 0 });
			// 
			// cbLimitPowershellWindows
			// 
			cbLimitPowershellWindows.AutoSize = true;
			cbLimitPowershellWindows.Checked = true;
			cbLimitPowershellWindows.CheckState = CheckState.Checked;
			cbLimitPowershellWindows.Location = new Point(236, 417);
			cbLimitPowershellWindows.Name = "cbLimitPowershellWindows";
			cbLimitPowershellWindows.Size = new Size(257, 19);
			cbLimitPowershellWindows.TabIndex = 29;
			cbLimitPowershellWindows.Text = "Limit Simultaneous Powershell Windows to:";
			toolTip1.SetToolTip(cbLimitPowershellWindows, "Limit the number of simultaneous powershell windows");
			cbLimitPowershellWindows.UseVisualStyleBackColor = true;
			cbLimitPowershellWindows.CheckedChanged += cbLimitPowershellWindows_CheckedChanged;
			// 
			// btnOptionsHelp
			// 
			btnOptionsHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnOptionsHelp.Location = new Point(630, 388);
			btnOptionsHelp.Name = "btnOptionsHelp";
			btnOptionsHelp.Size = new Size(92, 23);
			btnOptionsHelp.TabIndex = 28;
			btnOptionsHelp.Text = "Help";
			toolTip1.SetToolTip(btnOptionsHelp, "https://github.com/dnglab/dnglab/blob/main/README.md");
			btnOptionsHelp.UseVisualStyleBackColor = true;
			btnOptionsHelp.Click += btnOptionsHelp_Click;
			// 
			// btnOpenDestDir
			// 
			btnOpenDestDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnOpenDestDir.Location = new Point(728, 69);
			btnOpenDestDir.Name = "btnOpenDestDir";
			btnOpenDestDir.Size = new Size(116, 23);
			btnOpenDestDir.TabIndex = 27;
			btnOpenDestDir.Text = "Open Directory";
			btnOpenDestDir.UseVisualStyleBackColor = true;
			btnOpenDestDir.Click += btnOpenDestDir_Click;
			// 
			// btnOpenSourceDir
			// 
			btnOpenSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnOpenSourceDir.Location = new Point(728, 39);
			btnOpenSourceDir.Name = "btnOpenSourceDir";
			btnOpenSourceDir.Size = new Size(116, 23);
			btnOpenSourceDir.TabIndex = 26;
			btnOpenSourceDir.Text = "Open Directory";
			btnOpenSourceDir.UseVisualStyleBackColor = true;
			btnOpenSourceDir.Click += btnOpenSourceDir_Click;
			// 
			// btnOpenDNGLabExeDir
			// 
			btnOpenDNGLabExeDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnOpenDNGLabExeDir.Location = new Point(728, 10);
			btnOpenDNGLabExeDir.Name = "btnOpenDNGLabExeDir";
			btnOpenDNGLabExeDir.Size = new Size(116, 23);
			btnOpenDNGLabExeDir.TabIndex = 25;
			btnOpenDNGLabExeDir.Text = "Open Directory";
			btnOpenDNGLabExeDir.UseVisualStyleBackColor = true;
			btnOpenDNGLabExeDir.Click += btnOpenDNGLabExeDir_Click;
			// 
			// btnRefreshCandidateImages
			// 
			btnRefreshCandidateImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnRefreshCandidateImages.Location = new Point(630, 293);
			btnRefreshCandidateImages.Name = "btnRefreshCandidateImages";
			btnRefreshCandidateImages.Size = new Size(92, 23);
			btnRefreshCandidateImages.TabIndex = 24;
			btnRefreshCandidateImages.Text = "Refresh List";
			btnRefreshCandidateImages.UseVisualStyleBackColor = true;
			btnRefreshCandidateImages.Click += btnRefreshCandidateImages_Click;
			// 
			// lblOptionsString
			// 
			lblOptionsString.AutoSize = true;
			lblOptionsString.Location = new Point(100, 392);
			lblOptionsString.Name = "lblOptionsString";
			lblOptionsString.Size = new Size(130, 15);
			lblOptionsString.TabIndex = 23;
			lblOptionsString.Text = "DNGLab Options String";
			// 
			// tbOptionsString
			// 
			tbOptionsString.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbOptionsString.Location = new Point(236, 388);
			tbOptionsString.Name = "tbOptionsString";
			tbOptionsString.Size = new Size(388, 23);
			tbOptionsString.TabIndex = 12;
			toolTip1.SetToolTip(tbOptionsString, "Optionally pass extra option flags to the DNGLab executable");
			tbOptionsString.TextChanged += tbOptionsString_TextChanged;
			// 
			// cbAutoUpdatePreview
			// 
			cbAutoUpdatePreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cbAutoUpdatePreview.AutoSize = true;
			cbAutoUpdatePreview.Location = new Point(630, 322);
			cbAutoUpdatePreview.Name = "cbAutoUpdatePreview";
			cbAutoUpdatePreview.Size = new Size(137, 19);
			cbAutoUpdatePreview.TabIndex = 11;
			cbAutoUpdatePreview.Text = "Auto Update Preview";
			toolTip1.SetToolTip(cbAutoUpdatePreview, "Update the image preview every time a new image is selected");
			cbAutoUpdatePreview.UseVisualStyleBackColor = true;
			// 
			// lblDestDir
			// 
			lblDestDir.AutoSize = true;
			lblDestDir.Location = new Point(112, 73);
			lblDestDir.Name = "lblDestDir";
			lblDestDir.Size = new Size(118, 15);
			lblDestDir.TabIndex = 18;
			lblDestDir.Text = "Destination Directory";
			// 
			// btnBrowseImageDestinationDir
			// 
			btnBrowseImageDestinationDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnBrowseImageDestinationDir.Location = new Point(630, 69);
			btnBrowseImageDestinationDir.Name = "btnBrowseImageDestinationDir";
			btnBrowseImageDestinationDir.Size = new Size(92, 23);
			btnBrowseImageDestinationDir.TabIndex = 5;
			btnBrowseImageDestinationDir.Text = "Browse";
			btnBrowseImageDestinationDir.UseVisualStyleBackColor = true;
			btnBrowseImageDestinationDir.Click += btnBrowseImageDestinationDir_Click;
			// 
			// tbImageDestDir
			// 
			tbImageDestDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbImageDestDir.Location = new Point(236, 69);
			tbImageDestDir.Name = "tbImageDestDir";
			tbImageDestDir.Size = new Size(388, 23);
			tbImageDestDir.TabIndex = 4;
			tbImageDestDir.TextChanged += tbImageDestDir_TextChanged;
			// 
			// btnBrowseImageSourceDir
			// 
			btnBrowseImageSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnBrowseImageSourceDir.Location = new Point(630, 41);
			btnBrowseImageSourceDir.Name = "btnBrowseImageSourceDir";
			btnBrowseImageSourceDir.Size = new Size(92, 23);
			btnBrowseImageSourceDir.TabIndex = 3;
			btnBrowseImageSourceDir.Text = "Browse";
			btnBrowseImageSourceDir.UseVisualStyleBackColor = true;
			btnBrowseImageSourceDir.Click += btnBrowseImageSourceDir_Click;
			// 
			// btnBrowseDNGLabExe
			// 
			btnBrowseDNGLabExe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnBrowseDNGLabExe.Location = new Point(630, 12);
			btnBrowseDNGLabExe.Name = "btnBrowseDNGLabExe";
			btnBrowseDNGLabExe.Size = new Size(92, 23);
			btnBrowseDNGLabExe.TabIndex = 1;
			btnBrowseDNGLabExe.Text = "Browse";
			btnBrowseDNGLabExe.UseVisualStyleBackColor = true;
			btnBrowseDNGLabExe.Click += btnBrowseDNGLabExe_Click;
			// 
			// grpImagePreview
			// 
			grpImagePreview.Controls.Add(pictureBox);
			grpImagePreview.Controls.Add(btnRefreshPreview);
			grpImagePreview.Dock = DockStyle.Fill;
			grpImagePreview.Location = new Point(0, 0);
			grpImagePreview.Name = "grpImagePreview";
			grpImagePreview.Size = new Size(521, 550);
			grpImagePreview.TabIndex = 16;
			grpImagePreview.TabStop = false;
			grpImagePreview.Text = "Image Preview";
			// 
			// pictureBox
			// 
			pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox.BackColor = SystemColors.ControlLightLight;
			pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox.InitialImage = null;
			pictureBox.Location = new Point(3, 51);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(512, 493);
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			toolTip1.SetToolTip(pictureBox, "Image Preview (For RAW files containing multiple images, only the preview image of the roll will be shown (typically the first image in the roll)");
			// 
			// btnRefreshPreview
			// 
			btnRefreshPreview.Location = new Point(6, 22);
			btnRefreshPreview.Name = "btnRefreshPreview";
			btnRefreshPreview.Size = new Size(116, 23);
			btnRefreshPreview.TabIndex = 15;
			btnRefreshPreview.Text = "Refresh Preview";
			btnRefreshPreview.UseVisualStyleBackColor = true;
			btnRefreshPreview.Click += btnRefreshPreview_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.DefaultExt = "exe";
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnClearMessages
			// 
			btnClearMessages.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnClearMessages.Location = new Point(1271, 168);
			btnClearMessages.Name = "btnClearMessages";
			btnClearMessages.Size = new Size(92, 23);
			btnClearMessages.TabIndex = 29;
			btnClearMessages.Text = "Clear";
			toolTip1.SetToolTip(btnClearMessages, "https://github.com/dnglab/dnglab/blob/main/README.md");
			btnClearMessages.UseVisualStyleBackColor = true;
			btnClearMessages.Click += btnClearMessages_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1375, 24);
			menuStrip1.TabIndex = 15;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openDNGLabGithubPageToolStripMenuItem, quitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// openDNGLabGithubPageToolStripMenuItem
			// 
			openDNGLabGithubPageToolStripMenuItem.Name = "openDNGLabGithubPageToolStripMenuItem";
			openDNGLabGithubPageToolStripMenuItem.Size = new Size(218, 22);
			openDNGLabGithubPageToolStripMenuItem.Text = "Open DNGLab Github Page";
			openDNGLabGithubPageToolStripMenuItem.ToolTipText = "https://github.com/dnglab/dnglab";
			openDNGLabGithubPageToolStripMenuItem.Click += openDNGLabGithubPageToolStripMenuItem_Click;
			// 
			// quitToolStripMenuItem
			// 
			quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			quitToolStripMenuItem.Size = new Size(218, 22);
			quitToolStripMenuItem.Text = "Quit";
			quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
			// 
			// tbMessages
			// 
			tbMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbMessages.Location = new Point(6, 22);
			tbMessages.Multiline = true;
			tbMessages.Name = "tbMessages";
			tbMessages.ReadOnly = true;
			tbMessages.ScrollBars = ScrollBars.Vertical;
			tbMessages.Size = new Size(1363, 140);
			tbMessages.TabIndex = 16;
			// 
			// splitContainer2
			// 
			splitContainer2.BackColor = SystemColors.ControlDark;
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 24);
			splitContainer2.Name = "splitContainer2";
			splitContainer2.Orientation = Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.BackColor = SystemColors.Control;
			splitContainer2.Panel1.Controls.Add(splitContainer1);
			splitContainer2.Panel1.RightToLeft = RightToLeft.No;
			splitContainer2.Panel1MinSize = 375;
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.BackColor = SystemColors.Control;
			splitContainer2.Panel2.Controls.Add(grpMessages);
			splitContainer2.Panel2.RightToLeft = RightToLeft.No;
			splitContainer2.RightToLeft = RightToLeft.No;
			splitContainer2.Size = new Size(1375, 751);
			splitContainer2.SplitterDistance = 550;
			splitContainer2.TabIndex = 30;
			// 
			// grpMessages
			// 
			grpMessages.Controls.Add(btnClearMessages);
			grpMessages.Controls.Add(tbMessages);
			grpMessages.Dock = DockStyle.Fill;
			grpMessages.Location = new Point(0, 0);
			grpMessages.Name = "grpMessages";
			grpMessages.Size = new Size(1375, 197);
			grpMessages.TabIndex = 0;
			grpMessages.TabStop = false;
			grpMessages.Text = "Messages";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1375, 775);
			Controls.Add(splitContainer2);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "RAW Burst Mode Extractor";
			Load += Form1_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			grpOptions.ResumeLayout(false);
			grpOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudMaxPowerShellWindows).EndInit();
			grpImagePreview.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			grpMessages.ResumeLayout(false);
			grpMessages.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbDNGLabExePath;
		private Label lblDNGLabExePath;
		private TextBox tbImageSourceDir;
		private Label lblSourceDir;
		private FolderBrowserDialog folderBrowserDialog1;
		private Label lblImageExtensions;
		private TextBox tbImageExtensions;
		private TextBox tbImagePrefixes;
		private Label lblImagePrefixes;
		private Button btnExtract;
		private CheckedListBox clbCandidateImages;
		private Label lblCandidateImages;
		private Button btnSelectAllCandidates;
		private Button btnDeselectAllCandidates;
		private SplitContainer splitContainer1;
		private PictureBox pictureBox;
		private Button btnBrowseDNGLabExe;
		private Button btnBrowseImageSourceDir;
		private Button btnBrowseImageDestinationDir;
		private TextBox tbImageDestDir;
		private Label lblDestDir;
		private OpenFileDialog openFileDialog1;
		private CheckBox cbAutoUpdatePreview;
		private Button btnRefreshPreview;
		private Label lblOptionsString;
		private TextBox tbOptionsString;
		private Button btnRefreshCandidateImages;
		private ToolTip toolTip1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openDNGLabGithubPageToolStripMenuItem;
		private ToolStripMenuItem quitToolStripMenuItem;
		private Button btnOpenDestDir;
		private Button btnOpenSourceDir;
		private Button btnOpenDNGLabExeDir;
		private Button btnOptionsHelp;
		private TextBox tbMessages;
		private Button btnClearMessages;
		private GroupBox grpOptions;
		private GroupBox grpImagePreview;
		private SplitContainer splitContainer2;
		private GroupBox grpMessages;
		private NumericUpDown nudMaxPowerShellWindows;
		private CheckBox cbLimitPowershellWindows;
		private CheckBox cbCreateOutputSubDirs;
		private CheckBox cbExractToSourceDir;
		private CheckBox cbRecycleProcessedFiles;
	}
}