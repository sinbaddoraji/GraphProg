using System;
using System.Drawing;

namespace GraphProg
{
    public class DrawInformation
    {
        public RectangleF Rect => new RectangleF(
            Math.Min(drawStart.X, drawEnd.X),
            Math.Min(drawStart.Y, drawEnd.Y),
            Math.Abs(drawStart.X - drawEnd.X),
            Math.Abs(drawStart.Y - drawEnd.Y));

        public PointF Center => new PointF(Rect.Left + Rect.Width / 2,
                    Rect.Top + Rect.Height / 2);

        public PointF drawStart; // First point clicked when drawing a shape
        public PointF drawEnd; // Last  mouse point when mouse is relased after drawing a shape

        public DrawInformation(PointF drawStart, PointF drawEnd)
        {
            this.drawStart = drawStart;
            this.drawEnd = drawEnd;
        }
    }
}
