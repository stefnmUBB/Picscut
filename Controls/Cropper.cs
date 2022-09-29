using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picscut.Controls
{
    internal class Cropper : TransparentPanel
    {
        public Cropper() : base()
        {
            EffectiveSizeChanged += OnEffectiveSizeChanged;            
        }
        private Size _EffectiveSize;

        public int EffectiveWidth
        {
            get => _EffectiveSize.Width;
            set
            {
                if (_EffectiveSize.Width != value)
                {
                    _EffectiveSize.Width = value;
                    EffectiveSizeChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public int EffectiveHeight
        {
            get => _EffectiveSize.Height;
            set
            {
                if (_EffectiveSize.Height != value)
                {
                    _EffectiveSize.Height = value;
                    EffectiveSizeChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public Size EffectizeSize
        {
            get => _EffectiveSize;
            set
            {
                if (_EffectiveSize != value)
                {
                    _EffectiveSize = value;
                    EffectiveSizeChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public Rectangle SelectionBounds { get; set; } = new Rectangle(0, 0, 0, 0);

        const int DragButtonSize = 10;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (EffectiveHeight == 0 || EffectiveWidth == 0)
                return;
            var rect = new Rectangle
            (
                SelectionBounds.Left * Width / EffectiveWidth,
                SelectionBounds.Top * Height / EffectiveHeight,
                SelectionBounds.Width * Width / EffectiveWidth,
                SelectionBounds.Height * Height / EffectiveHeight
            );
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(Pens.Red, rect);

            e.Graphics.FillRectangle(Brushes.White, rect.Left, rect.Top, DragButtonSize, DragButtonSize);
            e.Graphics.DrawRectangle(Pens.Red, rect.Left, rect.Top, DragButtonSize, DragButtonSize);

            e.Graphics.FillRectangle(Brushes.White, rect.Width-DragButtonSize, rect.Top, DragButtonSize, DragButtonSize);
            e.Graphics.DrawRectangle(Pens.Red, rect.Width-DragButtonSize, rect.Top, DragButtonSize, DragButtonSize);

            e.Graphics.FillRectangle(Brushes.White, rect.Left, rect.Height - DragButtonSize, DragButtonSize, DragButtonSize);
            e.Graphics.DrawRectangle(Pens.Red, rect.Left, rect.Height - DragButtonSize, DragButtonSize, DragButtonSize);

            e.Graphics.FillRectangle(Brushes.White, rect.Width - DragButtonSize, rect.Height - DragButtonSize, DragButtonSize, DragButtonSize);
            e.Graphics.DrawRectangle(Pens.Red, rect.Width - DragButtonSize, rect.Height - DragButtonSize, DragButtonSize, DragButtonSize);


        }

        protected void OnEffectiveSizeChanged(object o, EventArgs e)
        {
            SelectionBounds = new Rectangle(0, 0, EffectiveWidth, EffectiveHeight);
            Invalidate();
        }

        public event Action<object, EventArgs> EffectiveSizeChanged;



    }
}
