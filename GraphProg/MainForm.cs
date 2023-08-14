using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GraphProg.Data.Implementation.Shape;

namespace GraphProg
{
    public partial class MainForm : Form
    {
        private readonly SaveFileDialog saveFileDialog;
        private readonly VariableShape VariablePolygon;
        private readonly VariableShape VariableStar;

        private List<Shape> selectedShapes;
        private bool isMouseClick = false;
        private Point dragStart;
        private readonly float shapeDisplacement = 2;
        private readonly Transform tDialog;
        private readonly Settings settings;

        public MainForm()
        {
            InitializeComponent();

            //Make canvas the size of screen to make sure graphics remain on image after canvas resize
            canvas1.Size = canvas1.MinimumSize = Screen.FromControl(this).Bounds.Size;

            //Initalize saveFileDialog that will be used to export graphics to image
            saveFileDialog = new SaveFileDialog
            {
                Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg" +
             "|PCX Files (*.pcx)|*.pcx|PNG Files (*.png)|*.png" +
             "|GIF Files (*.gif)|*.gif" +
             "|Wireless Bitmap Files (*.wbm, *.wbmp)|*.wbm;*.wbmp" +
             "|TIFF Files (*.tif, *.tiff)|*.tif;*.tiff"
            };

            VariablePolygon = new VariableShape(VariableShape.Type.Polygon);
            VariableStar = new VariableShape(VariableShape.Type.Star);

            canvas1.SetKeyDownEvent(new KeyEventHandler(Canvas_KeyDown));

            //Clear canvas (Paint it white)
            canvas1.ClearCanvas();

            tDialog = new Transform(canvas1.Redraw, canvas1.shapeVersionControl);
            settings = new Settings(canvas1);
        }



        private void UncheckToolstrips()
        {
            //Uncheck buttons in 'create' menu 
            foreach (var item in createToolStripMenuItem.DropDownItems)
            {
                try
                {
                    ((ToolStripMenuItem)item).Checked = false;
                }
                catch (Exception)
                {
                    //Do nothing (item is not a tool strip menu item)
                    continue;
                }

            }
        }
        private void DeselectAllShapes()
        {
            //Deselect all shapes
            UncheckToolstrips();

            noShapeToolStripMenuItem.Checked = true;
            noShapeRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.None);
        }

