using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Polygon
{
    public class Trapezoid : Polygon
    {
        public Trapezoid(Graphics g, Pen p) : base(g, p) { }

        public override void Draw(bool highlight)
        {
            float diameter = Math.Abs(DrawEnd.X - DrawStart.X);

            // Gap between X boundaries of rectangle being drawn in and the start/end of the lower line of a pentagon
            float tint = Convert.ToInt32(0.256 * diameter);

            PointF[] points = new PointF[4];

            //Upper left corner of square
            points[0] = new PointF(Xstart, Ystart);
            //Lower left corner of square
            points[1] = new PointF(Xend, Ystart);
            //Lower right corner of square
            points[2] = new PointF(Xend, Yend);
            //Upper right corner of square
            points[3] = new PointF(Xstart, Yend);

            Matrix m = new Matrix();
            m.RotateAt(RotateAmount, DrawInformation.Center, MatrixOrder.Prepend);
            m.TransformPoints(points);

            if (DrawEnd.X < DrawStart.X)
            {
                points[2].X -= tint;
                points[3].X += tint;
            }
            else
            {
                points[0].X += tint;
                points[1].X -= tint;
            }


            Pen pen = highlight ? highLightPen : this.pen;

            DrawLinesThrough(pen, points); // Draw lines through point list

            if (fill)
            {
                g.FillPolygon(fillBrush, points); //If fill then fill polygon
            }
        }
    }
}