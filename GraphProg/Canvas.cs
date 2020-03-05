using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg
{
    public class Canvas : PictureBox
    {
        public enum ShapeType { None, Square, Circle, Triangle, RightAngTriangle, Trapezoid, Diamond, Pentagon, Hexagon, Heptagon, Octagon, ThreePointedStar, FourPointedStar ,FivePointedStar, SixPointedStar, VariableStar, VariablePolygon };
        private ShapeType selectedShape;

        public bool IsDrawing { get; set; } = false;

        private Size oldSize;

        public Graphics imageGraphics;
        public Graphics outerGraphics;

        public Point mousePosition;
        private Point drawStart;
        private Point drawEnd;

        private Pen blackPen;
        private Pen redPen; //Pen used to highlight shapes when selected

        private List<Shape> shapeList = new List<Shape>();
        public float lineSize = 3f;

        private Color imageBackground = Color.White;

        public Shape variablePolygon;
        public Shape variableStar;

        public delegate void methodPointer(List<Shape> shapes);
        public methodPointer redrawMethodPointer;

        public List<Shape> GetShapesSurrounding(Point p)
        {
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < shapeList.Count; i++)
            {
                var shapeRectangle = shapeList[i].GetDrawLocationInformation().Rect;
                if(shapeRectangle.Contains(p))
                {
                    shapes.Add(shapeList[i]);
                }
            }
            return shapes;
        }

        public void DeleteShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                shapeList.Remove(shape);
            }

            Redraw();
            Invalidate();
        }

        public void MoveShapes(List<Shape> shapes, int direction, float amount)
        {
            //0 -> left
            //1 -> Up
            //2 -> Right
            //3 -> Down

            if(direction == 0)
            {
                foreach (Shape shape in shapes)
                {
                    if(shape.Rect.X > 0)
                    {
                        shape.MoveLeft(amount);
                    }
                }
            }

            if (direction == 2)
            {
                foreach (Shape shape in shapes)
                {
                    if (shape.Rect.Width < Width)
                    {
                        shape.MoveRight(amount);
                    }
                }
            }

            if (direction == 1)
            {
                foreach (Shape shape in shapes)
                {
                    if (shape.Rect.Y > 0)
                    {
                        shape.MoveUp(amount);
                    }
                }
            }

            if (direction == 3)
            {
                foreach (Shape shape in shapes)
                {
                    if (shape.Rect.Y < Height)
                    {
                        shape.MoveDown(amount);
                    }
                }
            }

           
            
            Redraw(shapes);
            Invalidate();
        }

        public void Redraw(List<Shape> selectedShapes = null)
        {
            imageGraphics.Clear(BackColor);
            outerGraphics.Clear(BackColor);

            foreach (Shape shape in shapeList)
            {
                if(selectedShapes != null && selectedShapes.Contains(shape))
                {
                    shape.SetPen(redPen);
                }
                else
                {
                    shape.SetPen(blackPen);
                }

                shape.Draw();
            }
            Invalidate();
        }

        TextBox internalPanel = new TextBox(); //Textbox used to intercept keydown events for canvas

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

            blackPen = new Pen(Brushes.Black, lineSize);
            redPen = new Pen(Brushes.Red, lineSize);

            //Round out line edges for better quality of shapes
            blackPen.StartCap = blackPen.EndCap = LineCap.Round;
            redPen.StartCap = redPen.EndCap = LineCap.Round;

            outerGraphics = this.CreateGraphics();

            //Set control to be double buffered
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            redrawMethodPointer = Redraw;

            this.MouseHover += Canvas_MouseHover;

            internalPanel.ReadOnly = true;
            internalPanel.Location = new Point(Width, Height);

            this.Controls.Add(internalPanel);
        }


        public void SetKeyDownEvent(KeyEventHandler keyEventHandler)
        {
            internalPanel.KeyDown += keyEventHandler;
        }

        public void SetKeyupEvent(KeyEventHandler keyEventHandler)
        {
            internalPanel.KeyUp += keyEventHandler;
        }



        private void Canvas_MouseHover(object sender, EventArgs e)
        {
            internalPanel.Focus();
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

            internalPanel.Location = new Point(Width, Height);

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

        private Shape GetCurrentShape(Graphics g, Pen pen)
        {
            switch(selectedShape)
            {
                default:
                case ShapeType.None: return null;

                case ShapeType.Circle: return new Circle(g, pen);

                case ShapeType.Triangle: return new Triangle(g, pen);

                case ShapeType.RightAngTriangle: return new RightAngledTriangle(g, pen);

                case ShapeType.Trapezoid: return new Trapezoid(g, pen);

                case ShapeType.Square: return new Square(g, pen);

                case ShapeType.Diamond: return new Diamond(g, pen);

                case ShapeType.Pentagon: return new Pentagon(g, pen);

                case ShapeType.Hexagon: return new VariableSidedPolygon(g, pen, 6);

                case ShapeType.Heptagon: return new VariableSidedPolygon(g, pen, 7);

                case ShapeType.Octagon: return new VariableSidedPolygon(g, pen, 8);

                case ShapeType.ThreePointedStar: return new VariablePointedStar(g, pen, 3);

                case ShapeType.FourPointedStar: return new VariablePointedStar(g, pen, 4);

                case ShapeType.FivePointedStar: return new VariablePointedStar(g, pen, 5);

                case ShapeType.SixPointedStar: return new VariablePointedStar(g, pen, 6);

                //Create new object to avoid all variable shapes merging when everythign is redrawn
                case ShapeType.VariablePolygon:
                    return new VariableSidedPolygon(g, pen, ((VariableSidedPolygon)variablePolygon).Sides);

                //Create new object to avoid all variable shapes merging when everythign is redrawn
                case ShapeType.VariableStar:
                    return new VariablePointedStar(g, pen, ((VariablePointedStar)variableStar).PointNumber);

            }
        }

        private void DrawShape(Graphics g, Pen pen, DrawInformation drwInfo)
        {
            Shape currentShape = GetCurrentShape(g, pen);
            if(currentShape != null)
            {
                currentShape.SetDrawLocationInformation(drwInfo);
                currentShape.Draw();

                if (g == imageGraphics)
                {
                    //If drawing to image
                    shapeList.Add(currentShape);
                }
            }
        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;

            if (IsDrawing)
            {
                drawEnd = mousePosition; //shape boundary ends at current mouse position
                Invalidate(); //Refresh canvas
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            IsDrawing = true; //Shape has not finished being drawn
            drawStart = mousePosition; //shape boundary starts at current mouse position
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if(IsDrawing)
            {
                IsDrawing = false;
                drawEnd = mousePosition;

                DrawShape(imageGraphics, blackPen, new DrawInformation(drawStart,drawEnd));
            }

            //Keep track of all shapes
        }

        
        
    }
}
