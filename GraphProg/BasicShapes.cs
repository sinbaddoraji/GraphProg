using System.Drawing;

namespace GraphProg
{
    public class Square : Shape
    {
        public Square(Graphics g, Pen p) : base(g, p) { }

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
            
            Pen pen = highlight ? highLightPen : this.pen;

            DrawLinesThrough(pen, points);
            if (fill) g.FillPolygon(fillBrush, points);
        }

    }

    public class Circle : Shape
    {
        public Circle(Graphics g, Pen p) : base(g, p) { }

        public override void Draw(bool highlight)
        {
            Pen pen = highlight ? highLightPen : this.pen;
            // c# lib used because bresenham circle and alternatives create unstable curcles
            g.DrawEllipse(pen, Rect);
            if (fill) g.FillEllipse(fillBrush, Rect);
        }
    }

    public class RightAngledTriangle : Shape
    {
        public RightAngledTriangle(Graphics g, Pen p) : base(g, p) { }

        public override void Draw(bool highlight)
        {
            PointF[] points = new PointF[3]
            {
                new PointF(DrawStart.X, DrawEnd.Y),  //Lower left corner of the  right-angled triangle
                DrawStart, //Top left corner of the right-angled triangle
                DrawEnd //Lower Right corner of the right-angled triangle
            };

            Pen pen = highlight ? highLightPen : this.pen;
            DrawLinesThrough(pen, points);
            if (fill) g.FillPolygon(fillBrush, points);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(Graphics g, Pen p) : base(g, p) { }


        public override void Draw(bool highlight)
        {
            PointF[] points = new PointF[3];
            points[1] = DrawEnd; // lower right end of triangle
            points[2] = new PointF(DrawStart.X, DrawEnd.Y);// lower left end of triangle
            points[0] = new PointF((points[1].X + points[2].X) / 2, DrawStart.Y); //Mid point of triangle

            Pen pen = highlight ? highLightPen : this.pen;
            DrawLinesThrough(pen, points);
            if (fill) g.FillPolygon(fillBrush, points);
        }

    }

    public class Diamond : Shape
    {
        public Diamond(Graphics g, Pen p) : base(g, p) { }

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

            Pen pen = highlight ? highLightPen : this.pen;

            DrawLinesThrough(pen, points);
            if(fill)g.FillPolygon(fillBrush, points);
        }

    }

}
