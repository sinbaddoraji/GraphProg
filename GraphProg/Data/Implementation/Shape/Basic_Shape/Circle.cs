using System.Drawing;

namespace GraphProg.Data.Implementation.Shape.Basic_Shape
{
    public class Circle : Shape
    {
        public Circle(Graphics g, Pen p) : base(g, p) { shapeType = "Circle"; }

        public override void Draw(bool highlight)
        {
            Pen pen = highlight ? highLightPen : this.pen;
            
            if (fill)
            {
                g.FillEllipse(fillBrush, Rect);
            }
            else
            {
                g.DrawEllipse(pen, Rect);
            }
        }
    }
}