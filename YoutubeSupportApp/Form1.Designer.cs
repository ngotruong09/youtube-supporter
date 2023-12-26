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
            Id = new DataGridViewTextBoxColumn();
            ChannelName = new DataGridViewTextBoxColumn();
            PlaylistTitle = new DataGridViewTextBoxColumn();
            VideoTitle = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Url = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnDownload = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            txtChannel = new TextBox();
            txtDescription = new TextBox();
            txtVideoTitle = new TextBox();
            txtPlaylistTitle = new TextBox();
            tabPage2 = new TabPage();
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
            label1.Location = new Point(4, 34);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "ChannelID";
            // 
            // btnShowVideo
            // 
            btnShowVideo.Location = new Point(1129, 25);
            btnShowVideo.Name = "btnShowVideo";
            btnShowVideo.Size = new Size(195, 29);
            btnShowVideo.TabIndex = 1;
            btnShowVideo.Text = "Get info from channel";
            btnShowVideo.UseVisualStyleBackColor = true;
            btnShowVideo.Click += btnShowVideo_Click;
            // 
            // txtChannelID
            // 
            txtChannelID.Location = new Point(90, 27);
            txtChannelID.Name = "txtChannelID";
            txtChannelID.Size = new Size(1033, 27);
            txtChannelID.TabIndex = 2;
            // 
            // dgvVideo
            // 
            dgvVideo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVideo.BackgroundColor = SystemColors.ActiveCaption;
            dgvVideo.BorderStyle = BorderStyle.None;
            dgvVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideo.Columns.AddRange(new DataGridViewColumn[] { Id, ChannelName, PlaylistTitle, VideoTitle, Description, Url });
            dgvVideo.Location = new Point(8, 25);
            dgvVideo.Name = "dgvVideo";
            dgvVideo.RowHeadersWidth = 51;
            dgvVideo.RowTemplate.Height = 29;
            dgvVideo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVideo.Size = new Size(1308, 465);
            dgvVideo.TabIndex = 3;
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
            groupBox3.Controls.Add(dgvVideo);
            groupBox3.Location = new Point(6, 115);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1324, 496);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
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
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(txtChannel);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(txtVideoTitle);
            tabPage1.Controls.Add(txtPlaylistTitle);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1336, 617);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 58);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 5);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 7;
            label3.Text = "Video Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 58);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 7;
            label5.Text = "Playlist Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 5);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 7;
            label2.Text = "Channel";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(1226, 28);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(94, 81);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1140, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 81);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1052, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 81);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtChannel
            // 
            txtChannel.Location = new Point(14, 28);
            txtChannel.Name = "txtChannel";
            txtChannel.PlaceholderText = "Channel";
            txtChannel.Size = new Size(513, 27);
            txtChannel.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(533, 82);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(513, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtVideoTitle
            // 
            txtVideoTitle.Location = new Point(533, 28);
            txtVideoTitle.Name = "txtVideoTitle";
            txtVideoTitle.PlaceholderText = "Video Title";
            txtVideoTitle.Size = new Size(513, 27);
            txtVideoTitle.TabIndex = 5;
            // 
            // txtPlaylistTitle
            // 
            txtPlaylistTitle.Location = new Point(14, 82);
            txtPlaylistTitle.Name = "txtPlaylistTitle";
            txtPlaylistTitle.PlaceholderText = "Playlist Title";
            txtPlaylistTitle.Size = new Size(513, 27);
            txtPlaylistTitle.TabIndex = 5;
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ChannelName;
        private DataGridViewTextBoxColumn PlaylistTitle;
        private DataGridViewTextBoxColumn VideoTitle;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Url;
        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtDescription;
        private TextBox txtVideoTitle;
        private TextBox txtPlaylistTitle;
        private Button btnDownload;
        private Button btnSearch;
        private Button btnDelete;
        private TextBox txtChannel;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
    }
}
