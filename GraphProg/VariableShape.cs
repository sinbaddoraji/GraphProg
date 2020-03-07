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
    public partial class VariableShape : Form
    {
        public enum Type { Polygon, Star };
        private readonly Type selectedType;

        private readonly Pen blackPen = new Pen(Brushes.Black, 2f);

        private int Value => Convert.ToInt32(numericUpDown1.Value);

        public Shape Shape { get; }

        private readonly DrawInformation drawInformation;

        public VariableShape(Type selectedType)
        {
            InitializeComponent();

            this.selectedType = selectedType;

            if (selectedType == Type.Polygon)
            {
                //Set directive label
                label1.Text = "Number of Sides";

                //Set minimum number of sides to be 6 
                //Algorithm used for drawing polygon does not create desireable shapes of side length less than 6
                //Also shapes of shape length less than 6 have been implemented in other shape obkects
                numericUpDown1.Minimum = 6;

                //Make shape a polygon
                Shape = new VariableSidedPolygon(canvas1.imageGraphics, blackPen, Value);
            }
            else
            {
                //Set directive label
                label1.Text = "Number of Points";

                //Make shape a star
                Shape = new VariablePointedStar(canvas1.imageGraphics, blackPen, Value);
            }

            //Set up object that holds draw location and size. 
            //Set draw information to mean that shape should fill the drawing canvas
            drawInformation = new DrawInformation(new Point(0, 0), new Point(canvas1.Width - 8, canvas1.Height - 8));
            Shape.SetDrawLocationInformation(drawInformation);

            // Change value to call value change event handler so default image can be drawn to canvas
            numericUpDown1.Value = 9;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Set shape to either have X (value) number of sides or points depending on its shape type
            if(selectedType == Type.Polygon)
            {
                //Set the shape side number
                ((VariableSidedPolygon)Shape).SetSides(Value);
            }
            else
            {
                //Set number of points on star
                ((VariablePointedStar)Shape).SetStarPoints(Value);
            }
            
            //Clear canvas of any previous drawings
            canvas1.imageGraphics.Clear(canvas1.BackColor);
            //Draw shape to canvase
            Shape.Draw(false);
            //Refresh canvas
            canvas1.Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Close Form dialog 
            Close();
        }
    }
}
