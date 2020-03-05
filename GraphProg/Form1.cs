using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphProg
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog;

        VariableShape VariablePolygon;
        VariableShape VariableStar;

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
             "|TIFF Files (*.tif, *.tiff)|*.tif;*.tiff" +
             "|All Image Files|*.bmp;*.jpg;*.jpeg;*.pcx;*.png;*.gif;*.wbm;*.wbmp;*.psd;*.tif;*.tiff"
            };

            VariablePolygon = new VariableShape(VariableShape.Type.Polygon);
            VariableStar = new VariableShape(VariableShape.Type.Star);


            canvas1.SetKeyDownEvent(new KeyEventHandler(Form1_KeyDown));
            canvas1.SetKeyupEvent(new KeyEventHandler(Form1_KeyUp));
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
        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                canvas1.Image.Save(saveFileDialog.FileName);
                Text = saveFileDialog.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeselectAllShapes();
        }

        private void DeselectAllShapes()
        {
            UncheckToolstrips();

            noShapeToolStripMenuItem.Checked = true;
            noShapeRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.None);
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            squareToolStripMenuItem.Checked = true;
            squareRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Square);
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            circleToolStripMenuItem.Checked = true;
            circleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Circle);
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            triangleToolStripMenuItem.Checked = true;
            triangleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Triangle);
        }

        private void rightangledTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            rightangledTriangleToolStripMenuItem.Checked = true;
            rTriangleRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.RightAngTriangle);
        }

        private void diamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            diamondToolStripMenuItem.Checked = true;
            diamondRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Diamond);
        }

        private void pentagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            pentagonToolStripMenuItem.Checked = true;
            pentagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Pentagon);
        }

        private void heptagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            hexagonToolStripMenuItem.Checked = true;
            hexagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Hexagon);
        }

        private void heptagonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UncheckToolstrips();

            heptagonToolStripMenuItem.Checked = true;
            heptagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Heptagon);
        }

        private void trapezoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            trapezoidToolStripMenuItem.Checked = true;
            TrapezoidRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Trapezoid);
        }

        private void octagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            octagonToolStripMenuItem.Checked = true;
            octagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Octagon);
        }

        private void fivePointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            fivePointStarToolStripMenuItem.Checked = true;
            fiveStarRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.FivePointedStar);
        }

        private void sixPointedStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            sixPointedStarToolStripMenuItem.Checked = true;
            SixRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.SixPointedStar);
        }

        private void fourPointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            fourPointStarToolStripMenuItem.Checked = true;
            fourRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.FourPointedStar);
        }

        private void threePointStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            threePointStarToolStripMenuItem.Checked = true;
            threeRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.ThreePointedStar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fill shape
            //outline colour
            //inside colour
        }

        private void varPolygonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(VariablePolygon.ShowDialog() == DialogResult.OK)
            {
                canvas1.variablePolygon = VariablePolygon.customShape;

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
                canvas1.variableStar = VariableStar.customShape;

                UncheckToolstrips();

                variablePointedStarToolStripMenuItem.Checked = true;
                VarStarRadioButton.Checked = true;

                canvas1.SelectShape(Canvas.ShapeType.VariableStar);
            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckToolstrips();

            selectToolStripMenuItem.Checked = true;
            selectRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.None);
        }

        private void canvas1_MouseDown(object sender, MouseEventArgs e)
        {
            dragStart = canvas1.mousePosition;
            

            if (selectRadioButton.Checked)
            {
                isMouseClick = true;
                selectedShapes = canvas1.GetShapesSurrounding(canvas1.mousePosition);
                if(selectedShapes.Count > 1)
                {
                    var msg = MessageBox.Show("Do you want to choose the shapes to stay selected", "Multiple Shapes have been selected (Selecting No will highlight all the shapes)", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if(msg == DialogResult.Yes)
                    {
                        var sShapes = new SelectShapes(selectedShapes,canvas1.Redraw);
                        sShapes.ShowDialog();
                    }
                    else
                    {
                        canvas1.Redraw(selectedShapes);
                    }
                }
                else
                {
                    canvas1.Redraw(selectedShapes);
                }
                
            }
        }

        private void canvas1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseClick = false;
        }

        private void canvas1_Click(object sender, EventArgs e)
        {
            
        }

        List<Shape> selectedShapes;
        bool isMouseClick = false;
        Point dragStart;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Delete)
            {
                canvas1.DeleteShapes(selectedShapes);
            }

            int displacement = 2;

            if (e.KeyCode == Keys.Left)
            {
                canvas1.MoveShapes(selectedShapes, 0, displacement);
            }

            if (e.KeyCode == Keys.Right)
            {
                canvas1.MoveShapes(selectedShapes, 2, displacement);
            }

            if (e.KeyCode == Keys.Up)
            {
                canvas1.MoveShapes(selectedShapes, 1, displacement);
            }

            if (e.KeyCode == Keys.Down)
            {
                canvas1.MoveShapes(selectedShapes, 3, displacement);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            //0 -> left
            //1 -> Up
            //2 -> Right
            //3 -> Down

            if (selectedShapes != null && isMouseClick)
            {
                float xDifference = e.X - dragStart.X;
                float yDifference = e.Y - dragStart.Y;

                dragStart = e.Location;

                Text = $"{xDifference}, {yDifference}";

                if(xDifference < 0)
                {
                    canvas1.MoveShapes(selectedShapes, 0, Math.Abs(xDifference));
                }
                else
                {
                    canvas1.MoveShapes(selectedShapes, 2, xDifference);
                }

                if(yDifference < 0)
                {
                    canvas1.MoveShapes(selectedShapes, 1, Math.Abs(yDifference));
                }
                else
                {
                    canvas1.MoveShapes(selectedShapes, 3, Math.Abs(yDifference));
                }
            }
        }
    }
}
