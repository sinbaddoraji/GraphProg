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
        public enum ShapeType 
        { 
            None, Square, Circle, Triangle, 
            RightAngTriangle, Trapezoid, Diamond, 
            Pentagon, Hexagon, Heptagon, Octagon, 
            ThreePointedStar, FourPointedStar, FivePointedStar, 
            SixPointedStar, VariableStar, VariablePolygon 
        };

        private ShapeType selectedShapeType;

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

        public enum MoveDirection { Left, Up, Right, Down}

        public void MoveShapes(List<Shape> shapes, MoveDirection direction, float amount)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.Rect.Y < Height)
                {
                    shape.Move(direction, amount);
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

        TextBox keyInterceptor = new TextBox(); //Textbox used to intercept keydown events for canvas

        public Canvas()
        {

            //Set size of canvas
            Size = oldSize = new Size(100, 100);

            selectedShapeType = ShapeType.None;

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

            keyInterceptor.ReadOnly = true;
            keyInterceptor.Location = new Point(Width, Height);

            this.Controls.Add(keyInterceptor);
        }


        public void SetKeyDownEvent(KeyEventHandler keyEventHandler)
        {
            //Set key down event handler for keyInterceptor
            keyInterceptor.KeyDown += keyEventHandler;
        }

        public void SetKeyupEvent(KeyEventHandler keyEventHandler)
        {
            //Set key down event handler for keyInterceptor
            keyInterceptor.KeyUp += keyEventHandler;
        }



        private void Canvas_MouseHover(object sender, EventArgs e)
        {
            //Force focus to be shifted to the keyInterceptor which is within canvas
            //This will allow the canvas to intercept key press event handlers using the textbox
            keyInterceptor.Focus();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (!IsDrawing) return;

            //Draw preview of shape being drawn before final shape is drawn to image
            DrawShape(e.Graphics, blackPen, new DrawInformation(drawStart, drawEnd));
        }

        public void SelectShape(ShapeType shape)
        {
            //SelectShapeType
            selectedShapeType = shape;
        }


        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            Image img = new Bitmap(Width, Height);
            imageGraphics = Graphics.FromImage(img);

            keyInterceptor.Location = new Point(Width, Height);

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
            switch(selectedShapeType)
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

                if (g == imageGraphics && currentShape.Rect.Width >= 8 && currentShape.Rect.Height >= 8)
                {
                    currentShape.Draw();

                    //If drawing to image and shape then save shape in list
                    shapeList.Add(currentShape);
                }
                else if (g != imageGraphics)
                {
                    currentShape.Draw(); // Draw shape preview
                    Invalidate();
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
                drawEnd = mousePosition;//shape boundary ends at current mouse position

                //Draw shape to image (Draw real version of the shape)
                DrawShape(imageGraphics, blackPen, new DrawInformation(drawStart,drawEnd));
            }

        }

        
        
    }
}
