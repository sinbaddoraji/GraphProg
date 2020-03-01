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
    public partial class SelectShapes : Form
    {
        List<Shape> shapes;
        public List<Shape> internalShapes = new List<Shape>();

        Canvas.methodPointer redraw;

        public SelectShapes(List<Shape> shapes, Canvas.methodPointer redraw)
        {
            InitializeComponent();
            this.redraw = redraw;

            this.shapes = shapes;
            for (int i = 0; i < shapes.Count; i++)
            {
                listView1.Items.Add((i + 1).ToString());
                listView1.Items[i].Checked = true;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            internalShapes.Clear();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                var item = listView1.Items[i];
                if (item.Checked) internalShapes.Add(shapes[i]);
            }

            if (listView1.CheckedItems.Count == 0)
            {
                redraw(null);
            }
            else
            {
                redraw(internalShapes);
            }

            
        }
    }
}
