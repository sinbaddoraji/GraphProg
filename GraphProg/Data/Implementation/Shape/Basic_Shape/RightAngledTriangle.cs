using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Basic_Shape
{
    public class RightAngledTriangle : Shape
    {
        public RightAngledTriangle(Graphics g, Pen p) : base(g, p) { shapeType = "RightAngledTriangle"; }

        public override void Draw(bool highlight)
        {
            PointF[] points = new PointF[3]
            {
                new PointF(DrawStart.X, DrawEnd.Y),  //Lower left corner of the  right-angled triangle
                DrawStart, //Top left corner of the right-angled triangle
                DrawEnd //Lower Right corner of the right-angled triangle
            };

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