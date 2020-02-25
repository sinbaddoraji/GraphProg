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

            heptagonToolStripMenuItem.Checked = true;
            hepatagonRadioButton.Checked = true;

            canvas1.SelectShape(Canvas.ShapeType.Heptagon);
        }
    }
}
