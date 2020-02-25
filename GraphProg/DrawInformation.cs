using System;
using System.Drawing;

namespace GraphProg
{
    public class DrawInformation
    {
        public Rectangle Rect => new Rectangle(
            Math.Min(drawStart.X, drawEnd.X),
            Math.Min(drawStart.Y, drawEnd.Y),
            Math.Abs(drawStart.X - drawEnd.X),
            Math.Abs(drawStart.Y - drawEnd.Y));

        public Point drawStart; // First point clicked when drawing a shape
        public Point drawEnd; // Last  mouse point when mouse is relased after drawing a shape

        public DrawInformation(Point drawStart, Point drawEnd)
        {
            this.drawStart = drawStart;
            this.drawEnd = drawEnd;
        }
    }
}
