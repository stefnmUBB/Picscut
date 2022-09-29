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

        [NonSerialized]
        private Bitmap _Thumbnail = null;
        
        public Bitmap Thumbnail
        {          
            get
            {
                if(_Thumbnail==null)
                {
                    int tsize = 128;
                    _Thumbnail = new Bitmap(tsize, tsize);
                    int w = tsize, h = tsize;
                    if(Bitmap.Width>Bitmap.Height)
                    {
                        h = tsize * Bitmap.Height / Bitmap.Width;
                    }
                    else
                    {
                        w = tsize * Bitmap.Width / Bitmap.Height;
                    }
                    Graphics.FromImage(_Thumbnail).DrawImage(Bitmap, (tsize - w) / 2, (tsize - h) / 2, w, h);
                }
                return _Thumbnail;
            }            
        }
    }
}
