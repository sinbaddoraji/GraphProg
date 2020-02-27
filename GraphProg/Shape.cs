using System;
using System.Drawing;

namespace GraphProg
{
    public abstract class Shape
    {
        //Change to private later
        private DrawInformation drawInformation; // made public to allow redrawing

        protected Rectangle Rect => drawInformation.Rect;

        protected Point DrawStart => drawInformation.drawStart;

        protected Point DrawEnd => drawInformation.drawEnd;

        protected int Xstart => drawInformation.Rect.X; //starting X cordinate of rectangle stored in the drawinformation object

        protected int Ystart => drawInformation.Rect.Y; //starting Y cordinate of rectangle stored in the drawinformation object

        protected int Xend => drawInformation.Rect.X + drawInformation.Rect.Width; //Ending X cordinate of rectangle stored in the drawinformation object

        protected int Yend => drawInformation.Rect.Y + drawInformation.Rect.Height; //Ending Y cordinate of rectangle stored in the drawinformation object

        protected Graphics g;

        protected Pen pen;

        protected Shape(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;
        }

        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }

        public void SetGraphics(Graphics g)
        {
            this.g = g;
        }

        protected void DrawLinesThrough(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Point currentPoint = points[i];
                Point nextPoint = i == points.Length - 1 ? points[0] : points[i + 1];

                int x1 = currentPoint.X, x2 = nextPoint.X;
                int y1 = currentPoint.Y, y2 = nextPoint.Y;

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public abstract void Draw();

        public void GetDrawLocationInformation(DrawInformation drwInfo)
        {
            drawInformation = drwInfo;
        }
    }
}
