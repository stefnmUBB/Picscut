using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picscut
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PicsList.Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            for (int k = 1; k < 50; k++)
            {
                if (System.IO.File.Exists($@"C:\Users\Stefan\Pictures\Screenshots\Screenshot ({k}).png"))
                {
                    PicsList.AddPicture($@"C:\Users\Stefan\Pictures\Screenshots\Screenshot ({k}).png");
                }
            }            
        }

        Size FitRatio(Size container, Size target)
        {
            Size sw = new Size(container.Width, target.Height * container.Width / target.Width);
            Size sh = new Size(target.Width * container.Height / target.Height, container.Height);
            if (sw.Height < container.Height) return sw;
            else return sh;
        }

        private void PicsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBox.Image = PicsList.SelectedPicture.Bitmap;
            AdjustPictureBoxSize();
        }

        private void AdjustPictureBoxSize()
        {
            if (PictureBox.Image == null)
                return;
            PictureBox.Size = FitRatio(PicViewer.Size, PictureBox.Image.Size);
            PictureBox.Left = (PicViewer.Width - PictureBox.Width) / 2;
            PictureBox.Top = (PicViewer.Height - PictureBox.Height) / 2;

            Cropper.Left = PictureBox.Left;
            Cropper.Top = PictureBox.Top;
            Cropper.Size = PictureBox.Size;
            Cropper.EffectizeSize = PictureBox.Image.Size;
            Cropper.Invalidate();
        }

        private void PicViewer_Resize(object sender, EventArgs e)
        {
            AdjustPictureBoxSize();
        }      

        private void PicsList_PicsSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
