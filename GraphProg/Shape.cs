using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProg
{

    public abstract class Shape
    {
        //Change to private later
        private DrawInformation drawInformation; // made public to allow redrawing

        public Rectangle Rect => drawInformation.rect;

        public Point DrawStart => drawInformation.drawStart;

        public Point DrawEnd => drawInformation.drawEnd;

        public int Xstart => drawInformation.rect.X; //starting X cordinate of rectangle stored in the drawinformation object

        public int Ystart => drawInformation.rect.Y; //starting Y cordinate of rectangle stored in the drawinformation object

        public int Xend => drawInformation.rect.X + drawInformation.rect.Width; //Ending X cordinate of rectangle stored in the drawinformation object

        public int Yend => drawInformation.rect.Y + drawInformation.rect.Height; //Ending Y cordinate of rectangle stored in the drawinformation object

        public Shape()   // constructor
        {
        }

        public static void DrawLinesThrough(Graphics g, Pen pen, Point[] points)
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

        public abstract void Draw(Graphics g, Pen pen);

        public void GetDrawLocationInformation(DrawInformation drwInfo) => this.drawInformation = drwInfo;
    }

    public class Square : Shape
    {
        public Square()
        {

        }

        public override void Draw(Graphics g, Pen pen)
        {
            //Upper left corner of square
            Point a = new Point(Xstart, Ystart);
            //Lower left corner of square
            Point b = new Point(Xend, Ystart);
            //Lower right corner of square
            Point c = new Point(Xend, Yend);
            //Upper right corner of square
            Point d = new Point(Xstart, Yend);

            DrawLinesThrough(g, pen, new[] { a, b, c, d });
        }

    }

    public class Circle : Shape
    {
        public Circle()
        {

        }
        public override void Draw(Graphics g, Pen pen)
        {
            //Draw circle using bresenham circle algorithm
            CircleBres(g, Rect, pen);
        }


        // Method fills in one pixel only
        void PutPixel(Graphics g, Point pixel, Pen pen)
        {
            // FillRectangle call fills at location x y and is 1 pixel high by 1 pixel wide
            g.FillRectangle(pen.Brush, pixel.X, pixel.Y, pen.Width, pen.Width);
            
        }

        void DrawCircle(Graphics g, Pen b, int xc, int yc, int x, int y)
        {
            PutPixel(g, new Point(xc + x, yc + y), b);
            PutPixel(g, new Point(xc - x, yc + y), b);
            PutPixel(g, new Point(xc + x, yc - y), b);
            PutPixel(g, new Point(xc - x, yc - y), b);
            PutPixel(g, new Point(xc + y, yc + x), b);
            PutPixel(g, new Point(xc - y, yc + x), b);
            PutPixel(g, new Point(xc + y, yc - x), b);
            PutPixel(g, new Point(xc - y, yc - x), b);
        }

        void CircleBres(Graphics g, Rectangle rect, Pen brush)
        {
            int radius = Math.Max(rect.Width / 2, rect.Height / 2);

            int centreX = rect.X + (rect.Width / 2);
            int centreY = rect.Y + (rect.Height / 2);

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;  // initial value

            DrawCircle(g, brush, centreX, centreY, x, y);
            while (y >= x)
            {
                // for each pixel we will 
                // draw all eight pixels 

                x++;

                // check for decision parameter 
                // and correspondingly  
                // update d, x, y 
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                    d = d + 4 * x + 6;
                DrawCircle(g, brush, centreX, centreY, x, y);
            }
        }


    }

    public class Triangle : Shape
    {
        private readonly bool rightAngled;

        public Triangle(bool isRightAngled = false) => rightAngled = isRightAngled;

        public override void Draw(Graphics g, Pen pen)
        {
            if(rightAngled)
            {
                //Points to create right angled triangle
                var points = new Point[3] { new Point(DrawStart.X, DrawEnd.Y), DrawStart, DrawEnd };

                DrawLinesThrough(g, pen, points);
            }
            else
            {
                //Points for triangle
                var points = new Point[3];
                points[1] = DrawEnd; // lower right end of triangle
                points[2] = new Point(DrawStart.X, DrawEnd.Y);// lower left end of triangle
                points[0] = new Point((points[1].X + points[2].X) / 2, DrawStart.Y); //Mid point of triangle
                DrawLinesThrough(g, pen, points);
            }
        }

    }

    public class Diamond : Shape
    {
        public Diamond()
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            var points = new Point[4];
            //Upper point of diamond
            points[0] = new Point((DrawStart.X + DrawEnd.X) / 2, DrawStart.Y);
            //Left point of diamond
            points[1] = new Point(DrawStart.X, (DrawStart.Y + DrawEnd.Y) / 2);
            //Lower point of diamond
            points[2] = new Point((DrawStart.X + DrawEnd.X) / 2, DrawEnd.Y);
            //Right point of diamond
            points[3] = new Point(DrawEnd.X, (DrawStart.Y + DrawEnd.Y) / 2);

            DrawLinesThrough(g, pen, points);
        }

    }


    public class Pentagon: Shape
    {
        public Pentagon()
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            int diameter = Math.Abs(DrawEnd.X - DrawStart.X);

            // Gap between X boundaries of rectangle being drawn in and the start/end of the lower line of a pentagon
            int tint = Convert.ToInt32(0.256 * diameter);

            if (DrawStart.X > DrawEnd.X) tint *= -1;

            var points = new Point[5];

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

            DrawLinesThrough(g, pen, points);
        }

    }
    //Note stars can be drawn from pentagons

    public class Heptagon : Shape
    {
        public Heptagon()
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            //Get the middle of the panel
            //var x_0 = Xend / 2;
            //var y_0 = Yend / 2;

            //var x_0 = Xend / 2;
            //var y_0 = Yend / 2;

            //CHange icon of this in the image list

            var x_0 = (DrawStart.X + DrawEnd.X) / 2;
            var y_0 = (DrawStart.Y + DrawEnd.Y) / 2;

            
            var r = Math.Max(Math.Abs(DrawEnd.X - DrawStart.X) / 2, Math.Abs(DrawEnd.Y - DrawStart.Y) / 2); //70 px radius 
            
            var points = new PointF[6];


            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                points[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }


            //g.DrawRectangle(pen, Rect);
            g.DrawPolygon(pen, points);
        }

    }

}
