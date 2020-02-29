using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProg
{
    public abstract class Polygon : Shape
    {
        protected Polygon(Graphics g, Pen pen) : base(g, pen) { }

        protected void DrawPolygon(int numberOfSides, float angle = -1)
        {
            float shapeAngle; //180 * (N - 2)
            if (angle == -1) shapeAngle = (180f * (numberOfSides - 2)) / numberOfSides;
            else shapeAngle = angle;

            if (shapeAngle > 100) shapeAngle = 180f - shapeAngle;

            //Convert angle to radians
            shapeAngle = (shapeAngle * (float)Math.PI) / 180f;

            //Change icon of this in the image list

            int x_0 = (DrawStart.X + DrawEnd.X) / 2; //Starting x value
            int y_0 = (DrawStart.Y + DrawEnd.Y) / 2; //Starting y value

            //Half the diameter of the rectangle the shape is being drawn in
            int radius = Math.Max(Math.Abs(DrawEnd.X - DrawStart.X) / 2, Math.Abs(DrawEnd.Y - DrawStart.Y) / 2);

            PointF[] points = new PointF[numberOfSides]; //Point list

            for (int a = 0; a < numberOfSides; a++)
            {
                points[a] = new PointF(
                    x_0 + radius * (float)Math.Cos(a * shapeAngle),
                    y_0 + radius * (float)Math.Sin(a * shapeAngle));
            }

            g.DrawPolygon(pen, points);
        }
    }


    public class Pentagon : Shape
    {
        //Constructed manually because the trying to draw it with drawpolygon produces a poor shape
        public Pentagon(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            int diameter = Math.Abs(DrawEnd.X - DrawStart.X);

            // Gap between X boundaries of rectangle being drawn in and the start/end of the lower line of a pentagon
            int tint = Convert.ToInt32(0.256 * diameter);

            if (DrawStart.X > DrawEnd.X)
            {
                tint *= -1;
            }

            Point[] points = new Point[5];

            //Middle of horizontal line in the upper rectangle
            points[0] = new Point((DrawStart.X + DrawEnd.X) / 2, DrawStart.Y);
            //Middle of the left vertical line in therectangle
            points[1] = new Point(DrawStart.X, (DrawStart.Y + DrawEnd.Y) / 2);
            //Begining of line at the bottom of the pentagon
            points[2] = new Point(tint + DrawStart.X, DrawEnd.Y);
            //End of line at the bottom
            points[3] = new Point(DrawEnd.X - tint, DrawEnd.Y);
            //Middle of the right vertical line in the rectangle
            points[4] = new Point(DrawEnd.X, (DrawStart.Y + DrawEnd.Y) / 2);

            DrawLinesThrough(points);
        }

    }

    public class VariableSidedPolygon : Polygon
    {
        int sides;

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

        public void SetSideNum(int num)
        {
            sides = num;
        }

        public override void Draw()
        {
            DrawPolygon(sides);
        }
    }


    public class Trapizoid : Polygon
    {
        public Trapizoid(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            int diameter = Math.Abs(DrawEnd.X - DrawStart.X);

            // Gap between X boundaries of rectangle being drawn in and the start/end of the lower line of a pentagon
            int tint = Convert.ToInt32(0.256 * diameter);

            //Upper left corner of square
            Point a = new Point(Xstart, Ystart);
            //Lower left corner of square
            Point b = new Point(Xend, Ystart);
            //Lower right corner of square
            Point c = new Point(Xend, Yend);
            //Upper right corner of square
            Point d = new Point(Xstart, Yend);

            if(DrawEnd.X < DrawStart.X)
            {
                c.X -= tint;
                d.X += tint;
            }
            else
            {
                a.X += tint;
                b.X -= tint;
            }
            DrawLinesThrough(new[] { a, b, c, d });

            //DrawPolygon(4, 60);
        }
    }



}
