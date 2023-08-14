using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Basic_Shape
{
    public class Triangle : Shape
    {
        public Triangle(Graphics g, Pen p) : base(g, p) { shapeType = "Triangle"; }


        public override void Draw(bool highlight)
        {
            PointF[] points = new PointF[3];
            points[1] = DrawEnd; // lower right end of triangle
            points[2] = new PointF(DrawStart.X, DrawEnd.Y);// lower left end of triangle
            points[0] = new PointF((points[1].X + points[2].X) / 2, DrawStart.Y); //Mid point of triangle


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