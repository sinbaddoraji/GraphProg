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
    public partial class Settings : Form
    {
        private readonly Canvas canvas;
        private readonly ColorDialog lineColour = new ColorDialog();
        private readonly ColorDialog fillColour = new ColorDialog();
        private readonly ColorDialog highlightColour = new ColorDialog();

        public Settings(Canvas canvas)
        {
            InitializeComponent();
            this.canvas = canvas;

            lineColour.Color = canvas.LineColour;
            lineColour.Color = canvas.LineColour;
            lineColour.Color = canvas.LineColour;
            trackBar1.Value = (int)canvas.LineSize;

            fillColourDisplay.BackColor = fillColour.Color;
            highlightColourDisplay.BackColor = highlightColour.Color;

            pictureBox1.Invalidate();
        }

        private void LineColour_Click(object sender, EventArgs e)
        {
            if(lineColour.ShowDialog() == DialogResult.OK)
            {
                canvas.SetLineColour(lineColour.Color);
                pictureBox1.Invalidate();
            }
        }

        private void FillColour_Click(object sender, EventArgs e)
        {
            if (fillColour.ShowDialog() == DialogResult.OK)
            {
                canvas.SetFillColour(fillColour.Color);
                fillColourDisplay.BackColor = fillColour.Color;
                pictureBox1.Invalidate();
            }
        }

        private void HighlightColour_Click(object sender, EventArgs e)
        {
            if (highlightColour.ShowDialog() == DialogResult.OK)
            {
                canvas.SetLineColour(highlightColour.Color);
                highlightColourDisplay.BackColor = highlightColour.Color;
                pictureBox1.Invalidate();
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            canvas.SetlineWidth(trackBar1.Value);
            pictureBox1.Invalidate();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int y = pictureBox1.Height / 2;
            Pen p = new Pen(new SolidBrush(lineColour.Color), trackBar1.Value);
            e.Graphics.DrawLine(p, 0, y, pictureBox1.Width, y);
        }
    }
}
