using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace MonaLisa
{
    public abstract class Pattern
    {
        public abstract Bitmap AddToImage(Bitmap bitmap);
    }
}
