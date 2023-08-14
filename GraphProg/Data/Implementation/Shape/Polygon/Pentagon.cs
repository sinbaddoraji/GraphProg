using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Polygon
{
    public class Pentagon : Shape
    {
        //Constructed manually because the trying to draw it with drawpolygon produces a poor shape
        public Pentagon(Graphics g, Pen p) : base(g, p) { shapeType = "Pentagon"; }

        public override void Draw(bool highlight)
        {
            float diameter = Math.Abs(DrawEnd.X - DrawStart.X);

            // Gap between X boundaries of rectangle being drawn in and the start/end of the lower line of a pentagon
            int tint = Convert.ToInt32(0.256 * diameter);

            if (DrawStart.X > DrawEnd.X)
            {
                tint *= -1;
            }

            PointF[] points = new PointF[5];

            //Middle of horizontal line in the upper rectangle
            points[0] = new PointF((DrawStart.X + DrawEnd.X) / 2, DrawStart.Y);
            //Middle of the left vertical line in therectangle
            points[1] = new PointF(DrawStart.X, (DrawStart.Y + DrawEnd.Y) / 2);
            //Begining of line at the bottom of the pentagon
            points[2] = new PointF(tint + DrawStart.X, DrawEnd.Y);
            //End of line at the bottom
            points[3] = new PointF(DrawEnd.X - tint, DrawEnd.Y);
            //Middle of the right vertical line in the rectangle
            points[4] = new PointF(DrawEnd.X, (DrawStart.Y + DrawEnd.Y) / 2);

            Matrix m = new Matrix();
            m.RotateAt(RotateAmount, DrawInformation.Center, MatrixOrder.Prepend);
            m.TransformPoints(points);

            Pen pen = highlight ? highLightPen : this.pen;

            DrawLinesThrough(pen, points);
            if (fill)
            {
                g.FillPolygon(fillBrush, points);
            }
        }

    }
}