using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg
{
    public abstract class Shape
    {
        //Change to private later
        private DrawInformation drawInformation;

        public DrawInformation DrawInformation => drawInformation;

        //Object that holds the bounds (drawing location and size) that the shape will be drawn in
        public RectangleF Rect => drawInformation.Rect;

        //First mouse location in drag operation used to draw shape
        protected PointF DrawStart => drawInformation.drawStart;

        //Last mouse location in drag operation used to draw shape
        protected PointF DrawEnd => drawInformation.drawEnd;

        //starting X cordinate of rectangle stored in the drawinformation object
        protected float Xstart => drawInformation.Rect.X; 

        //starting Y cordinate of rectangle stored in the drawinformation object
        protected float Ystart => drawInformation.Rect.Y; 

        //Ending X cordinate of rectangle stored in the drawinformation object
        protected float Xend => drawInformation.Rect.X + drawInformation.Rect.Width; 

        //Ending Y cordinate of rectangle stored in the drawinformation object
        protected float Yend => drawInformation.Rect.Y + drawInformation.Rect.Height; 

        //Base for all graphics
        protected Graphics g;

        public Graphics Graphics => g;

        //(Object that holds the colour and thickness of shapes)
        protected Pen pen;

        public Pen Pen => pen;

        //All shapes have the same highlighting pen to avoid unnessary complexity
        protected Pen highLightPen;

        public Color HighlightColor => highLightPen.Color;

        protected bool fill;
        public bool DoFill => fill;

        protected Brush fillBrush;

        public string shapeType;

        public float PenThickness => pen.Width;
        public Color PenColour => pen.Color;

        public Color FillColour => ((SolidBrush)fillBrush).Color;

        public int RotateAmount { get; set; }

        protected Shape(Graphics g, Pen pen)
        {
            SetGraphics(g);
            SetPen(pen);

            if(highLightPen == null)
            {
                highLightPen = new Pen(Brushes.Red, pen.Width)
                {
                    StartCap = pen.StartCap,
                    EndCap = pen.EndCap
                };
            }
            

            fillBrush = pen.Brush;
        }


        public void SetWidth(int width)
        {
            if(DrawEnd.X > DrawStart.X)
            {
                drawInformation.drawEnd.X = DrawStart.X + width;
            }
            if(DrawEnd.X < DrawStart.X)
            {
                drawInformation.drawStart.X = DrawEnd.X + width;
            }
        }

        public void SetHeight(int height)
        {
            if (DrawEnd.Y > DrawStart.Y)
            {
                drawInformation.drawEnd.Y = DrawStart.Y + height;
            }
            if (DrawEnd.Y < DrawStart.Y)
            {
                drawInformation.drawStart.Y = DrawEnd.Y + height;
            }
        }

        public void Fill()
        {
            if (this.fill) 
                this.fill = false; 
            else 
                this.fill = true;
        }

        public void SetFillBrush(Brush brush)
        {
            //Set brush that will be used for filling
            fillBrush = brush;
        }

        public void SetPen(Pen pen)
        {
            //Set pen object (Object that holds the colour and thickness of shapes)
            this.pen = pen;
        }
        public void SetHighlightColour(Color color)
        {
            //Set Pen Color
            highLightPen.Color = color;
        }

        public void SetPenColour(Color color)
        {
            //Set Pen Color
            this.pen.Color = color;
        }

        public void SetPenThickness(float width)
        {
            //Set Pen thickness
            this.pen = new Pen(this.pen.Brush, width)
            {
                StartCap = this.pen.StartCap,
                EndCap = this.pen.EndCap
            };

            highLightPen = new Pen(highLightPen.Brush, width)
            {
                StartCap = this.pen.StartCap,
                EndCap = this.pen.EndCap
            };
        }

        public void SetGraphics(Graphics g)
        {
            //Set graphic base that the current shape will be drawn on
            this.g = g;

            if (g != null)
            {
                //Make sure graphics are not unstable or unrefined
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            }
        }

        protected void DrawLinesThrough(Pen pen, PointF[] points)
        {
            //Draw lines through array of points
            for (int i = 0; i < points.Length; i++)
            {
                //Point line being drawn will start from
                PointF currentPoint = points[i];

                //Point line will be drawn to
                PointF nextPoint = i == points.Length - 1 ? points[0] : points[i + 1];

                //X values of current point and next point
                float x1 = currentPoint.X, x2 = nextPoint.X;

                //Y values of current point and next point
                float y1 = currentPoint.Y, y2 = nextPoint.Y;

                /*
                    Draw line from current point to the next point

                    g.DrawLine used because other custom/alternative algorithms will call 
                    on g.FillEllipse ir g.FillRectangle and produce unstable lines
                 */
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public abstract void Draw(bool highlight); // Draw shape onto drawing canvas

        public void SetDrawLocationInformation(DrawInformation drwInfo)
        {
            //Set draw location
            drawInformation = drwInfo;
        }

        public DrawInformation GetDrawLocationInformation()
        {
            //Return drawInformation (Object that holds information about shape size and shape location)
            return drawInformation;
        }

        public void MoveLeft(float amount)
        {
            //Move shape to the left
            drawInformation.drawStart.X -= amount;
            drawInformation.drawEnd.X -= amount;
        }

        public void MoveRight(float amount)
        {
            //Move shape to the Right
            drawInformation.drawStart.X += amount;
            drawInformation.drawEnd.X += amount;
        }

        public void MoveUp(float amount)
        {
            //Move shape upwards
            drawInformation.drawStart.Y -= amount;
            drawInformation.drawEnd.Y -= amount;
        }

        public void MoveDown(float amount)
        {
            //Move shape downwards
            drawInformation.drawStart.Y += amount;
            drawInformation.drawEnd.Y += amount;
        }

        public void Move(Canvas.MoveDirection direction,float amount)
        {
            if(direction == Canvas.MoveDirection.Up)
            {
                MoveUp(amount);
            }
            else if (direction == Canvas.MoveDirection.Down)
            {
                MoveDown(amount);
            }
            else if (direction == Canvas.MoveDirection.Left)
            {
                MoveLeft(amount);
            }
            else if (direction == Canvas.MoveDirection.Right)
            {
                MoveRight(amount);
            }
        }

    }
}
