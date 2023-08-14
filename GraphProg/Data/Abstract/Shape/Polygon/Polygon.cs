using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Polygon
{
    public abstract class Polygon : Shape
    {
        protected Polygon(Graphics g, Pen pen) : base(g, pen) { shapeType = "Polygon"; }

        protected void DrawPolygon(int numberOfSides, bool highlight = false, float angle = -1)
        {
            float shapeAngle; //180 * (N - 2)
            if (angle == -1)
            {
                shapeAngle = (180f * (numberOfSides - 2)) / numberOfSides;
            }
            else
            {
                shapeAngle = angle;
            }

            if (shapeAngle > 100)
            {
                shapeAngle = 180f - shapeAngle;
            }

            //Convert angle to radians
            shapeAngle = (shapeAngle * (float)Math.PI) / 180f;

            //Change icon of this in the image list

            float x_0 = (DrawStart.X + DrawEnd.X) / 2; //Starting x value
            float y_0 = (DrawStart.Y + DrawEnd.Y) / 2; //Starting y value

            //Half the diameter of the rectangle the shape is being drawn in
            float radius = Math.Max(Math.Abs(DrawEnd.X - DrawStart.X) / 2, Math.Abs(DrawEnd.Y - DrawStart.Y) / 2);

            PointF[] points = new PointF[numberOfSides]; //Point list

            for (int a = 0; a < numberOfSides; a++)
            {
                points[a] = new PointF(
                    x_0 + radius * (float)Math.Cos(a * shapeAngle),
                    y_0 + radius * (float)Math.Sin(a * shapeAngle));
            }

            Matrix m = new Matrix();
            m.RotateAt(RotateAmount, DrawInformation.Center, MatrixOrder.Prepend);
            m.TransformPoints(points);

            Pen pen = highlight ? highLightPen : this.pen;
            DrawLinesThrough(pen, points);
        }
    }
}
