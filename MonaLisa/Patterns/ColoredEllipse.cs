using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace MonaLisa.Patterns
{
    public class ColoredEllipse : Pattern
    {
        private static Random rand = new Random();
        private readonly Color _color;
        private readonly Rectangle _rectangle;

        public ColoredEllipse(int bitmapWidth, int bitmapHeight, Color color)
        {
            int x = rand.Next(bitmapWidth);
            int y = rand.Next(bitmapHeight);
            int width = rand.Next(bitmapWidth - x);
            int height = rand.Next(bitmapHeight - y);
            _rectangle = new Rectangle(x, y, width, height);
            _color = color;
        }

        public override Bitmap AddToImage(Bitmap oldBitmap)
        {
            Bitmap newBitmap = new Bitmap(oldBitmap);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(new SolidBrush(_color), _rectangle);
            }
            return newBitmap;
        }
    }
}
