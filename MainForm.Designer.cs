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
            this.PicViewer = new System.Windows.Forms.Panel();
            this.Cropper = new Picscut.Controls.Cropper();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.PicsList = new Picscut.Controls.PicsList();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.SaveOverBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelHeightBox = new System.Windows.Forms.NumericUpDown();
            this.SelLeftBox = new System.Windows.Forms.NumericUpDown();
            this.SelTopBox = new System.Windows.Forms.NumericUpDown();
            this.SelWidthBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Body.SuspendLayout();
            this.PicViewer.SuspendLayout();
            this.BottomBar.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelLeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelTopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelWidthBox)).BeginInit();
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
            this.Body.Size = new System.Drawing.Size(536, 258);
            this.Body.TabIndex = 0;
            // 
            // PicViewer
            // 
            this.PicViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicViewer.Controls.Add(this.Cropper);
            this.PicViewer.Location = new System.Drawing.Point(12, 12);
            this.PicViewer.Name = "PicViewer";
            this.PicViewer.Size = new System.Drawing.Size(512, 240);
            this.PicViewer.TabIndex = 1;
            this.PicViewer.Resize += new System.EventHandler(this.PicViewer_Resize);
            // 
            // Cropper
            // 
            this.Cropper._SelectionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Cropper.EffectiveHeight = 0;
            this.Cropper.EffectiveWidth = 0;
            this.Cropper.EffectizeSize = new System.Drawing.Size(0, 0);
            this.Cropper.Image = null;
            this.Cropper.Location = new System.Drawing.Point(3, 3);
            this.Cropper.Name = "Cropper";
            this.Cropper.RenderedRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Cropper.SelectionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Cropper.Size = new System.Drawing.Size(16, 16);
            this.Cropper.TabIndex = 1;
            this.Cropper.SelectionBoundsChanged += new System.Action<object, System.EventArgs>(this.Cropper_SelectionBoundsChanged);
            // 
            // BottomBar
            // 
            this.BottomBar.Controls.Add(this.PicsList);
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 258);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(707, 120);
            this.BottomBar.TabIndex = 1;
            // 
            // PicsList
            // 
            this.PicsList.AllowDrop = true;
            this.PicsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicsList.ColumnWidth = 86;
            this.PicsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PicsList.FormattingEnabled = true;
            this.PicsList.HorizontalScrollbar = true;
            this.PicsList.IntegralHeight = false;
            this.PicsList.ItemHeight = 86;
            this.PicsList.Location = new System.Drawing.Point(12, 6);
            this.PicsList.MultiColumn = true;
            this.PicsList.Name = "PicsList";
            this.PicsList.Size = new System.Drawing.Size(683, 103);
            this.PicsList.TabIndex = 0;
            this.PicsList.PicsSizeChanged += new Picscut.Controls.PicsList.OnPicsSizeChanged(this.PicsList_PicsSizeChanged);
            this.PicsList.SelectedIndexChanged += new System.EventHandler(this.PicsList_SelectedIndexChanged);
            this.PicsList.DragDrop += new System.Windows.Forms.DragEventHandler(this.PicsList_DragDrop);
            this.PicsList.DragEnter += new System.Windows.Forms.DragEventHandler(this.PicsList_DragEnter);
            // 
            // ResultPanel
            // 
            this.ResultPanel.Controls.Add(this.SaveOverBtn);
            this.ResultPanel.Controls.Add(this.groupBox1);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResultPanel.Location = new System.Drawing.Point(536, 0);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(171, 258);
            this.ResultPanel.TabIndex = 2;
            // 
            // SaveOverBtn
            // 
            this.SaveOverBtn.Location = new System.Drawing.Point(16, 149);
            this.SaveOverBtn.Name = "SaveOverBtn";
            this.SaveOverBtn.Size = new System.Drawing.Size(63, 23);
            this.SaveOverBtn.TabIndex = 1;
            this.SaveOverBtn.Text = "Save";
            this.SaveOverBtn.UseVisualStyleBackColor = true;
            this.SaveOverBtn.Click += new System.EventHandler(this.SaveOverBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelHeightBox);
            this.groupBox1.Controls.Add(this.SelLeftBox);
            this.groupBox1.Controls.Add(this.SelTopBox);
            this.groupBox1.Controls.Add(this.SelWidthBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // SelHeightBox
            // 
            this.SelHeightBox.Location = new System.Drawing.Point(51, 96);
            this.SelHeightBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.SelHeightBox.Name = "SelHeightBox";
            this.SelHeightBox.Size = new System.Drawing.Size(96, 20);
            this.SelHeightBox.TabIndex = 7;
            this.SelHeightBox.ValueChanged += new System.EventHandler(this.SelBox_ValueChanged);
            this.SelHeightBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelBox_KeyUp);
            // 
            // SelLeftBox
            // 
            this.SelLeftBox.Location = new System.Drawing.Point(51, 18);
            this.SelLeftBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.SelLeftBox.Name = "SelLeftBox";
            this.SelLeftBox.Size = new System.Drawing.Size(96, 20);
            this.SelLeftBox.TabIndex = 6;
            this.SelLeftBox.ValueChanged += new System.EventHandler(this.SelBox_ValueChanged);
            this.SelLeftBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelBox_KeyUp);
            // 
            // SelTopBox
            // 
            this.SelTopBox.Location = new System.Drawing.Point(51, 44);
            this.SelTopBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.SelTopBox.Name = "SelTopBox";
            this.SelTopBox.Size = new System.Drawing.Size(96, 20);
            this.SelTopBox.TabIndex = 5;
            this.SelTopBox.ValueChanged += new System.EventHandler(this.SelBox_ValueChanged);
            this.SelTopBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelBox_KeyUp);
            // 
            // SelWidthBox
            // 
            this.SelWidthBox.Location = new System.Drawing.Point(51, 70);
            this.SelWidthBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.SelWidthBox.Name = "SelWidthBox";
            this.SelWidthBox.Size = new System.Drawing.Size(96, 20);
            this.SelWidthBox.TabIndex = 4;
            this.SelWidthBox.ValueChanged += new System.EventHandler(this.SelBox_ValueChanged);
            this.SelWidthBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(707, 378);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.BottomBar);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Body.ResumeLayout(false);
            this.PicViewer.ResumeLayout(false);
            this.BottomBar.ResumeLayout(false);
            this.ResultPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelLeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelTopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelWidthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Panel BottomBar;
        private Controls.PicsList PicsList;
        private System.Windows.Forms.Panel PicViewer;
        private Controls.Cropper Cropper;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SelHeightBox;
        private System.Windows.Forms.NumericUpDown SelLeftBox;
        private System.Windows.Forms.NumericUpDown SelTopBox;
        private System.Windows.Forms.NumericUpDown SelWidthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveOverBtn;
    }
}

