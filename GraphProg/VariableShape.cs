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

        private int value => Convert.ToInt32(numericUpDown1.Value);

        public Shape customShape
        {
            get
            {
                if(selectedType == Type.Polygon)
                {
                    return new VariableSidedPolygon(value);
                }
                else
                {
                    return new VariablePointedStar(value);
                }
            }
        }

        public VariableShape(Type selectedType)
        {
            InitializeComponent();

            this.selectedType = selectedType;
            if (selectedType == Type.Polygon)
            {
                label1.Text = "Number of Sides";
            }
            else
            {
                label1.Text = "Number of Points";
            }

            canvas1.imageGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            canvas1.imageGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            numericUpDown1.Value = 9;// Change value to call value change event handler so default image can be drawn to canvas
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Shape shape;

            Pen blackPen = new Pen(Brushes.Black, 2f);

            if(selectedType == Type.Polygon)
            {
                shape = new VariableSidedPolygon(canvas1.imageGraphics, blackPen, value);
                numericUpDown1.Minimum = 6;
            }
            else
            {
                shape = new VariablePointedStar(canvas1.imageGraphics, blackPen, value);
            }


            var drawInformation = new DrawInformation(new Point(0, 0), new Point(canvas1.Width - 8, canvas1.Height - 8));
            shape.SetDrawLocationInformation(drawInformation);

            canvas1.imageGraphics.Clear(canvas1.BackColor);
            shape.Draw();
            canvas1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
