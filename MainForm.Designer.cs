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
            this.PicViewer = new System.Windows.Forms.Panel();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.PicsList = new Picscut.Controls.PicsList();
            this.BottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicViewer
            // 
            this.PicViewer.BackColor = System.Drawing.Color.White;
            this.PicViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicViewer.Location = new System.Drawing.Point(0, 0);
            this.PicViewer.Name = "PicViewer";
            this.PicViewer.Size = new System.Drawing.Size(694, 244);
            this.PicViewer.TabIndex = 0;
            // 
            // BottomBar
            // 
            this.BottomBar.Controls.Add(this.PicsList);
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 244);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(694, 100);
            this.BottomBar.TabIndex = 1;
            // 
            // PicsList
            // 
            this.PicsList.ColumnWidth = 64;
            this.PicsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PicsList.FormattingEnabled = true;
            this.PicsList.HorizontalScrollbar = true;
            this.PicsList.ItemHeight = 64;
            this.PicsList.Location = new System.Drawing.Point(12, 6);
            this.PicsList.MultiColumn = true;
            this.PicsList.Name = "PicsList";
            this.PicsList.Size = new System.Drawing.Size(670, 68);
            this.PicsList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(694, 344);
            this.Controls.Add(this.PicViewer);
            this.Controls.Add(this.BottomBar);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BottomBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PicViewer;
        private System.Windows.Forms.Panel BottomBar;
        private Controls.PicsList PicsList;
    }
}

