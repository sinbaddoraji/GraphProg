using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg
{
    public class DrawInformation
    {
        public Rectangle rect => new Rectangle(
            Math.Min(drawStart.X, drawEnd.X),
            Math.Min(drawStart.Y, drawEnd.Y),
            Math.Abs(drawStart.X - drawEnd.X),
            Math.Abs(drawStart.Y - drawEnd.Y));

        public Point drawStart;
        public Point drawEnd;

        public DrawInformation(Point drawStart, Point drawEnd)
        {
            this.drawStart = drawStart;
            this.drawEnd = drawEnd;
        }
    }
}
