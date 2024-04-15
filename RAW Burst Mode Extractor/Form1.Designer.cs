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
			btnRefreshPreview = new Button();
			pictureBox = new PictureBox();
			openFileDialog1 = new OpenFileDialog();
			toolTip1 = new ToolTip(components);
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openDNGLabGithubPageToolStripMenuItem = new ToolStripMenuItem();
			quitToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// tbDNGLabExePath
			// 
			tbDNGLabExePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbDNGLabExePath.Location = new Point(252, 5);
			tbDNGLabExePath.Name = "tbDNGLabExePath";
			tbDNGLabExePath.Size = new Size(370, 23);
			tbDNGLabExePath.TabIndex = 0;
			tbDNGLabExePath.TextChanged += tbDNGLabExePath_TextChanged;
			// 
			// lblDNGLabExePath
			// 
			lblDNGLabExePath.AutoSize = true;
			lblDNGLabExePath.Location = new Point(105, 7);
			lblDNGLabExePath.Name = "lblDNGLabExePath";
			lblDNGLabExePath.Size = new Size(141, 15);
			lblDNGLabExePath.TabIndex = 1;
			lblDNGLabExePath.Text = "DNG Lab Executable Path";
			// 
			// tbImageSourceDir
			// 
			tbImageSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbImageSourceDir.Location = new Point(252, 34);
			tbImageSourceDir.Name = "tbImageSourceDir";
			tbImageSourceDir.Size = new Size(370, 23);
			tbImageSourceDir.TabIndex = 2;
			tbImageSourceDir.TextChanged += tbImageSourceDir_TextChanged;
			// 
			// lblSourceDir
			// 
			lblSourceDir.AutoSize = true;
			lblSourceDir.Location = new Point(152, 36);
			lblSourceDir.Name = "lblSourceDir";
			lblSourceDir.Size = new Size(94, 15);
			lblSourceDir.TabIndex = 3;
			lblSourceDir.Text = "Source Directory";
			// 
			// lblImageExtensions
			// 
			lblImageExtensions.AutoSize = true;
			lblImageExtensions.Location = new Point(41, 123);
			lblImageExtensions.Name = "lblImageExtensions";
			lblImageExtensions.Size = new Size(205, 15);
			lblImageExtensions.TabIndex = 5;
			lblImageExtensions.Text = "Image Extensions (comma separated)";
			// 
			// tbImageExtensions
			// 
			tbImageExtensions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbImageExtensions.Location = new Point(252, 120);
			tbImageExtensions.Name = "tbImageExtensions";
			tbImageExtensions.Size = new Size(370, 23);
			tbImageExtensions.TabIndex = 6;
			tbImageExtensions.TextChanged += tbImageExtensions_TextChanged;
			// 
			// tbImagePrefixes
			// 
			tbImagePrefixes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbImagePrefixes.Location = new Point(252, 91);
			tbImagePrefixes.Name = "tbImagePrefixes";
			tbImagePrefixes.Size = new Size(370, 23);
			tbImagePrefixes.TabIndex = 7;
			tbImagePrefixes.TextChanged += tbImagePrefixes_TextChanged;
			// 
			// lblImagePrefixes
			// 
			lblImagePrefixes.AutoSize = true;
			lblImagePrefixes.Location = new Point(56, 94);
			lblImagePrefixes.Name = "lblImagePrefixes";
			lblImagePrefixes.Size = new Size(190, 15);
			lblImagePrefixes.TabIndex = 8;
			lblImagePrefixes.Text = "Image Prefixes (comma separated)";
			// 
			// btnExtract
			// 
			btnExtract.Location = new Point(252, 332);
			btnExtract.Name = "btnExtract";
			btnExtract.Size = new Size(75, 23);
			btnExtract.TabIndex = 13;
			btnExtract.Text = "Extract";
			toolTip1.SetToolTip(btnExtract, "Begin Extraction");
			btnExtract.UseVisualStyleBackColor = true;
			btnExtract.Click += btnExtract_Click;
			// 
			// clbCandidateImages
			// 
			clbCandidateImages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			clbCandidateImages.FormattingEnabled = true;
			clbCandidateImages.Location = new Point(252, 149);
			clbCandidateImages.Name = "clbCandidateImages";
			clbCandidateImages.Size = new Size(370, 148);
			clbCandidateImages.TabIndex = 8;
			toolTip1.SetToolTip(clbCandidateImages, "Select the images from which you would like to extract DNG's");
			clbCandidateImages.SelectedIndexChanged += clbCandidateImages_SelectedIndexChanged;
			// 
			// lblCandidateImages
			// 
			lblCandidateImages.AutoSize = true;
			lblCandidateImages.Location = new Point(144, 152);
			lblCandidateImages.Name = "lblCandidateImages";
			lblCandidateImages.Size = new Size(102, 15);
			lblCandidateImages.TabIndex = 11;
			lblCandidateImages.Text = "Candidate Images";
			// 
			// btnSelectAllCandidates
			// 
			btnSelectAllCandidates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSelectAllCandidates.Location = new Point(628, 150);
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
			btnDeselectAllCandidates.Location = new Point(628, 179);
			btnDeselectAllCandidates.Name = "btnDeselectAllCandidates";
			btnDeselectAllCandidates.Size = new Size(92, 23);
			btnDeselectAllCandidates.TabIndex = 10;
			btnDeselectAllCandidates.Text = "Deselect All";
			btnDeselectAllCandidates.UseVisualStyleBackColor = true;
			btnDeselectAllCandidates.Click += btnDeselectAllCandidates_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer1.BorderStyle = BorderStyle.FixedSingle;
			splitContainer1.FixedPanel = FixedPanel.Panel1;
			splitContainer1.Location = new Point(12, 27);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(btnOptionsHelp);
			splitContainer1.Panel1.Controls.Add(btnOpenDestDir);
			splitContainer1.Panel1.Controls.Add(btnOpenSourceDir);
			splitContainer1.Panel1.Controls.Add(btnOpenDNGLabExeDir);
			splitContainer1.Panel1.Controls.Add(btnRefreshCandidateImages);
			splitContainer1.Panel1.Controls.Add(lblOptionsString);
			splitContainer1.Panel1.Controls.Add(tbOptionsString);
			splitContainer1.Panel1.Controls.Add(cbAutoUpdatePreview);
			splitContainer1.Panel1.Controls.Add(lblDestDir);
			splitContainer1.Panel1.Controls.Add(btnBrowseImageDestinationDir);
			splitContainer1.Panel1.Controls.Add(tbImageDestDir);
			splitContainer1.Panel1.Controls.Add(btnBrowseImageSourceDir);
			splitContainer1.Panel1.Controls.Add(btnExtract);
			splitContainer1.Panel1.Controls.Add(btnBrowseDNGLabExe);
			splitContainer1.Panel1.Controls.Add(tbDNGLabExePath);
			splitContainer1.Panel1.Controls.Add(btnDeselectAllCandidates);
			splitContainer1.Panel1.Controls.Add(lblDNGLabExePath);
			splitContainer1.Panel1.Controls.Add(btnSelectAllCandidates);
			splitContainer1.Panel1.Controls.Add(tbImageSourceDir);
			splitContainer1.Panel1.Controls.Add(lblCandidateImages);
			splitContainer1.Panel1.Controls.Add(lblSourceDir);
			splitContainer1.Panel1.Controls.Add(clbCandidateImages);
			splitContainer1.Panel1.Controls.Add(lblImageExtensions);
			splitContainer1.Panel1.Controls.Add(tbImageExtensions);
			splitContainer1.Panel1.Controls.Add(lblImagePrefixes);
			splitContainer1.Panel1.Controls.Add(tbImagePrefixes);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(btnRefreshPreview);
			splitContainer1.Panel2.Controls.Add(pictureBox);
			splitContainer1.Size = new Size(1359, 658);
			splitContainer1.SplitterDistance = 847;
			splitContainer1.TabIndex = 14;
			// 
			// btnOptionsHelp
			// 
			btnOptionsHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnOptionsHelp.Location = new Point(628, 303);
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
			btnOpenDestDir.Location = new Point(726, 62);
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
			btnOpenSourceDir.Location = new Point(726, 32);
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
			btnOpenDNGLabExeDir.Location = new Point(726, 3);
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
			btnRefreshCandidateImages.Location = new Point(628, 208);
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
			lblOptionsString.Location = new Point(116, 306);
			lblOptionsString.Name = "lblOptionsString";
			lblOptionsString.Size = new Size(130, 15);
			lblOptionsString.TabIndex = 23;
			lblOptionsString.Text = "DNGLab Options String";
			// 
			// tbOptionsString
			// 
			tbOptionsString.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbOptionsString.Location = new Point(252, 303);
			tbOptionsString.Name = "tbOptionsString";
			tbOptionsString.Size = new Size(370, 23);
			tbOptionsString.TabIndex = 12;
			toolTip1.SetToolTip(tbOptionsString, "Optionally pass extra option flags to the DNGLab executable");
			tbOptionsString.TextChanged += tbOptionsString_TextChanged;
			// 
			// cbAutoUpdatePreview
			// 
			cbAutoUpdatePreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cbAutoUpdatePreview.AutoSize = true;
			cbAutoUpdatePreview.Location = new Point(628, 237);
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
			lblDestDir.Location = new Point(128, 65);
			lblDestDir.Name = "lblDestDir";
			lblDestDir.Size = new Size(118, 15);
			lblDestDir.TabIndex = 18;
			lblDestDir.Text = "Destination Directory";
			// 
			// btnBrowseImageDestinationDir
			// 
			btnBrowseImageDestinationDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnBrowseImageDestinationDir.Location = new Point(628, 62);
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
			tbImageDestDir.Location = new Point(252, 62);
			tbImageDestDir.Name = "tbImageDestDir";
			tbImageDestDir.Size = new Size(370, 23);
			tbImageDestDir.TabIndex = 4;
			tbImageDestDir.TextChanged += tbImageDestDir_TextChanged;
			// 
			// btnBrowseImageSourceDir
			// 
			btnBrowseImageSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnBrowseImageSourceDir.Location = new Point(628, 34);
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
			btnBrowseDNGLabExe.Location = new Point(628, 5);
			btnBrowseDNGLabExe.Name = "btnBrowseDNGLabExe";
			btnBrowseDNGLabExe.Size = new Size(92, 23);
			btnBrowseDNGLabExe.TabIndex = 1;
			btnBrowseDNGLabExe.Text = "Browse";
			btnBrowseDNGLabExe.UseVisualStyleBackColor = true;
			btnBrowseDNGLabExe.Click += btnBrowseDNGLabExe_Click;
			// 
			// btnRefreshPreview
			// 
			btnRefreshPreview.Location = new Point(3, 6);
			btnRefreshPreview.Name = "btnRefreshPreview";
			btnRefreshPreview.Size = new Size(116, 23);
			btnRefreshPreview.TabIndex = 15;
			btnRefreshPreview.Text = "Refresh Preview";
			btnRefreshPreview.UseVisualStyleBackColor = true;
			btnRefreshPreview.Click += btnRefreshPreview_Click;
			// 
			// pictureBox
			// 
			pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox.BackColor = SystemColors.ControlLightLight;
			pictureBox.BackgroundImage = (Image)resources.GetObject("pictureBox.BackgroundImage");
			pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox.Location = new Point(3, 35);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(500, 290);
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			toolTip1.SetToolTip(pictureBox, "Image Preview (For RAW files containing multiple images, only the preview image of the roll will be shown (typically the first image in the roll)");
			pictureBox.Resize += pictureBox_Resize;
			// 
			// openFileDialog1
			// 
			openFileDialog1.DefaultExt = "exe";
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1383, 24);
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1383, 697);
			Controls.Add(splitContainer1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "RAW Burst Mode Extractor";
			Load += Form1_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
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
	}
}