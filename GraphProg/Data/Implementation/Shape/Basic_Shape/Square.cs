using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Basic_Shape
{
    public class Square : Shape
    {
        public Square(Graphics g, Pen p) : base(g, p) { shapeType = "Square"; }


        public override void Draw(bool highlight)
        { 
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
            
            Pen pen = highlight ? highLightPen : this.pen;


            DrawLinesThrough(pen, points);
            if (fill)
            {
                g.FillPolygon(fillBrush, points);
            }
        }

    }
}
