using Picscut.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picscut.Controls
{
    internal class PicsList : ListBox
    {
        public BindingList<Picture> Pictures { get => DataSource as BindingList<Picture>; }
        public PicsList()
        {
            this.BindingContext = new BindingContext();
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.MultiColumn = true;
            this.ColumnWidth = 64;
            this.HorizontalScrollbar = true;
            this.Height = 64 + SystemInformation.HorizontalScrollBarHeight;
            this.ItemHeight = 64;
            this.IntegralHeight = false;
        }        

        public void Init()
        {
            DataSource = new BindingList<Picture>();
        }

        bool resizing = false;
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (resizing) return;
            resizing = true;
            this.ItemHeight = this.ColumnWidth = Height - SystemInformation.HorizontalScrollBarHeight;
            resizing = false;

        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (0 <= e.Index && e.Index < Items.Count) 
            {
                var item = Items[e.Index] as Picture;                
                e.Graphics.DrawImage(item.Thumbnail, e.Bounds);
                if (e.Index != 0)
                    e.Graphics.DrawLine(Pens.Gray,e.Bounds.Left, e.Bounds.Top, e.Bounds.Left, e.Bounds.Top + e.Bounds.Height);
            }            
            e.DrawFocusRectangle();
        }                

        public void AddPicture(string path)
        {                       
            var bmp = new Bitmap(path);
            var pic = new Picture
            {
                Path = path,
                Bitmap = bmp
            };
            if(Pictures.Count==0)
            {
                PicsSize = bmp.Size;
                PicsSizeChanged?.Invoke(this, new EventArgs());
            }
            if (PicsSize != bmp.Size)
                throw new ArgumentException("Image sizes do not match.");
            Pictures.Add(pic);                                                  
        }

        public Picture SelectedPicture { get => SelectedValue as Picture; }
        
        public Size PicsSize { get; private set; }

        public int PicsWidth { get => PicsSize.Width; }
        public int PicsHeight { get => PicsSize.Height; }

        public delegate void OnPicsSizeChanged(object sender, EventArgs e);
        public event OnPicsSizeChanged PicsSizeChanged;


    }
}
