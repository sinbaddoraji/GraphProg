using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphProg
{
    public partial class Form1 : Form
    {
        private readonly SaveFileDialog saveFileDialog;
        private readonly ColorDialog colorDialog;
        private readonly VariableShape VariablePolygon;
        private readonly VariableShape VariableStar;

        private List<Shape> selectedShapes;
        private bool isMouseClick = false;
        private Point dragStart;
        private readonly float shapeDisplacement = 2;

        public Form1()
        {
            InitializeComponent();

            canvas1.Size = canvas1.MinimumSize = Screen.FromControl(this).Bounds.Size;

            //Initalize saveFileDialog that will be used to export graphics to image
            saveFileDialog = new SaveFileDialog
            {
                Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg" +
             "|PCX Files (*.pcx)|*.pcx|PNG Files (*.png)|*.png" +
             "|GIF Files (*.gif)|*.gif" +
             "|Wireless Bitmap Files (*.wbm, *.wbmp)|*.wbm;*.wbmp" +
             "|Adobe Photoshop Files (*.psd)|*.psd" +
             "|TIFF Files (*.tif, *.tiff)|*.tif;*.tiff"
            };

            colorDialog = new ColorDialog();
            colorDialog.Color = Color.Red;

            VariablePolygon = new VariableShape(VariableShape.Type.Polygon);
            VariableStar = new VariableShape(VariableShape.Type.Star);

            canvas1.SetKeyDownEvent(new KeyEventHandler(Canvas_KeyDown));
            canvas1.SetKeyupEvent(new KeyEventHandler(Canvas_KeyUp));
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
            UncheckToolstrips();

            noShapeToolStripMenuItem.Checked = true;
            noShapeRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.None);
        }

        private void NoShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            UncheckToolstrips();

            squareToolStripMenuItem.Checked = true;
            squareRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Square);
        }

        private void CircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            circleToolStripMenuItem.Checked = true;
            circleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Circle);
        }

        private void TriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            triangleToolStripMenuItem.Checked = true;
            triangleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Triangle);
        }

        private void RightangledTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            rightangledTriangleToolStripMenuItem.Checked = true;
            rTriangleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.RightAngTriangle);
        }

        private void DiamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            diamondToolStripMenuItem.Checked = true;
            diamondRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Diamond);
        }

        private void PentagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            pentagonToolStripMenuItem.Checked = true;
            pentagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Pentagon);
        }

        private void HeptagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            hexagonToolStripMenuItem.Checked = true;
            hexagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Hexagon);
        }

        private void HeptagonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UncheckToolstrips();

            heptagonToolStripMenuItem.Checked = true;
            heptagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Heptagon);
        }

        private void TrapezoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            trapezoidToolStripMenuItem.Checked = true;
            TrapezoidRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Trapezoid);
        }

        private void OctagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            octagonToolStripMenuItem.Checked = true;
            octagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Octagon);
        }

        private void FivePointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            fivePointStarToolStripMenuItem.Checked = true;
            fiveStarRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.FivePointedStar);
        }

        private void SixPointedStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            sixPointedStarToolStripMenuItem.Checked = true;
            SixRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.SixPointedStar);
        }

        private void FourPointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            fourPointStarToolStripMenuItem.Checked = true;
            fourRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.FourPointedStar);
        }

        private void ThreePointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            threePointStarToolStripMenuItem.Checked = true;
            threeRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.ThreePointedStar);
        }

        private void ShapeSettingsButton_Click(object sender, EventArgs e)
        {
            //Fill shape
            //outline colour
            //inside colour
        }

        private void VarPolygonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (VariablePolygon.ShowDialog() == DialogResult.OK)
            {
                canvas1.variablePolygon = VariablePolygon.Shape;

                UncheckToolstrips();

                variablePointedStarToolStripMenuItem.Checked = true;
                varPolygonRadioButton.Checked = true;

                canvas1.SelectShape(Canvas.ShapeType.VariablePolygon);
            }

        }

        private void VarStarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (VariableStar.ShowDialog() == DialogResult.OK)
            {
                canvas1.variableStar = VariableStar.Shape;

                UncheckToolstrips();

                variablePointedStarToolStripMenuItem.Checked = true;
                VarStarRadioButton.Checked = true;

                canvas1.SelectShape(Canvas.ShapeType.VariableStar);
            }
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            selectToolStripMenuItem.Checked = true;
            selectRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.None);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectRadioButton.Checked)
            {

                selectedShapes = canvas1.GetShapesSurrounding(canvas1.mousePosition);

                if (selectedShapes.Count > 1)
                {
                    var msg = MessageBox.Show("Do you want to choose the shapes to stay selected", "Multiple Shapes have been selected (Selecting No will highlight all the shapes)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msg == DialogResult.Yes)
                    {
                        var sShapes = new SelectShapes(selectedShapes, canvas1.Redraw);
                        sShapes.ShowDialog();

                        selectedShapes = sShapes.internalShapes;
                    }
                    else
                    {
                        canvas1.Redraw(selectedShapes);
                    }
                    isMouseClick = false;
                }
                else
                {
                    canvas1.Redraw(selectedShapes);
                    isMouseClick = true;
                }
                dragStart = canvas1.mousePosition;

            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            
            //Mouse click has been released
            isMouseClick = false;
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
              

            if (e.KeyCode == Keys.Left)
            {
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Left, shapeDisplacement);
            }

            if (e.KeyCode == Keys.Right)
            {
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Right, shapeDisplacement);
            }

            if (e.KeyCode == Keys.Up)
            {
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Up, shapeDisplacement);
            }

            if (e.KeyCode == Keys.Down)
            {
                canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Down, shapeDisplacement);
            }
        }

        private void Canvas_KeyUp(object sender, KeyEventArgs e)
        {
        }


        private void Canvas1_MouseMove(object sender, MouseEventArgs e)
        {

            if (selectedShapes != null && isMouseClick)
            {
                float xDifference = e.X - dragStart.X;
                float yDifference = e.Y - dragStart.Y;

                dragStart = e.Location;

                if (xDifference < 0)
                {
                    canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Left, Math.Abs(xDifference));
                }
                else
                {
                    canvas1.MoveShapes(selectedShapes, Canvas.MoveDirection.Right, xDifference);
                }

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

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Delete selected shapes
            canvas1.DeleteShapes(selectedShapes);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas1.Redo();
        }

        private void changeHighlightColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Shape shape in canvas1.shapeVersionControl.GetShapeList())
                {
                    shape.SetHighlightColour(colorDialog.Color);
                }
            }
            
            
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(selectedShapes.Count > 0)
            {
                foreach (Shape shape in selectedShapes)
                {
                    shape.Fill();
                }
                canvas1.Redraw();
            }
        }
    }
}
