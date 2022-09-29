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
            }
            e.DrawFocusRectangle();
        }                

        public void AddPicture(string path)
        {            
            try
            {
                var bmp = new Bitmap(path);
                var pic = new Picture
                {
                    Path = path,
                    Bitmap = bmp
                };
                Pictures.Add(pic);                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public Picture SelectedPicture { get => SelectedValue as Picture; }
    }
}
