using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphProg.Data.Implementation.Shape;

namespace GraphProg
{
    public partial class SelectShapes : Form
    {
        private readonly List<Shape> shapes; //Actual selected shapes
        public List<Shape> internalShapes = new List<Shape>(); //internal selected shapes
        private readonly Canvas canvas;

        public SelectShapes(List<Shape> shapes, Canvas canvas)
        {
            InitializeComponent();
            this.canvas = canvas;
            this.shapes = shapes;

            //Add shape to list view
            for (int i = 0; i < shapes.Count; i++)
            {
                listView1.Items.Add((i + 1).ToString() + " : " + shapes[i].shapeType);
                listView1.Items[i].Checked = true;
            }
        }

        private void ListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            internalShapes.Clear();

            //Add shapes to selected shape list
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                var item = listView1.Items[i];
                if (item.Checked)
                {
                    internalShapes.Add(shapes[i]);
                }
            }

            if (listView1.CheckedItems.Count == 0)
            {
                canvas.Redraw(null); //Redraw all shapes
            }
            else
            {
                canvas.Redraw(internalShapes); //Redraw shapes highlighting selected shapes
            }
        }

        private void TransformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(internalShapes.Count > 1)
            {
                MessageBox.Show("Only the first shape will be transfomed");
            }

            //Create transform form for selected shape
            using (Transform t = new Transform(canvas.Redraw,canvas.shapeVersionControl))
            {
                t.SelectShape(internalShapes[0]);
                t.ShowDialog();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = MessageBox.Show("Are you sure you want to delete Selected shapes?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(m == DialogResult.Yes)
            {
                for (int i = 0; i < internalShapes.Count; i++)
                {
                    //Remove shapes from list view
                    listView1.Items.RemoveAt(shapes.IndexOf(internalShapes[i]));
                    //remove shape from shape list
                    shapes.Remove(internalShapes[i]);
                }
                canvas.DeleteShapes(internalShapes); //Delete shapes

                if (shapes.Count == 0)
                {
                    Close();//Close shapes if no shapes are left
                }
            }
        }
    }
}
