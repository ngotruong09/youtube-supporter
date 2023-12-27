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
            Id = new DataGridViewTextBoxColumn();
            ChannelName = new DataGridViewTextBoxColumn();
            PlaylistTitle = new DataGridViewTextBoxColumn();
            VideoTitle = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Url = new DataGridViewTextBoxColumn();
            ChannelId = new DataGridViewTextBoxColumn();
            VideoID = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            progressBar1 = new ProgressBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cbxStatus = new ComboBox();
            cbxPlaylist = new ComboBox();
            btnDownload = new Button();
            txtFolderPath = new TextBox();
            btnDelete = new Button();
            txtChannel = new TextBox();
            txtDescription = new TextBox();
            btnSearch = new Button();
            txtVideoTitle = new TextBox();
            btnClear = new Button();
            tabPage2 = new TabPage();
            bworkerDownload = new System.ComponentModel.BackgroundWorker();
            timerRefreshForm = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvVideo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "ChannelID";
            // 
            // btnShowVideo
            // 
            btnShowVideo.Location = new Point(1013, 19);
            btnShowVideo.Margin = new Padding(3, 2, 3, 2);
            btnShowVideo.Name = "btnShowVideo";
            btnShowVideo.Size = new Size(150, 22);
            btnShowVideo.TabIndex = 1;
            btnShowVideo.Text = "Get info from channel";
            btnShowVideo.UseVisualStyleBackColor = true;
            btnShowVideo.Click += btnShowVideo_Click;
            // 
            // txtChannelID
            // 
            txtChannelID.Location = new Point(79, 20);
            txtChannelID.Margin = new Padding(3, 2, 3, 2);
            txtChannelID.Name = "txtChannelID";
            txtChannelID.Size = new Size(929, 23);
            txtChannelID.TabIndex = 2;
            // 
            // dgvVideo
            // 
            dgvVideo.AllowUserToAddRows = false;
            dgvVideo.AllowUserToDeleteRows = false;
            dgvVideo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVideo.BackgroundColor = SystemColors.ActiveCaption;
            dgvVideo.BorderStyle = BorderStyle.None;
            dgvVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideo.Columns.AddRange(new DataGridViewColumn[] { chk, Status, DownloadDate, Id, ChannelName, PlaylistTitle, VideoTitle, Description, Url, ChannelId, VideoID });
            dgvVideo.Location = new Point(7, 23);
            dgvVideo.Margin = new Padding(3, 2, 3, 2);
            dgvVideo.Name = "dgvVideo";
            dgvVideo.RowHeadersWidth = 51;
            dgvVideo.RowTemplate.Height = 29;
            dgvVideo.Size = new Size(1141, 461);
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
            Status.Name = "Status";
            Status.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DownloadDate
            // 
            DownloadDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DownloadDate.DataPropertyName = "DownloadDate";
            DownloadDate.HeaderText = "Date";
            DownloadDate.Name = "DownloadDate";
            DownloadDate.Width = 56;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 42;
            // 
            // ChannelName
            // 
            ChannelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ChannelName.DataPropertyName = "ChannelName";
            ChannelName.HeaderText = "Channel Name";
            ChannelName.MinimumWidth = 6;
            ChannelName.Name = "ChannelName";
            ChannelName.Width = 111;
            // 
            // PlaylistTitle
            // 
            PlaylistTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PlaylistTitle.DataPropertyName = "PlaylistTitle";
            PlaylistTitle.HeaderText = "Playlist Title";
            PlaylistTitle.MinimumWidth = 6;
            PlaylistTitle.Name = "PlaylistTitle";
            PlaylistTitle.Width = 94;
            // 
            // VideoTitle
            // 
            VideoTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            VideoTitle.DataPropertyName = "VideoTitle";
            VideoTitle.HeaderText = "Video Title";
            VideoTitle.MinimumWidth = 6;
            VideoTitle.Name = "VideoTitle";
            VideoTitle.Width = 87;
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
            Url.Width = 47;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChannelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnShowVideo);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1176, 53);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Youtube";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(progressBar1);
            groupBox3.Controls.Add(dgvVideo);
            groupBox3.Location = new Point(9, 110);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1156, 518);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(7, 488);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1144, 22);
            progressBar1.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 67);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1176, 660);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbxStatus);
            tabPage1.Controls.Add(cbxPlaylist);
            tabPage1.Controls.Add(btnDownload);
            tabPage1.Controls.Add(txtFolderPath);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(txtChannel);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtVideoTitle);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1168, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "WAITING", "DOWNLOADING", "PENDING", "DONE", "FAIL" });
            cbxStatus.Location = new Point(9, 82);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(995, 23);
            cbxStatus.TabIndex = 8;
            cbxStatus.SelectedValueChanged += cbxStatus_SelectedValueChanged;
            // 
            // cbxPlaylist
            // 
            cbxPlaylist.FormattingEnabled = true;
            cbxPlaylist.Location = new Point(9, 31);
            cbxPlaylist.Name = "cbxPlaylist";
            cbxPlaylist.Size = new Size(494, 23);
            cbxPlaylist.TabIndex = 8;
            cbxPlaylist.SelectedValueChanged += cbxPlaylist_SelectedValueChanged;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(1082, 46);
            btnDownload.Margin = new Padding(3, 2, 3, 2);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 33);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(9, 56);
            txtFolderPath.Margin = new Padding(3, 2, 3, 2);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.PlaceholderText = "Folder Path";
            txtFolderPath.Size = new Size(995, 23);
            txtFolderPath.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1011, 6);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 33);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtChannel
            // 
            txtChannel.Location = new Point(9, 6);
            txtChannel.Margin = new Padding(3, 2, 3, 2);
            txtChannel.Name = "txtChannel";
            txtChannel.PlaceholderText = "Channel";
            txtChannel.Size = new Size(494, 23);
            txtChannel.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(510, 31);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(494, 23);
            txtDescription.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1011, 46);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 33);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtVideoTitle
            // 
            txtVideoTitle.Location = new Point(510, 6);
            txtVideoTitle.Margin = new Padding(3, 2, 3, 2);
            txtVideoTitle.Name = "txtVideoTitle";
            txtVideoTitle.PlaceholderText = "Video Title";
            txtVideoTitle.Size = new Size(494, 23);
            txtVideoTitle.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1082, 6);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 33);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1168, 632);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Download";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // bworkerDownload
            // 
            bworkerDownload.WorkerReportsProgress = true;
            bworkerDownload.DoWork += bworkerDownload_DoWork;
            bworkerDownload.ProgressChanged += bworkerDownload_ProgressChanged;
            bworkerDownload.RunWorkerCompleted += bworkerDownload_RunWorkerCompleted;
            // 
            // timerRefreshForm
            // 
            timerRefreshForm.Interval = 1000;
            timerRefreshForm.Tick += timerRefreshForm_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 730);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Youtube Supporter";
            ((System.ComponentModel.ISupportInitialize)dgvVideo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private TabPage tabPage2;
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
        private DataGridViewCheckBoxColumn chk;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DownloadDate;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ChannelName;
        private DataGridViewTextBoxColumn PlaylistTitle;
        private DataGridViewTextBoxColumn VideoTitle;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn ChannelId;
        private DataGridViewTextBoxColumn VideoID;
        private System.Windows.Forms.Timer timerRefreshForm;
        private ComboBox cbxPlaylist;
        private ComboBox cbxStatus;
    }
}
