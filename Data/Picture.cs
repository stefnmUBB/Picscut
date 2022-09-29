using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picscut.Data
{
    [Serializable]
    internal class Picture
    {
        public Picture() { }
        public string Path { get; set; }
        public Bitmap Bitmap { get; set; }

        /*[NonSerialized]
        private Bitmap _Thumbnail = null;
        
        public Bitmap Thumbnail
        {          
            get
            {
                if(_Thumbnail==null)
                {
                    _Thumbnail = new Bitmap(64, 64);
                    int w = 64, h = 64;
                    if(Bitmap.Width>Bitmap.Height)
                    {
                        h = 64 * Bitmap.Height / Bitmap.Width;
                    }
                    else
                    {
                        w = 64 * Bitmap.Width / Bitmap.Height;
                    }
                    Graphics.FromImage(_Thumbnail).DrawImage(Bitmap, (64 - w) / 2, (64 - h) / 2, w, h);
                }
                return _Thumbnail;
            }
            set { _Thumbnail = value; }
        }*/
    }
}
