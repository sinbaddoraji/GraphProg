﻿using System;
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
            //180 * (N - 2)
            float shapeAngle;
            if (angle == -1) shapeAngle = (180f * (numberOfSides - 2)) / numberOfSides;
            else shapeAngle = angle;

            if (shapeAngle > 100) shapeAngle = 180f - shapeAngle;

            //Convert angle to radians
            shapeAngle = (shapeAngle * (float)Math.PI) / 180f;

            //Change icon of this in the image list

            //int x_0 = (DrawStart.X + DrawEnd.X) / 2; //Starting x value
            // int y_0 = (DrawStart.Y + DrawEnd.Y) / 2; //Starting y value
            int x_0 = (DrawStart.X + DrawEnd.X) / 2; //Starting x value
            int y_0 = (DrawStart.Y + DrawEnd.Y) / 2; //Starting y value

            //Half the diameter of the rectangle the shape is being drawn in
            int radius = Math.Max(Math.Abs(DrawEnd.X - DrawStart.X) / 2, Math.Abs(DrawEnd.Y - DrawStart.Y) / 2);

            PointF[] points = new PointF[numberOfSides]; //Point list

            //50
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

    public class Hexagon : Polygon
    {
        public Hexagon(Graphics g, Pen p) : base(g, p) { }

        //Change icon of this in the image list
        public override void Draw()
        {
            DrawPolygon(6);
        }
    }

    public class Trapizoid : Polygon
    {
        public Trapizoid(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            DrawPolygon(4, 60);
        }
    }

    public class Heptagon : Polygon
    {
        public Heptagon(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            DrawPolygon(7);
        }
    }

    public class Octagon : Polygon
    {
        public Octagon(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            DrawPolygon(8);
        }
    }

}
