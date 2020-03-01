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
            PointF a = new PointF(Xstart, Ystart);
            //Lower left corner of square
            PointF b = new PointF(Xend, Ystart);
            //Lower right corner of square
            PointF c = new PointF(Xend, Yend);
            //Upper right corner of square
            PointF d = new PointF(Xstart, Yend);

            DrawLinesThrough(new[] { a, b, c, d });
        }

    }

    public class Circle : Shape
    {
        public Circle(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            // c# lib used because bresenham circle and alternatives create unstable curcles
            g.DrawEllipse(pen, Rect); 
        }
    }

    public class RightAngledTriangle : Shape
    {
        public RightAngledTriangle(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
        {
            PointF[] points = new PointF[3] { new PointF(DrawStart.X, DrawEnd.Y), DrawStart, DrawEnd };

            DrawLinesThrough(points);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(Graphics g, Pen p) : base(g, p) { }


        public override void Draw()
        {
            PointF[] points = new PointF[3];
            points[1] = DrawEnd; // lower right end of triangle
            points[2] = new PointF(DrawStart.X, DrawEnd.Y);// lower left end of triangle
            points[0] = new PointF((points[1].X + points[2].X) / 2, DrawStart.Y); //Mid point of triangle
            DrawLinesThrough(points);
        }

    }

    public class Diamond : Shape
    {
        public Diamond(Graphics g, Pen p) : base(g, p) { }

        public override void Draw()
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

            DrawLinesThrough(points);
        }

    }

}
