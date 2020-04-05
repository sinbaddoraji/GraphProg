using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProg
{
    public abstract class Polygon : Shape
    {
        protected Polygon(Graphics g, Pen pen) : base(g, pen) { shapeType = "Polygon"; }

        protected void DrawPolygon(int numberOfSides,bool highlight = false, float angle = -1)
        {
            float shapeAngle; //180 * (N - 2)
            if (angle == -1) shapeAngle = (180f * (numberOfSides - 2)) / numberOfSides;
            else shapeAngle = angle;

            if (shapeAngle > 100) shapeAngle = 180f - shapeAngle;

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
            if (fill) g.FillPolygon(fillBrush, points);
        }

    }

    public class VariableSidedPolygon : Polygon
    {
        private int sides;
        public int Sides => sides;

        public VariableSidedPolygon(Graphics g, Pen p, int sides) : base(g, p)
        {
            this.sides = sides;
        }

        public VariableSidedPolygon(int sides) : this(null, null, sides) { }

        public void InitalizeDrawSettings(Graphics g, Pen p)
        {
            SetGraphics(g);
            SetPen(p);
        }

        public void SetSides(int num)
        {
            sides = num;
        }

        public override void Draw(bool highlight )
        {
            DrawPolygon(sides, highlight);
        }
    }


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
            DrawLinesThrough(pen, points);
            if (fill) g.FillPolygon(fillBrush, points);
        }
    }



}
