using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picscut.Controls
{
    internal class Cropper : Panel
    {
        public Cropper() : base()
        {
            EffectiveSizeChanged += OnEffectiveSizeChanged;
            RenderedRectChanged += OnRenderedRectChanged;
            SelectionBoundsChanged += OnSelectionBoundsChanged;
            CursorSupervisor.Tick += CursorCheck;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            if(LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                // Design Mode, disable timer
                CursorSupervisor.Enabled = false;
            }
        }

        private Bitmap _Image = null;
        public Bitmap Image
        {
            get => _Image;
            set
            {
                if(_Image!=value)
                {
                    _Image = value;                    
                }
            }
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

        public Rectangle _SelectionBounds { get; set; } = new Rectangle(0, 0, 0, 0);

        public Rectangle SelectionBounds
        {
            get => _SelectionBounds;
            set
            {
                if(_SelectionBounds!=value)
                {
                    _SelectionBounds = value;
                    SelectionBoundsChanged?.Invoke(this, new EventArgs());
                }
            }
        }


        const int DragButtonSize = 10;
        private Rectangle _RenderedRect = new Rectangle(0, 0, 0, 0);
        public Rectangle RenderedRect
        {
            get => _RenderedRect;
            set
            {
                if(_RenderedRect!=value)
                {
                    _RenderedRect = value;
                    RenderedRectChanged?.Invoke(this, new EventArgs());
                }
            }
        }      

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image != null)
            {
                e.Graphics.DrawImage(Image, ClientRectangle);
            }           
            if (EffectiveHeight == 0 || EffectiveWidth == 0)
                return;            
            e.Graphics.DrawRectangle(Pens.Red, RenderedRect);

            for (int i = 0; i < 4; i++)
            {
                DrawDragButton(i, e.Graphics, RenderedRect);
            }
        }

        private bool GetDragButtonCoords(int id, out int left, out int top)
        {
            var rect = RenderedRect;
            left = rect.Left;
            top = rect.Top;

            if (id < 0 || id > 3) return false;

            if (id == 1 || id == 3)
            {
                left += rect.Width - DragButtonSize;
            }
            if (id == 2 || id == 3)
            {
                top += rect.Height - DragButtonSize;
            }            
            return true;
        }

        private int _HoveredDragButtonId = -1;
        private int HoveredDragButtonId
        {
            get => _HoveredDragButtonId;
            set
            {
                if(_HoveredDragButtonId!=value)
                {
                    _HoveredDragButtonId = value;
                    Invalidate();
                }
            }
        }

        private int DownDragButtonId = -1;
        private int DownRelX = 0;
        private int DownRelY = 0;

        private void DrawDragButton(int id, Graphics g, Rectangle rect)
        {
            if (GetDragButtonCoords(id, out int left, out int top))
            {
                var brush = (id == HoveredDragButtonId ? Brushes.DodgerBlue : Brushes.White);
                g.FillRectangle(brush, left, top, DragButtonSize, DragButtonSize);
                g.DrawRectangle(Pens.Red, left, top, DragButtonSize, DragButtonSize);
            }
        }

        Timer CursorSupervisor = new Timer
        {
            Interval = 50,
            Enabled = true
        };


        protected override void OnMouseDown(MouseEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GetDragButtonCoords(i, out int left, out int top))
                {
                    if (new Rectangle(left, top, DragButtonSize, DragButtonSize).Contains(e.X, e.Y))
                    {
                        DownDragButtonId = i;
                        DownRelX = e.X - left;
                        DownRelY = e.Y - top;
                        return;
                    }
                }
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            DownDragButtonId = -1;
            base.OnMouseUp(e);
        }

        void CursorCheck(object o, EventArgs e)
        {
            Point screenPosition = Cursor.Position ;
            Point clientPosition = PointToClient(screenPosition);
            if(!(new Rectangle(0,0,Width,Height).Contains(clientPosition)))
            {
                return;
            }            

            if(DownDragButtonId!=-1)
            {
                var l = RenderedRect.Left;
                var t = RenderedRect.Top;
                var r = l + RenderedRect.Width;
                var b = t + RenderedRect.Height;
                switch (DownDragButtonId)
                {
                    case 0:
                        {
                            l = clientPosition.X - DownRelX;
                            t = clientPosition.Y - DownRelY;
                            break;
                        }
                    case 1:
                        {
                            r = clientPosition.X + DragButtonSize - DownRelX;
                            t = clientPosition.Y - DownRelY;
                            break;
                        }
                    case 2:
                        {
                            l = clientPosition.X - DownRelX;
                            b = clientPosition.Y + DragButtonSize - DownRelY;
                            break;
                        }
                    case 3:
                        {
                            r = clientPosition.X + DragButtonSize - DownRelX;
                            b = clientPosition.Y + DragButtonSize - DownRelY;
                            break;
                        }
                    default:break;
                }
                l = clamp(l, 0, Image.Width);
                t = clamp(t, 0, Image.Height);
                r = clamp(r, 0, Image.Width);
                b = clamp(b, 0, Image.Height);
                RenderedRect = new Rectangle(l, t, r - l, b - t);
                UpdateSelection();
            }

            int clamp(int x, int a, int b)
            {
                if (x < a) return a;
                if (x > b) return b;
                return x;
            }

            for (int i=0;i<4;i++)
            {
                GetDragButtonCoords(i, out int left, out int top);                
                if(new Rectangle(left, top, DragButtonSize, DragButtonSize).Contains(clientPosition))
                {
                    HoveredDragButtonId = i;
                    return;
                }
            }
            HoveredDragButtonId = -1;
            base.OnMouseHover(e);
        }

        void UpdateSelection()
        {
            var l = RenderedRect.Left;
            var t = RenderedRect.Top;
            var w = RenderedRect.Width + 1;
            var h = RenderedRect.Height + 1;
            var rect = new Rectangle
            (
                l * EffectiveWidth / Width,
                t * EffectiveHeight / Height,
                w * EffectiveWidth / Width,
                h * EffectiveHeight / Height
            );
            PerformSelectionBoundsChangedEvent = false;
            SelectionBounds = rect;
            PerformSelectionBoundsChangedEvent = true;
        }

        protected void OnEffectiveSizeChanged(object o, EventArgs e)
        {
            SelectionBounds = new Rectangle(0, 0, EffectiveWidth, EffectiveHeight);
            Invalidate();
        }

        public event Action<object, EventArgs> EffectiveSizeChanged;


        protected void OnRenderedRectChanged(object o, EventArgs e)
        {
            Debug.WriteLine("RenderedRectChanged");
            Invalidate();
        }

        private void AdjustRenderedRect()
        {
            if (EffectiveWidth == 0 || EffectiveHeight == 0)
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
            RenderedRect = rect;
        }

        bool PerformSelectionBoundsChangedEvent = true;
        protected void OnSelectionBoundsChanged(object o, EventArgs e)
        {
            if (!PerformSelectionBoundsChangedEvent) 
                return;
            Debug.WriteLine("SelectionBoundsChanged");
            AdjustRenderedRect();
        }

        public event Action<object, EventArgs> RenderedRectChanged;
        public event Action<object, EventArgs> SelectionBoundsChanged;

        protected override void OnResize(EventArgs eventargs)
        {
            AdjustRenderedRect();
            base.OnResize(eventargs);
        }
    }
}
