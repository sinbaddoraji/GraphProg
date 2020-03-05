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
        private Type selectedType;

        Pen blackPen = new Pen(Brushes.Black, 2f);

        private int value => Convert.ToInt32(numericUpDown1.Value);

        Shape shape;//Shape being drawn on preview canvas

        public Shape customShape => shape;

        DrawInformation drawInformation;

        public VariableShape(Type selectedType)
        {
            InitializeComponent();

            this.selectedType = selectedType;
            if (selectedType == Type.Polygon)
            {
                label1.Text = "Number of Sides";
                numericUpDown1.Minimum = 6;

                shape = new VariableSidedPolygon(canvas1.imageGraphics, blackPen, value);
            }
            else
            {
                shape = new VariablePointedStar(canvas1.imageGraphics, blackPen, value);
                label1.Text = "Number of Points";
            }

            //Set up object that holds draw location and size. 
            //Set draw information to mean that shape should fill the drawing canvas
            drawInformation = new DrawInformation(new Point(0, 0), new Point(canvas1.Width - 8, canvas1.Height - 8));

            shape.SetDrawLocationInformation(drawInformation);

            // Change value to call value change event handler so default image can be drawn to canvas
            numericUpDown1.Value = 9;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(selectedType == Type.Polygon)
            {
                ((VariableSidedPolygon)shape).SetSideNum(value);
            }
            else
            {
                ((VariablePointedStar)shape).SetStarPoints(value);
            }
            

            canvas1.imageGraphics.Clear(canvas1.BackColor);
            shape.Draw();
            canvas1.Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Close Form dialog 
            Close();
        }
    }
}
