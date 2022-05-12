using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MonaLisa.Patterns
{
    public class ColoredTriangle : Pattern
    {
        private static Random rand = new Random();
        private readonly Color _color;
        private readonly Point[] _points;       

        public ColoredTriangle(int bitmapWidth, int bitmapHeight, Color color)
        {
            _points = GetRandomTriangleCoordinates(bitmapWidth, bitmapHeight);
            _color = color;
        }

        public override Bitmap AddToImage(Bitmap oldBitmap)
        {
            Bitmap newBitmap = new Bitmap(oldBitmap);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPolygon(new SolidBrush(_color), _points);
            }
            return newBitmap;
        }

        public Point[] GetRandomTriangleCoordinates(int bitmapWidth, int bitmapHeight)
        {
            Point[] points = {new Point(rand.Next(bitmapWidth), rand.Next(bitmapHeight)),
                                new Point(rand.Next(bitmapWidth), rand.Next(bitmapHeight)),
                                new Point(rand.Next(bitmapWidth), rand.Next(bitmapHeight))};
            return points;
        }
    }
}
