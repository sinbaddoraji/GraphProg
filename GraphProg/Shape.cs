using System;
using System.Drawing;

namespace GraphProg
{
    public abstract class Shape
    {
        //Change to private later
        private DrawInformation drawInformation; // made public to allow redrawing

        public RectangleF Rect => drawInformation.Rect;

        protected PointF DrawStart => drawInformation.drawStart;

        protected PointF DrawEnd => drawInformation.drawEnd;

        protected float Xstart => drawInformation.Rect.X; //starting X cordinate of rectangle stored in the drawinformation object

        protected float Ystart => drawInformation.Rect.Y; //starting Y cordinate of rectangle stored in the drawinformation object

        protected float Xend => drawInformation.Rect.X + drawInformation.Rect.Width; //Ending X cordinate of rectangle stored in the drawinformation object

        protected float Yend => drawInformation.Rect.Y + drawInformation.Rect.Height; //Ending Y cordinate of rectangle stored in the drawinformation object

        protected Graphics g;

        protected Pen pen;

        protected static int index = 0;
        public int shapeIndex;

        protected Shape(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;

            if(g != null)
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            }
            shapeIndex = index++;
        }

        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }

        public void SetGraphics(Graphics g)
        {
            this.g = g;
            if (g != null)
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            }
        }

        protected void DrawLinesThrough(PointF[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                PointF currentPoint = points[i];
                PointF nextPoint = i == points.Length - 1 ? points[0] : points[i + 1];

                float x1 = currentPoint.X, x2 = nextPoint.X;
                float y1 = currentPoint.Y, y2 = nextPoint.Y;

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public abstract void Draw();

        public void SetDrawLocationInformation(DrawInformation drwInfo)
        {
            drawInformation = drwInfo;
        }

        public DrawInformation GetDrawLocationInformation()
        {
            return drawInformation;
        }
    }
}
