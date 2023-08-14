using System.Drawing;

namespace GraphProg.Data.Implementation.Shape.Polygon
{
    public class VariableSidedPolygon : Polygon
    {
        private int sides;
        public int Sides => sides;

        public VariableSidedPolygon(Graphics g, Pen p, int sides) : base(g, p)
        {
            SetSides(sides);
        }

        public VariableSidedPolygon(int sides) : this(null, null, sides) { }

        public void InitalizeDrawSettings(Graphics g, Pen p)
        {
            SetGraphics(g);
            SetPen(p);
        }

        public void SetSides(int num)
        {
            sides = num; //Set number of sides
        }

        public override void Draw(bool highlight)
        {
            DrawPolygon(sides, highlight); //Draw poligon with x number of sides
        }
    }
}