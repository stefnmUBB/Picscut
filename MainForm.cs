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
            Cropper.Image = PicsList.SelectedPicture.Bitmap;            
            AdjustCropperSize();
        }

        private void AdjustCropperSize()
        {
            if (Cropper.Image == null) 
                return;

            Cropper.Size = FitRatio(PicViewer.Size, Cropper.Image.Size);
            Cropper.Left = (PicViewer.Width - Cropper.Width) / 2;
            Cropper.Top = (PicViewer.Height - Cropper.Height) / 2;            
            Cropper.EffectizeSize = Cropper.Image.Size;
            Cropper.Invalidate();
        }

        private void PicViewer_Resize(object sender, EventArgs e)
        {
            AdjustCropperSize();
        }      

        private void PicsList_PicsSizeChanged(object sender, EventArgs e)
        {

        }

        private void Cropper_SelectionBoundsChanged(object arg1, EventArgs arg2)
        {
            SelTopBox.Value = Cropper.SelectionBounds.Top;
            SelLeftBox.Value = Cropper.SelectionBounds.Left;
            SelWidthBox.Value = Cropper.SelectionBounds.Width;
            SelHeightBox.Value = Cropper.SelectionBounds.Height;
        }
    }
}
