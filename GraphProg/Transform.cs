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
    public partial class Transform : Form
    {
        private Shape internalShape;

        private ColorDialog lineColourDialog;
        private ColorDialog fillColourDialog;

        private object[] original;

        Timer clickTimer = new Timer();

        int ShapeHeight
        {
            get
            {
                int.TryParse(heightTextbox.Text, out int output);
                return output;
            }
        }

        int ShapeWidth
        {
            get
            {
                int.TryParse(widthTextbox.Text, out int output);
                return output;
            }
        }

        int Num
        {
            get
            {
                int.TryParse(num.Text, out int output);
                return output;
            }
        }

        int RotateAmount
        {
            get
            {
                int.TryParse(rotateTextBox.Text, out int output);
                return output;
            }
        }
        Canvas.methodPointer redraw;
        ShapeVersionControl shapeVersionControl;

        public Transform(Canvas.methodPointer redraw, ShapeVersionControl shapeVersionControl)
        {
            InitializeComponent();

            lineColourDialog = new ColorDialog();
            fillColourDialog = new ColorDialog();

            shapeComboBox.DataSource = new string[] 
            {
                "Square", "Circle", "RightAngledTriangle", "Triangle",
                "Pentagon", "Diamond", "Polygon", "Star"
            };

            this.redraw = redraw;

            this.shapeVersionControl = shapeVersionControl;
        }

        public void SelectShape(Shape s)
        {
            internalShape = s;

            lineColourDialog.Color = s.penColour;
            fillColourDialog.Color = s.fillColour;

            shapeComboBox.Text = s.shapeType;
            widthTextbox.Text = s.Rect.Width.ToString();
            heightTextbox.Text = s.Rect.Height.ToString();

            lineThicknessTrackBar.Value = Convert.ToInt32(s.penThickness);
            rotateTextBox.Text = s.RotateAmount.ToString();
            fillCheckBox.Checked = s.DoFill;

            original = new object[7]
            {
                shapeComboBox.Text, widthTextbox.Text, heightTextbox.Text,
                lineThicknessTrackBar.Value, lineColourDialog.Color, fillColourDialog.Color, fillCheckBox.Checked
            };
        }

        private void DeselectShape()
        {
            internalShape = null;
        }

        private void Transform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeselectShape();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lineColourDialog.ShowDialog() == DialogResult.OK)
            {
                ((Shape)internalShape).SetPenColour(lineColourDialog.Color);
                redraw(null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fillColourDialog.ShowDialog() == DialogResult.OK)
            {
                Brush newBrush = new SolidBrush(fillColourDialog.Color);
                ((Shape)internalShape).SetFillBrush(newBrush);
                redraw(null);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).Fill();
            redraw(null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lineThicknessTrackBar.Value++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lineThicknessTrackBar.Value--;
        }

        private void lineThicknessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).SetPenThickness(lineThicknessTrackBar.Value);
            redraw(null);
        }

        private void heightTextbox_TextChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).SetHeight(ShapeHeight);
            redraw(null);
        }

        private void widthTextbox_TextChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).SetWidth(ShapeWidth);
            redraw(null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = num.Visible = button3.Visible = button11.Visible =
                shapeComboBox.Text == "Polygon" || shapeComboBox.Text == "Star";

            shapeVersionControl.ChangeShape(ref internalShape, shapeComboBox.Text, Num);
            redraw(null);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Num > 6)
                num.Text = (int.Parse(num.Text) - 1).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Num < 12)
                num.Text = (int.Parse(num.Text) + 1).ToString();
        }


        private void button9_Click(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                widthTextbox.Text = (int.Parse(widthTextbox.Text) - 2).ToString();
            };
            clickTimer.Start();
        }
        private void button10_Click(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                widthTextbox.Text = (int.Parse(widthTextbox.Text) + 2).ToString();
            };
            clickTimer.Start();
        }

        private void button7_Click(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                heightTextbox.Text = (int.Parse(heightTextbox.Text) - 2).ToString();
            };
            clickTimer.Start();
        }

        private void button8_Click(object sender, MouseEventArgs e)
        { 
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                heightTextbox.Text = (int.Parse(heightTextbox.Text) + 2).ToString();
            };
            clickTimer.Start();
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            clickTimer.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Return shape settings to normal
            shapeComboBox.Text = (string)original[0];
            widthTextbox.Text = (string)original[1];
            heightTextbox.Text = (string)original[2];
            lineThicknessTrackBar.Value = (int)original[3];
            lineColourDialog.Color = (Color)original[4];
            fillColourDialog.Color = (Color)original[5];
            fillCheckBox.Checked = (bool)original[6];
        }

        private void Transform_Load(object sender, EventArgs e)
        {

        }

        private void rotateTextBox_TextChanged(object sender, EventArgs e)
        {
            shapeVersionControl.RotateShape(ref internalShape, RotateAmount);
            redraw(null);
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                if(RotateAmount >= 2)
                    rotateTextBox.Text = (int.Parse(rotateTextBox.Text) - 2).ToString();
            };
            clickTimer.Start();
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                if (RotateAmount <= 364)
                    rotateTextBox.Text = (int.Parse(rotateTextBox.Text) + 2).ToString();
            };
            clickTimer.Start();
        }
    }
}