        private void NoShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select no shape
            DeselectAllShapes();
        }


        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                canvas1.Image.Save(saveFileDialog.FileName);
                Text = saveFileDialog.FileName;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void SquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select square
            UncheckToolstrips();

            squareToolStripMenuItem.Checked = true;
            squareRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Square);
            Text = "Square";
        }

        private void CircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select circle
            UncheckToolstrips();

            circleToolStripMenuItem.Checked = true;
            circleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Circle);
            Text = "Circle";
        }

        private void TriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select triangle
            UncheckToolstrips();

            triangleToolStripMenuItem.Checked = true;
            triangleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Triangle);
            Text = "Triangle";
        }

        private void RightangledTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select right angled trianfle
            UncheckToolstrips();

            rightangledTriangleToolStripMenuItem.Checked = true;
            rTriangleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.RightAngTriangle);
            Text = "Right-angled Triangle";
        }

        private void DiamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select diamond
            UncheckToolstrips();

            diamondToolStripMenuItem.Checked = true;
            diamondRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Diamond);
            Text = "Diamond";
        }

        private void PentagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select pentagon
            UncheckToolstrips();

            pentagonToolStripMenuItem.Checked = true;
            pentagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Pentagon);
            Text = "Pentagon";
        }

        private void HexagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select Hexagon
            UncheckToolstrips();

            hexagonToolStripMenuItem.Checked = true;
            hexagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Hexagon);
            Text = "Hexagon";
        }

        private void HeptagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select Heptagon
            UncheckToolstrips();

            heptagonToolStripMenuItem.Checked = true;
            heptagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Heptagon);
            Text = "Heptagon";
        }

        private void TrapezoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select Trapezoid
            UncheckToolstrips();

            trapezoidToolStripMenuItem.Checked = true;
            TrapezoidRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Trapezoid);
            Text = "Trapezoid";
        }

        private void OctagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select Octagon
            UncheckToolstrips();

            octagonToolStripMenuItem.Checked = true;
            octagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Octagon);
            Text = "Octagon";
        }

        private void FivePointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select 5 pointed star
            UncheckToolstrips();

            fivePointStarToolStripMenuItem.Checked = true;
            fiveStarRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.FivePointedStar);
            Text = "Five pointed star";
        }

        private void SixPointedStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select 6 pointed star
            UncheckToolstrips();

            sixPointedStarToolStripMenuItem.Checked = true;
            SixRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.SixPointedStar);
            Text = "Six pointed star";
        }

        private void FourPointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select 4 pointed star
            UncheckToolstrips();

            fourPointStarToolStripMenuItem.Checked = true;
            fourRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.FourPointedStar);
            Text = "Four pointed star";
        }

        private void ThreePointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Select 3 pointed star
            UncheckToolstrips();

            threePointStarToolStripMenuItem.Checked = true;
            threeRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.ThreePointedStar);
            Text = "Three pointed star";
        }

        private void VarPolygonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Select variable sided polygon
            if (VariablePolygon.ShowDialog() == DialogResult.OK)
            {
                canvas1.variablePolygon = VariablePolygon.Shape;

                UncheckToolstrips();

                variablePointedStarToolStripMenuItem.Checked = true;
                varPolygonRadioButton.Checked = true;

                canvas1.SelectShape(Canvas.ShapeType.VariablePolygon);
                Text = "Variable sided polygon";
            }

        }

        private void VarStarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Select variable pointed star
            if (VariableStar.ShowDialog() == DialogResult.OK)
            {
                canvas1.variableStar = VariableStar.Shape;

                UncheckToolstrips();

                variablePointedStarToolStripMenuItem.Checked = true;
                VarStarRadioButton.Checked = true;

                canvas1.SelectShape(Canvas.ShapeType.VariableStar);
                Text =  "Variable pointed star";
            }
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            selectToolStripMenuItem.Checked = true;
            selectRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.None);
            Text = "Select";
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //Select shapes by mouse
            if (e.Button == MouseButtons.Left && selectRadioButton.Checked)
            {
                SelectShapes();
            }
        }

        private void SelectShapes()
        {
            selectedShapes = canvas1.GetShapesSurrounding(canvas1.mousePosition);

            if (selectedShapes.Count > 1)
            {
                var msg = MessageBox.Show("Do you want to choose the shapes to stay selected", "Multiple Shapes have been selected (Selecting No will highlight all the shapes)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    var sShapes = new SelectShapes(selectedShapes, canvas1);
                    sShapes.ShowDialog();

                    selectedShapes = sShapes.internalShapes; //Declear selected shapes
                }
                else
                {
                    //Select all shapes
                    canvas1.Redraw(selectedShapes); // Redraw while highlighting selected shapes
                }
                isMouseClick = false; //Mouse key is not being pressed
            }
            else
            {
                //Else redraw shapes
                canvas1.Redraw(selectedShapes); //Redraw canvas
                isMouseClick = true; //mouse key is beign pressed
            }
            dragStart = canvas1.mousePosition;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            //Mouse click has been released
            isMouseClick = false;
        }

        private void Canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if(canvas1.IsDrawing && (selectedShapes == null || selectedShapes.Count == 0))
            {
                var rect = new DrawInformation(canvas1.DrawStart, canvas1.DrawEnd).Rect;
                toolStripStatusLabel1.Text = $"Width: {rect.Width}, Height: {rect.Height}";
            }
            else
            {
                toolStripStatusLabel1.Text = $"Mouse Position ({e.X}, {e.Y})";
            }

            if (selectedShapes != null && isMouseClick)
            {
                float xDifference = e.X - dragStart.X;
                float yDifference = e.Y - dragStart.Y;
                dragStart = e.Location;

                //Move shape on x axis by difference between original position and new mouse position
                if (xDifference < 0)
                {
                    canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Left, Math.Abs(xDifference));
                }
                else
                {
                    canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Right, xDifference);
                }

                //Move shape on y axis by difference between original position and new mouse position
                if (yDifference < 0)
                {
                    canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Up, Math.Abs(yDifference));
                }
                else
                {
                    canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Down, yDifference);
                }
            }
        }


        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                //Move shape left
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Left, shapeDisplacement);
            }
            else if (e.KeyCode == Keys.Right)
            {
                //Move shape right
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Right, shapeDisplacement);
            }
            else if (e.KeyCode == Keys.Up)
            {
                //Move shape up
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Up, shapeDisplacement);
            }
            else if (e.KeyCode == Keys.Down)
            {
                //Move shape down
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Down, shapeDisplacement);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Delete selected shapes
            canvas1.DeleteShapes(selectedShapes); //Delete selected shapes
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas1.Undo();// Undo last action
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas1.Redo(); // Redo last action
        }

        private void ChangeHighlightColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedShapes == null || selectedShapes.Count == 0)
            {
                return;
            }

            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Shape shape = canvas1.shapeVersionControl.GetShapeList()[0];
                shape.SetHighlightColour(cd.Color);
            }
        }

        private void FillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillSelectedShapes();
        }

        private void FillSelectedShapes()
        {
            if(selectedShapes == null || selectedShapes.Count == 0)
            {
                MessageBox.Show("No shapes are selected", "Please select a shape");
                return;
            }

            for (int i = 0; i < selectedShapes.Count; i++)
            {
                selectedShapes[i].Fill(); //Fill shape or remove fill
            }
            canvas1.Redraw();
            //Redraw shapes on the canvas
        }

        private void ChangeFillColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFillColour(); //Change fill colour of selected shapes

            if (selectedShapes == null || selectedShapes.Count == 0)
            {
                return;
            }
            //Check if there are shapes that are'nt filled

            for (int i = 0; i < selectedShapes.Count; i++)
            {
                if (selectedShapes[i].DoFill)
                {
                    continue;
                }

                var msg = MessageBox.Show("Do you want to fill selected shapes?", "One or more of the selected shapes are not filled", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    FillSelectedShapes();
                    break;//Run once
                }
            }
        }

        private void ChangeFillColour()
        {
            //Change selected shape fill colour
            if (selectedShapes == null || selectedShapes.Count == 0)
            {
                MessageBox.Show("No shapes are selected", "Please select a shape");
                return;
            }

            //Change fill colour of selected shapes to the selected colour of the colorDialog
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                for (int i = 0; i < selectedShapes.Count; i++)
                {
                    selectedShapes[i].SetFillBrush(new SolidBrush(cd.Color));
                }
                canvas1.Redraw();
            }
        }

        private void ChangeBackgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(ColorDialog cd = new ColorDialog())
            {
                cd.Color = BackColor;

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    canvas1.BackColor = cd.Color; //Set background colour to colour dialog
                }
            }
        }

        private void TransformToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(selectedShapes == null || selectedShapes.Count < 1)
            {
                MessageBox.Show("No shape was selected", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectedShapes.Count > 1)
            {
                MessageBox.Show("Only the first shape will be selected for transformation", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Select shape and shpw transformation dialog
            tDialog.SelectShape(selectedShapes[0]);
            tDialog.ShowDialog();
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            //Redraw all shapes when form is resized
            canvas1.Redraw(selectedShapes);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            //Show settings dialog
            settings.ShowDialog();
        }
    }
}
