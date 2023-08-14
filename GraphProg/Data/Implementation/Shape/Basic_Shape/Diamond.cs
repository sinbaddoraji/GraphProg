using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Basic_Shape
{
    public class Diamond : Shape
    {
        public Diamond(Graphics g, Pen p) : base(g, p) { shapeType = "Diamond"; }

        public override void Draw(bool highlight)
        {
            PointF[] points = new PointF[4];
            //Upper point of diamond
            points[0] = new PointF((DrawStart.X + DrawEnd.X) / 2, DrawStart.Y);
            //Left point of diamond
            points[1] = new PointF(DrawStart.X, (DrawStart.Y + DrawEnd.Y) / 2);
            //Lower point of diamond
            points[2] = new PointF((DrawStart.X + DrawEnd.X) / 2, DrawEnd.Y);
            //Right point of diamond
            points[3] = new PointF(DrawEnd.X, (DrawStart.Y + DrawEnd.Y) / 2);

            Matrix m = new Matrix();
            m.RotateAt(RotateAmount, DrawInformation.Center, MatrixOrder.Prepend);
            m.TransformPoints(points);

            Pen pen = highlight ? highLightPen : this.pen;

            DrawLinesThrough(pen, points);
            if(fill)
            {
                g.FillPolygon(fillBrush, points);
            }
        }

    }
}