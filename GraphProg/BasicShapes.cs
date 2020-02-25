using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProg
{
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

}
