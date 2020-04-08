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
        private Shape internalShape; //Shape being transformed

        private ColorDialog lineColourDialog; //Line colour dialog
        private ColorDialog fillColourDialog; //Fill colour dialog
        private ColorDialog highlightColourDialog; //Highlight colour dialog

        private object[] original; //array holding all shape properties (Used in restoring shape to initial state)

        private Timer clickTimer = new Timer(); //Timer used in + and - buttons
        private readonly Canvas.methodPointer redraw; //Delegate object that allows redrawing graphics on canvas
        private readonly ShapeVersionControl shapeVersionControl; //Object that handles the version control of the image being drawn on canvas

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

        public Transform(Canvas.methodPointer redraw, ShapeVersionControl shapeVersionControl)
        {
            InitializeComponent();

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

            lineColourDialog = new ColorDialog() 
            { Color = internalShape.PenColour }; //ColourDialog for line colour

            fillColourDialog = new ColorDialog() 
            { Color = internalShape.FillColour }; //ColourDialog for fill colour

            highlightColourDialog = new ColorDialog() 
            { Color = internalShape.HighlightColor }; //ColourDialog for highlight colour

            //Fill controls with shape properties
            lineThicknessTrackBar.Value = Convert.ToInt32(s.PenThickness);
            rotateTextBox.Text = s.RotateAmount.ToString();
            heightTextbox.Text = s.Rect.Height.ToString();
            widthTextbox.Text = s.Rect.Width.ToString();
            fillColourDialog.Color = s.FillColour;
            lineColourDialog.Color = s.PenColour;
            shapeComboBox.Text = s.shapeType;
            fillCheckBox.Checked = s.DoFill;

            original = new object[8]
            {
                shapeComboBox.Text, widthTextbox.Text, heightTextbox.Text,
                lineThicknessTrackBar.Value, lineColourDialog.Color, fillColourDialog.Color, fillCheckBox.Checked, rotateTextBox.Text
            };//Copy of key shape properties
        }

        private void Transform_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Release shape from Form
            internalShape = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lineColourDialog.ShowDialog() == DialogResult.OK)
            {
                ((Shape)internalShape).SetPenColour(lineColourDialog.Color); //Select line colour
                redraw(null); // Redraw shapes
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Select fill colour of selected shapes
            if (fillColourDialog.ShowDialog() == DialogResult.OK)
            {
                Brush newBrush = new SolidBrush(fillColourDialog.Color);
                ((Shape)internalShape).SetFillBrush(newBrush); //Select shape fill brush
                redraw(null);// Redraw shapes
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).Fill(); //Fill shape
            redraw(null); //Redraw shapes
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            lineThicknessTrackBar.Value++;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            lineThicknessTrackBar.Value--; 
        }

        private void LineThicknessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).SetPenThickness(lineThicknessTrackBar.Value); //Set shape line thickness
            redraw(null); //Redraw shapes
        }

        private void HeightTextbox_TextChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).SetHeight(ShapeHeight); //Set shape height
            redraw(null); //Redraw shapes
        }

        private void WidthTextbox_TextChanged(object sender, EventArgs e)
        {
            ((Shape)internalShape).SetWidth(ShapeWidth); // Set shape width
            redraw(null); //Redraw shapes
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make visible if selected shape is a polygon or star
            label3.Visible = num.Visible = button3.Visible = button11.Visible =
                shapeComboBox.Text == "Polygon" || shapeComboBox.Text == "Star";

            //Change shape
            shapeVersionControl.ChangeShape(ref internalShape, shapeComboBox.Text, Num);
            redraw(null); //Redraw shapes
            
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            //Decrease value in numTextbox (for number of sides)
            if (Num > 6)
                num.Text = (int.Parse(num.Text) - 1).ToString();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            //Increase value in numTextbox (for number of sides)
            if (Num < 12)
                num.Text = (int.Parse(num.Text) + 1).ToString();
            
        }

        private void Button9_Click(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                widthTextbox.Text = (int.Parse(widthTextbox.Text) - 2).ToString();//Decrease value in widthTextbox
            };
            clickTimer.Start();
            
        }
        private void Button10_Click(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                widthTextbox.Text = (int.Parse(widthTextbox.Text) + 2).ToString();//Increase value in widthTextbox
            };
            clickTimer.Start();
            
        }

        private void Button7_Click(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                heightTextbox.Text = (int.Parse(heightTextbox.Text) - 2).ToString(); //Decrease value in heightTextbox
            };
            clickTimer.Start();
            
        }

        private void button8_Click(object sender, MouseEventArgs e)
        { 
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                heightTextbox.Text = (int.Parse(heightTextbox.Text) + 2).ToString(); //Increase value in heightTextbox
            };
            clickTimer.Start();
            
        }

        private void Button9_MouseUp(object sender, MouseEventArgs e)
        {
            clickTimer.Stop();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //Return shape settings to normal
            shapeComboBox.Text = (string)original[0];
            widthTextbox.Text = (string)original[1];
            heightTextbox.Text = (string)original[2];
            lineThicknessTrackBar.Value = (int)original[3];
            lineColourDialog.Color = (Color)original[4];
            fillColourDialog.Color = (Color)original[5];
            fillCheckBox.Checked = (bool)original[6];
            rotateTextBox.Text = (string)original[7];
        }

        private void RotateTextBox_TextChanged(object sender, EventArgs e)
        {
            shapeVersionControl.RotateShape(ref internalShape, RotateAmount);
            redraw(null);
        }

        private void Button12_MouseDown(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                if(RotateAmount >= 2)
                    rotateTextBox.Text = (int.Parse(rotateTextBox.Text) - 2).ToString();  //Decrease value in rotateTextbox
            };
            clickTimer.Start();
            
        }

        private void Button13_MouseDown(object sender, MouseEventArgs e)
        {
            clickTimer = new Timer { Interval = 100 };

            clickTimer.Tick += delegate
            {
                if (RotateAmount <= 364)
                    rotateTextBox.Text = (int.Parse(rotateTextBox.Text) + 2).ToString(); //increase value in rotateTextbox
            };
            clickTimer.Start();
            
        }

        private void HighlightColour_Click(object sender, EventArgs e)
        {
            //Select shape highlight colour
            if (highlightColourDialog.ShowDialog() == DialogResult.OK)
            {
                ((Shape)internalShape).SetHighlightColour(highlightColourDialog.Color);
                redraw(null);
            }
        }

        private void Transform_DragOver(object sender, DragEventArgs e)
        {
            clickTimer.Stop(); // Stop click timer
        }
    }
}
