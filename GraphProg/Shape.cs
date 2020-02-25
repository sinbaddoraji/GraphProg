using System;
using System.Drawing;

namespace GraphProg
{
    public abstract class Shape
    {
        //Change to private later
        private DrawInformation drawInformation; // made public to allow redrawing

        protected Rectangle Rect => drawInformation.Rect;

        protected Point DrawStart => drawInformation.drawStart;

        protected Point DrawEnd => drawInformation.drawEnd;

        protected int Xstart => drawInformation.Rect.X; //starting X cordinate of rectangle stored in the drawinformation object

        protected int Ystart => drawInformation.Rect.Y; //starting Y cordinate of rectangle stored in the drawinformation object

        protected int Xend => drawInformation.Rect.X + drawInformation.Rect.Width; //Ending X cordinate of rectangle stored in the drawinformation object

        protected int Yend => drawInformation.Rect.Y + drawInformation.Rect.Height; //Ending Y cordinate of rectangle stored in the drawinformation object

        protected Graphics g;

        protected Pen pen;

        protected Shape(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;
        }

        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }

        protected void DrawLinesThrough(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Point currentPoint = points[i];
                Point nextPoint = i == points.Length - 1 ? points[0] : points[i + 1];

                int x1 = currentPoint.X, x2 = nextPoint.X;
                int y1 = currentPoint.Y, y2 = nextPoint.Y;

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public abstract void Draw();

        public void GetDrawLocationInformation(DrawInformation drwInfo)
        {
            drawInformation = drwInfo;
        }
    }

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
            int radius = Math.Min(Math.Abs(DrawEnd.X - DrawStart.X) / 2, Math.Abs(DrawEnd.Y - DrawStart.Y) / 2);

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

    

    public class Square : Shape
    {
        public Square(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            //Upper left corner of square
            Point a = new Point(Xstart, Ystart);
            //Lower left corner of square
            Point b = new Point(Xend, Ystart);
            //Lower right corner of square
            Point c = new Point(Xend, Yend);
            //Upper right corner of square
            Point d = new Point(Xstart, Yend);

            DrawLinesThrough(new[] { a, b, c, d });
        }
    }

    public class Circle : Polygon
    {
        public Circle(Graphics g, Pen p) : base(g, p) { }

        //Draw circle using bresenham circle algorithm
        public override void Draw()
        {
            DrawPolygon(360);
        }
    }

    public class RightAngledTriangle : Shape
    {
        public RightAngledTriangle(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            Point[] points = new Point[3] { new Point(DrawStart.X, DrawEnd.Y), DrawStart, DrawEnd };

            DrawLinesThrough(points);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(Graphics g, Pen p) : base(g, p) { }


        public override void Draw()
        {
            Point[] points = new Point[3];
            points[1] = DrawEnd; // lower right end of triangle
            points[2] = new Point(DrawStart.X, DrawEnd.Y);// lower left end of triangle
            points[0] = new Point((points[1].X + points[2].X) / 2, DrawStart.Y); //Mid point of triangle
            DrawLinesThrough(points);
        }

    }

    public class Diamond : Shape
    {
        public Diamond(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            Point[] points = new Point[4];
            //Upper point of diamond
            points[0] = new Point((DrawStart.X + DrawEnd.X) / 2, DrawStart.Y);
            //Left point of diamond
            points[1] = new Point(DrawStart.X, (DrawStart.Y + DrawEnd.Y) / 2);
            //Lower point of diamond
            points[2] = new Point((DrawStart.X + DrawEnd.X) / 2, DrawEnd.Y);
            //Right point of diamond
            points[3] = new Point(DrawEnd.X, (DrawStart.Y + DrawEnd.Y) / 2);

            DrawLinesThrough(points);
        }

    }

    public class Pentagon : Shape
    {
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
            DrawPolygon(4,60);
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
