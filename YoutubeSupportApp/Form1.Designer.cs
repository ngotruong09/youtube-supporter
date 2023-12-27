namespace YoutubeSupportApp
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
            label1 = new Label();
            btnShowVideo = new Button();
            txtChannelID = new TextBox();
            dgvVideo = new DataGridView();
            chk = new DataGridViewCheckBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DownloadDate = new DataGridViewTextBoxColumn();
            ChannelName = new DataGridViewTextBoxColumn();
            PlaylistTitle = new DataGridViewTextBoxColumn();
            VideoTitle = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Url = new DataGridViewTextBoxColumn();
            ChannelId = new DataGridViewTextBoxColumn();
            VideoID = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            progressBar1 = new ProgressBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cbxStatus = new ComboBox();
            cbxPlaylist = new ComboBox();
            btnContinue = new Button();
            btnDownload = new Button();
            txtFolderPath = new TextBox();
            btnDelete = new Button();
            txtChannel = new TextBox();
            txtDescription = new TextBox();
            btnClearAll = new Button();
            btnSearch = new Button();
            txtVideoTitle = new TextBox();
            btnClear = new Button();
            label2 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            txtGuide = new TextBox();
            bworkerDownload = new System.ComponentModel.BackgroundWorker();
            timerRefreshForm = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvVideo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 31);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "ChannelID";
            // 
            // btnShowVideo
            // 
            btnShowVideo.Location = new Point(1158, 25);
            btnShowVideo.Name = "btnShowVideo";
            btnShowVideo.Size = new Size(171, 29);
            btnShowVideo.TabIndex = 1;
            btnShowVideo.Tag = "2";
            btnShowVideo.Text = "Get info from channel";
            btnShowVideo.UseVisualStyleBackColor = true;
            btnShowVideo.Click += btnShowVideo_Click;
            // 
            // txtChannelID
            // 
            txtChannelID.Location = new Point(90, 27);
            txtChannelID.Name = "txtChannelID";
            txtChannelID.Size = new Size(1061, 27);
            txtChannelID.TabIndex = 2;
            txtChannelID.Tag = "1";
            // 
            // dgvVideo
            // 
            dgvVideo.AllowUserToAddRows = false;
            dgvVideo.AllowUserToDeleteRows = false;
            dgvVideo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVideo.BackgroundColor = SystemColors.ActiveCaption;
            dgvVideo.BorderStyle = BorderStyle.None;
            dgvVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideo.Columns.AddRange(new DataGridViewColumn[] { chk, Status, DownloadDate, ChannelName, PlaylistTitle, VideoTitle, Description, Url, ChannelId, VideoID, Id });
            dgvVideo.Location = new Point(8, 23);
            dgvVideo.Name = "dgvVideo";
            dgvVideo.RowHeadersWidth = 51;
            dgvVideo.RowTemplate.Height = 29;
            dgvVideo.Size = new Size(1304, 647);
            dgvVideo.TabIndex = 3;
            dgvVideo.CellMouseDoubleClick += dgvVideo_CellMouseDoubleClick;
            // 
            // chk
            // 
            chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            chk.HeaderText = "";
            chk.MinimumWidth = 6;
            chk.Name = "chk";
            chk.Width = 50;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.SortMode = DataGridViewColumnSortMode.Programmatic;
            Status.Width = 125;
            // 
            // DownloadDate
            // 
            DownloadDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DownloadDate.DataPropertyName = "DownloadDate";
            DownloadDate.HeaderText = "Date";
            DownloadDate.MinimumWidth = 6;
            DownloadDate.Name = "DownloadDate";
            DownloadDate.Width = 70;
            // 
            // ChannelName
            // 
            ChannelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ChannelName.DataPropertyName = "ChannelName";
            ChannelName.HeaderText = "Channel Name";
            ChannelName.MinimumWidth = 6;
            ChannelName.Name = "ChannelName";
            ChannelName.Width = 135;
            // 
            // PlaylistTitle
            // 
            PlaylistTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PlaylistTitle.DataPropertyName = "PlaylistTitle";
            PlaylistTitle.HeaderText = "Playlist Title";
            PlaylistTitle.MinimumWidth = 6;
            PlaylistTitle.Name = "PlaylistTitle";
            PlaylistTitle.Width = 117;
            // 
            // VideoTitle
            // 
            VideoTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            VideoTitle.DataPropertyName = "VideoTitle";
            VideoTitle.HeaderText = "Video Title";
            VideoTitle.MinimumWidth = 6;
            VideoTitle.Name = "VideoTitle";
            VideoTitle.Width = 110;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 658;
            // 
            // Url
            // 
            Url.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Url.DataPropertyName = "Url";
            Url.HeaderText = "Url";
            Url.MinimumWidth = 6;
            Url.Name = "Url";
            Url.Width = 57;
            // 
            // ChannelId
            // 
            ChannelId.DataPropertyName = "ChannelId";
            ChannelId.HeaderText = "ChannelId";
            ChannelId.MinimumWidth = 6;
            ChannelId.Name = "ChannelId";
            ChannelId.Visible = false;
            // 
            // VideoID
            // 
            VideoID.DataPropertyName = "VideoId";
            VideoID.HeaderText = "VideoID";
            VideoID.MinimumWidth = 6;
            VideoID.Name = "VideoID";
            VideoID.Visible = false;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 51;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChannelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnShowVideo);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1344, 71);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Youtube";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(progressBar1);
            groupBox3.Controls.Add(dgvVideo);
            groupBox3.Location = new Point(10, 128);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1321, 713);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(8, 676);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1307, 29);
            progressBar1.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 89);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1344, 880);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbxStatus);
            tabPage1.Controls.Add(cbxPlaylist);
            tabPage1.Controls.Add(btnContinue);
            tabPage1.Controls.Add(btnDownload);
            tabPage1.Controls.Add(txtFolderPath);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(txtChannel);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(btnClearAll);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtVideoTitle);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1336, 847);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "", "WAITING", "DOWNLOADING", "PENDING", "DONE", "FAIL" });
            cbxStatus.Location = new Point(10, 97);
            cbxStatus.Margin = new Padding(3, 4, 3, 4);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(564, 28);
            cbxStatus.TabIndex = 8;
            cbxStatus.Tag = "7";
            cbxStatus.SelectedValueChanged += cbxStatus_SelectedValueChanged;
            // 
            // cbxPlaylist
            // 
            cbxPlaylist.FormattingEnabled = true;
            cbxPlaylist.Location = new Point(585, 97);
            cbxPlaylist.Margin = new Padding(3, 4, 3, 4);
            cbxPlaylist.Name = "cbxPlaylist";
            cbxPlaylist.Size = new Size(564, 28);
            cbxPlaylist.TabIndex = 8;
            cbxPlaylist.Tag = "8";
            cbxPlaylist.SelectedValueChanged += cbxPlaylist_SelectedValueChanged;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(1239, 90);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(86, 35);
            btnContinue.TabIndex = 6;
            btnContinue.Tag = "14";
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(1237, 49);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(86, 35);
            btnDownload.TabIndex = 6;
            btnDownload.Tag = "10";
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(10, 41);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.PlaceholderText = "Folder Path";
            txtFolderPath.Size = new Size(564, 27);
            txtFolderPath.TabIndex = 7;
            txtFolderPath.Tag = "5";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1155, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Tag = "11";
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtChannel
            // 
            txtChannel.Location = new Point(10, 8);
            txtChannel.Name = "txtChannel";
            txtChannel.PlaceholderText = "Channel";
            txtChannel.Size = new Size(564, 27);
            txtChannel.TabIndex = 5;
            txtChannel.Tag = "3";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(583, 41);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(564, 27);
            txtDescription.TabIndex = 5;
            txtDescription.Tag = "6";
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(1155, 90);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(79, 35);
            btnClearAll.TabIndex = 6;
            btnClearAll.Tag = "13";
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1155, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 35);
            btnSearch.TabIndex = 6;
            btnSearch.Tag = "9";
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtVideoTitle
            // 
            txtVideoTitle.Location = new Point(583, 8);
            txtVideoTitle.Name = "txtVideoTitle";
            txtVideoTitle.PlaceholderText = "Video Title";
            txtVideoTitle.Size = new Size(564, 27);
            txtVideoTitle.TabIndex = 5;
            txtVideoTitle.Tag = "4";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1237, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 35);
            btnClear.TabIndex = 6;
            btnClear.Tag = "12";
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 73);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 0;
            label3.Text = "Playlist Title";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtGuide);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1336, 847);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "How to use";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGuide
            // 
            txtGuide.Dock = DockStyle.Fill;
            txtGuide.Location = new Point(3, 3);
            txtGuide.Multiline = true;
            txtGuide.Name = "txtGuide";
            txtGuide.ReadOnly = true;
            txtGuide.Size = new Size(1330, 841);
            txtGuide.TabIndex = 0;
            // 
            // bworkerDownload
            // 
            bworkerDownload.WorkerReportsProgress = true;
            bworkerDownload.DoWork += bworkerDownload_DoWork;
            bworkerDownload.ProgressChanged += bworkerDownload_ProgressChanged;
            bworkerDownload.RunWorkerCompleted += bworkerDownload_RunWorkerCompleted;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 973);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Youtube Supporter";
            ((System.ComponentModel.ISupportInitialize)dgvVideo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnShowVideo;
        private TextBox txtChannelID;
        private DataGridView dgvVideo;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtDescription;
        private TextBox txtVideoTitle;
        private Button btnClear;
        private Button btnSearch;
        private Button btnDelete;
        private TextBox txtChannel;
        private Button btnDownload;
        private ProgressBar progressBar1;
        private TextBox txtFolderPath;
        private System.ComponentModel.BackgroundWorker bworkerDownload;
        private System.Windows.Forms.Timer timerRefreshForm;
        private ComboBox cbxPlaylist;
        private ComboBox cbxStatus;
        private Label label2;
        private Label label3;
        private Button btnContinue;
        private Button btnClearAll;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewCheckBoxColumn chk;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DownloadDate;
        private DataGridViewTextBoxColumn ChannelName;
        private DataGridViewTextBoxColumn PlaylistTitle;
        private DataGridViewTextBoxColumn VideoTitle;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn ChannelId;
        private DataGridViewTextBoxColumn VideoID;
        private DataGridViewTextBoxColumn Id;
        private TabPage tabPage2;
        private TextBox txtGuide;
    }
}
