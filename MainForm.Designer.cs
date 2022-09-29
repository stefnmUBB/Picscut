namespace Picscut
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Body = new System.Windows.Forms.Panel();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.PicsList = new Picscut.Controls.PicsList();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PicViewer = new System.Windows.Forms.Panel();
            this.Body.SuspendLayout();
            this.BottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.PicViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.Controls.Add(this.PicViewer);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(2);
            this.Body.Size = new System.Drawing.Size(707, 208);
            this.Body.TabIndex = 0;
            // 
            // BottomBar
            // 
            this.BottomBar.Controls.Add(this.PicsList);
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 208);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(707, 120);
            this.BottomBar.TabIndex = 1;
            // 
            // PicsList
            // 
            this.PicsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicsList.ColumnWidth = 64;
            this.PicsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PicsList.FormattingEnabled = true;
            this.PicsList.HorizontalScrollbar = true;
            this.PicsList.ItemHeight = 1;
            this.PicsList.Location = new System.Drawing.Point(12, 6);
            this.PicsList.MultiColumn = true;
            this.PicsList.Name = "PicsList";
            this.PicsList.Size = new System.Drawing.Size(683, 103);
            this.PicsList.TabIndex = 0;
            this.PicsList.SelectedIndexChanged += new System.EventHandler(this.PicsList_SelectedIndexChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.PictureBox.Location = new System.Drawing.Point(244, 40);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(426, 102);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // PicViewer
            // 
            this.PicViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicViewer.Controls.Add(this.PictureBox);
            this.PicViewer.Location = new System.Drawing.Point(12, 12);
            this.PicViewer.Name = "PicViewer";
            this.PicViewer.Size = new System.Drawing.Size(683, 190);
            this.PicViewer.TabIndex = 1;
            this.PicViewer.Resize += new System.EventHandler(this.PicViewer_Resize);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(707, 328);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.BottomBar);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Body.ResumeLayout(false);
            this.BottomBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.PicViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Panel BottomBar;
        private Controls.PicsList PicsList;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel PicViewer;
    }
}

