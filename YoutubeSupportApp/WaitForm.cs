﻿using Point = System.Drawing.Point;

namespace YoutubeSupportApp
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public WaitForm(Form parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2, parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }
        public void CloseLoadingForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (label1.Image != null)
            {
                label1.Image.Dispose();
            }
        }
    }
}
