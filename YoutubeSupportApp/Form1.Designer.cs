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
            label1 = new Label();
            btnShowVideo = new Button();
            txtChannelID = new TextBox();
            dgvVideo = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            progressBar1 = new ProgressBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDownload = new Button();
            txtFolderPath = new TextBox();
            btnDelete = new Button();
            txtChannel = new TextBox();
            txtDescription = new TextBox();
            btnSearch = new Button();
            txtVideoTitle = new TextBox();
            txtPlaylistTitle = new TextBox();
            btnClear = new Button();
            chkFolderPath = new CheckBox();
            tabPage2 = new TabPage();
            bworkerDownload = new System.ComponentModel.BackgroundWorker();
            chk = new DataGridViewCheckBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ChannelName = new DataGridViewTextBoxColumn();
            PlaylistTitle = new DataGridViewTextBoxColumn();
            VideoTitle = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Url = new DataGridViewTextBoxColumn();
            ChannelId = new DataGridViewTextBoxColumn();
            VideoID = new DataGridViewTextBoxColumn();
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
            // 
            // dgvVideo
            // 
            dgvVideo.AllowUserToAddRows = false;
            dgvVideo.AllowUserToDeleteRows = false;
            dgvVideo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVideo.BackgroundColor = SystemColors.ActiveCaption;
            dgvVideo.BorderStyle = BorderStyle.None;
            dgvVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideo.Columns.AddRange(new DataGridViewColumn[] { chk, Id, ChannelName, PlaylistTitle, VideoTitle, Description, Url, ChannelId, VideoID });
            dgvVideo.Location = new Point(8, 31);
            dgvVideo.Name = "dgvVideo";
            dgvVideo.RowHeadersWidth = 51;
            dgvVideo.RowTemplate.Height = 29;
            dgvVideo.Size = new Size(1308, 431);
            dgvVideo.TabIndex = 3;
            dgvVideo.CellMouseDoubleClick += dgvVideo_CellMouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChannelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnShowVideo);
            groupBox1.Location = new Point(12, 12);
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
            groupBox3.Location = new Point(6, 104);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1324, 507);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(8, 468);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1308, 29);
            progressBar1.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 89);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1344, 650);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDownload);
            tabPage1.Controls.Add(txtFolderPath);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(txtChannel);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtVideoTitle);
            tabPage1.Controls.Add(txtPlaylistTitle);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(chkFolderPath);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1336, 617);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(1236, 40);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(86, 28);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(10, 74);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.PlaceholderText = "Folder Path (Check the checkbox if you want to group by playlist)";
            txtFolderPath.Size = new Size(1108, 27);
            txtFolderPath.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1155, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 28);
            btnDelete.TabIndex = 6;
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
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(583, 41);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(564, 27);
            txtDescription.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1155, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 28);
            btnSearch.TabIndex = 6;
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
            // 
            // txtPlaylistTitle
            // 
            txtPlaylistTitle.Location = new Point(10, 41);
            txtPlaylistTitle.Name = "txtPlaylistTitle";
            txtPlaylistTitle.PlaceholderText = "Playlist Title";
            txtPlaylistTitle.Size = new Size(564, 27);
            txtPlaylistTitle.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1236, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 28);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // chkFolderPath
            // 
            chkFolderPath.AutoSize = true;
            chkFolderPath.Location = new Point(1124, 79);
            chkFolderPath.Name = "chkFolderPath";
            chkFolderPath.Size = new Size(18, 17);
            chkFolderPath.TabIndex = 8;
            chkFolderPath.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1336, 617);
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
            // chk
            // 
            chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            chk.HeaderText = "";
            chk.MinimumWidth = 6;
            chk.Name = "chk";
            chk.Width = 50;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 743);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
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
        private TextBox txtPlaylistTitle;
        private Button btnClear;
        private Button btnSearch;
        private Button btnDelete;
        private TextBox txtChannel;
        private Button btnDownload;
        private ProgressBar progressBar1;
        private TextBox txtFolderPath;
        private CheckBox chkFolderPath;
        private System.ComponentModel.BackgroundWorker bworkerDownload;
        private DataGridViewCheckBoxColumn chk;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ChannelName;
        private DataGridViewTextBoxColumn PlaylistTitle;
        private DataGridViewTextBoxColumn VideoTitle;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn ChannelId;
        private DataGridViewTextBoxColumn VideoID;
    }
}
