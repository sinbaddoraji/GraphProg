﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg
{
    class Canvas : PictureBox
    {
        public enum ShapeType { None, Square, Circle, Triangle, RightAngTriangle, Trapezoid, Diamond, Pentagon, Hexagon, Heptagon, Octagon };
        private ShapeType selectedShape;

        public bool IsDrawing { get; set; } = false;
        public Image canvasImage;

        private Size oldSize;

        private Graphics imageGraphics;
        private Graphics outerGraphics;

        private Point mousePosition;
        private Point drawStart;
        private Point drawEnd;

        private Pen blackPen;
        private Pen redPen; //Pen used to highlight shapes when selected

        private List<Shape> shapeList = new List<Shape>();
        public float lineSize = 3f;

        private Color imageBackground = Color.White;

        bool drawBackwards => drawEnd.X < drawStart.X && drawEnd.Y > drawStart.Y; //Draw shapes like triangles upside

        public Canvas()
        {

            //Set size of canvas
            Size = oldSize = new Size(100, 100);

            selectedShape = ShapeType.None;

            //Initalize event handlers
            MouseMove += Canvas_MouseMove;
            MouseDown += Canvas_MouseDown;
            MouseUp += Canvas_MouseUp;

            SizeChanged += Canvas_SizeChanged;

            Paint += Canvas_Paint;
            //canvasImage = System

            blackPen = new Pen(new SolidBrush(Color.Black), lineSize);
            redPen = new Pen(new SolidBrush(Color.Red), lineSize);

            //Round out line edges for better quality of shapes
            blackPen.StartCap = blackPen.EndCap = LineCap.Round;
            redPen.StartCap = redPen.EndCap = LineCap.Round;

            outerGraphics = this.CreateGraphics();

            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (!IsDrawing) return;

            DrawShape(e.Graphics, blackPen, new DrawInformation(drawStart, drawEnd));
        }

        public void SelectShape(ShapeType shape)
        {
            selectedShape = shape;
        }


        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            Image img = new Bitmap(Width, Height);
            imageGraphics = Graphics.FromImage(img);

            if (Image == null)
            {
                imageGraphics.Clear(imageBackground);
                Image = img;
            }
            else
            {
                Rectangle destinationRect = new Rectangle(0, 0, img.Width, img.Height);
                imageGraphics.DrawImage(Image, destinationRect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel);

                Image.Dispose();
                Image = img;
            }

        }

        private void DrawShape(Graphics g, Pen pen, DrawInformation drwInfo)
        {
            Shape currentShape = null;
            
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (selectedShape == ShapeType.None) return;

            if (selectedShape == ShapeType.Circle) currentShape = new Circle(g, pen);

            if (selectedShape == ShapeType.Triangle) currentShape = new Triangle(g, pen);

            if (selectedShape == ShapeType.RightAngTriangle) currentShape = new RightAngledTriangle(g, pen);

            if (selectedShape == ShapeType.Trapezoid) currentShape = new Trapizoid(g, pen);

            if (selectedShape == ShapeType.Square) currentShape = new Square(g, pen);

            if (selectedShape == ShapeType.Diamond) currentShape = new Diamond(g, pen);

            if (selectedShape == ShapeType.Pentagon) currentShape = new Pentagon(g, pen);

            if (selectedShape == ShapeType.Hexagon) currentShape = new Hexagon(g, pen);

            if (selectedShape == ShapeType.Heptagon) currentShape = new Heptagon(g, pen);

            if (selectedShape == ShapeType.Octagon) currentShape = new Octagon(g, pen);

            currentShape.GetDrawLocationInformation(drwInfo);
            currentShape.Draw();

            if (g == imageGraphics)
            {
                //If drawing to image
                shapeList.Add(currentShape);
            }
        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;

            if (IsDrawing)
            {
                drawEnd = mousePosition;
                Invalidate();
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            IsDrawing = true;
            drawStart = mousePosition;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if(IsDrawing)
            {
                IsDrawing = false;
                drawEnd = mousePosition;

                imageGraphics = Graphics.FromImage(Image);
                DrawShape(imageGraphics, blackPen, new DrawInformation(drawStart,drawEnd));
            }

            

            //Keep track of all shapes
        }

        
        
    }
}
