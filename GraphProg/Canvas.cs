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

        public Graphics imageGraphics; //Graphics of control
        public Graphics outerGraphics; //Graphics of image

        public Point mousePosition; //mouse position on canvas

        private Point drawStart; //Mouse position at the start of ruber banding

        public Point DrawStart => drawStart;

        private Point drawEnd; //Mouse position at the end of ruber banding

        public Point DrawEnd => drawEnd; 

        private Pen pen; //Pen 

        private Color lineColour = Color.Black; //line colour

        public Color LineColour => lineColour;

        private Color fillColour = Color.Black; //Fill colour

        public Color FillColour => fillColour;

        private Color highlightColour = Color.Red; //Highlight colour

        public Color HighlightColour => highlightColour;

        public ShapeVersionControl shapeVersionControl = new ShapeVersionControl();

        private List<Shape> ShapeList => shapeVersionControl.GetShapeList(); //Shape list

        private float lineSize = 3f; //Line size of shapes to be drawn

        public float LineSize => lineSize;

        public Shape variablePolygon; //Variable polygon object used to hold data that will be used in other variable polygon objects
        public Shape variableStar; //Variable star object used to hold data that will be used in other variable star objects

        public delegate void methodPointer(List<Shape> shapes); //Delegate method to allow other classes to redraw shapes in canvas
        public methodPointer redrawMethodPointer; //Redraw  pointer

        public void Undo()
        {
            shapeVersionControl.Undo(); //Go to newer version of shape list
            Redraw(); // Redraw all shapes
        }

        public void Redo()
        {
            shapeVersionControl.Redo(); //Go back to previous version of shape list
            Redraw(); // Redraw all shapes
        }

        public List<Shape> GetShapesSurrounding(Point p)
        {
            List<Shape> shapes = new List<Shape>(); //Output list

            //Get shapes that intersects with point p
            for (int i = 0; i < ShapeList.Count; i++)
            {
                var shapeRectangle = ShapeList[i].GetDrawLocationInformation().Rect; //Shape rectangle
                if(shapeRectangle.Contains(p)) shapes.Add(ShapeList[i]); // if shape intersects add to output list
            }

            return shapes; //Return shapes
        }

        public void DeleteShapes(List<Shape> shapes)
        {
            shapeVersionControl.RemoveShape(shapes); //Remove shapes from shape list
            Redraw();
        }

        public enum MoveDirection { Left, Up, Right, Down}

        public void MoveShapes(List<Shape> shapes, MoveDirection direction, float amount)
        {
            if (shapes == null || shapes.Count == 0 || amount == 0) return;

            for (int i = 0; i < shapes.Count; i++)
            {
                Shape shape = shapes[i];

                float yBoundary = shape.Rect.Y + shape.Rect.Height;
                float xBoundary = shape.Rect.X + shape.Rect.Width;

                //move only if it will remain within canvas
                if (yBoundary < Height && xBoundary < Width)
                {
                    shape.Move(direction, amount); // Move shapes to a specific direction
                }
            }
            
            Redraw(shapes); //Redraw shapes
        }

        public void Redraw(List<Shape> selectedShapes = null)
        {
            ClearCanvas(); //Clear Canvas Graphics

            //redraw all shapes
            for (int i = 0; i < ShapeList.Count; i++)
            {
                Shape shape = ShapeList[i]; // Current shape being drawn

                //if shape is highlighted or not
                bool highlight = selectedShapes != null && selectedShapes.Contains(shape);

                shape.SetGraphics(imageGraphics);
                shape.Draw(highlight); // Draw current shape
            }
            Invalidate();
        }

        public void ClearCanvas()
        {
            //Clear Canvas Graphics
            imageGraphics.Clear(BackColor);
            outerGraphics.Clear(BackColor);
        }

        readonly TextBox keyInterceptor = new TextBox(); //Textbox used to intercept keydown events for canvas

        public Canvas()
        {

            //Set size of canvas
            Size = new Size(1, 1);
            BackColor = Color.White;

            selectedShapeType = ShapeType.None;

            //Initalize event handlers
            MouseMove += Canvas_MouseMove;
            MouseDown += Canvas_MouseDown;
            MouseUp += Canvas_MouseUp;

            SizeChanged += Canvas_SizeChanged;

            Paint += Canvas_Paint;
            //canvasImage = System

            pen = new Pen(Brushes.Black, lineSize);

            //Round out line edges for better quality of shapes
            pen.StartCap = pen.EndCap = LineCap.Round;

            outerGraphics = this.CreateGraphics();

            //Set control to be double buffered
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            redrawMethodPointer = Redraw;

            this.MouseHover += Canvas_MouseHover;

            keyInterceptor.ReadOnly = true;
            keyInterceptor.Location = new Point(Width, Height);

            this.Controls.Add(keyInterceptor);
        }

        public void SetFillColour(Color color)
        {
            fillColour = color;
        }

        public void SetLineColour(Color color)
        {
            lineColour = color;
        }

        public void SetHighlightColour(Color color)
        {
            highlightColour = color;
        }

        public void SetlineWidth(float width)
        {
            this.lineSize = width;
        }

        public void SetKeyDownEvent(KeyEventHandler keyEventHandler)
        {
            //Set key down event handler for keyInterceptor
            keyInterceptor.KeyDown += keyEventHandler;
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
            DrawShape(e.Graphics, pen, new DrawInformation(drawStart, drawEnd));
        }

        public void SelectShape(ShapeType shape)
        {
            //Select Shape Type
            selectedShapeType = shape;
        }


        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            //Take image and draw it to new bigger image the size of the window
            Image img = new Bitmap(Width, Height);
            imageGraphics = Graphics.FromImage(img);

            //Move text box used for interception to the end of keyInterceptor
            keyInterceptor.Location = new Point(Width, Height);

            outerGraphics.Clear(BackColor);
            if (Image == null)
            {
                imageGraphics.Clear(BackColor);
                Image = img;
            }
            else
            {
                Rectangle destinationRect = new Rectangle(0, 0, img.Width, img.Height);
                imageGraphics.DrawImage(Image, destinationRect, 0, 0, img.Width, img.Height, GraphicsUnit.Document);

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

                case ShapeType.Circle: return new Circle(g, pen); //object for circle

                case ShapeType.Triangle: return new Triangle(g, pen); //object for triangle

                case ShapeType.RightAngTriangle: return new RightAngledTriangle(g, pen); //object for rightAngledTriangle

                case ShapeType.Trapezoid: return new Trapezoid(g, pen); //object for Trapezoid

                case ShapeType.Square: return new Square(g, pen); //object for square

                case ShapeType.Diamond: return new Diamond(g, pen); //object for diamond

                case ShapeType.Pentagon: return new Pentagon(g, pen); //object for 5 sided polygon

                case ShapeType.Hexagon: return new VariableSidedPolygon(g, pen, 6); //object for 6 sided polygon

                case ShapeType.Heptagon: return new VariableSidedPolygon(g, pen, 7); //object for 7 sided polygon

                case ShapeType.Octagon: return new VariableSidedPolygon(g, pen, 8); //object for 8 sided polygon

                case ShapeType.ThreePointedStar: return new VariablePointedStar(g, pen, 3); //object for 3 pointed star

                case ShapeType.FourPointedStar: return new VariablePointedStar(g, pen, 4); //object for 4 pointed star

                case ShapeType.FivePointedStar: return new VariablePointedStar(g, pen, 5); //object for 5 pointed star

                case ShapeType.SixPointedStar: return new VariablePointedStar(g, pen, 6); //object for 6 pointed star

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
            Shape currentShape = GetCurrentShape(g, pen); //Shape to be drawn
            if (currentShape == null) return;

            currentShape.SetPenColour(lineColour);
            currentShape.SetHighlightColour(highlightColour);
            currentShape.SetPenThickness(lineSize);
            currentShape.SetFillBrush(new SolidBrush(fillColour));

            if(currentShape != null)
            {
                currentShape.SetDrawLocationInformation(drwInfo);

                //if shape is big enough then draw 
                if (g == imageGraphics && currentShape.Rect.Width >= 8 && currentShape.Rect.Height >= 8)
                {
                    currentShape.Draw(false);

                    //If drawing to image and shape then save shape in list
                    shapeVersionControl.AddShape(currentShape);
                }
                else if (g != imageGraphics)
                {
                    currentShape.Draw(false); // Draw shape preview
                    Invalidate();
                }
            }
        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location; //Set mouse location

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
                DrawShape(imageGraphics, pen, new DrawInformation(drawStart,drawEnd));
            }

        }

        
        
    }
}
