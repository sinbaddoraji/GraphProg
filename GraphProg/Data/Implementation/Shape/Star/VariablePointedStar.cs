using System.Drawing;

namespace GraphProg.Data.Implementation.Shape.Star
{
    public class VariablePointedStar : Star
    {
        //Number of points on the star
        int pointNumber;

        public int PointNumber => pointNumber;

        public VariablePointedStar(Graphics g, Pen p, int numberOfPoints) : base(g, p) 
        {
            SetStarPoints(numberOfPoints);
        }
        
        public VariablePointedStar(int numberOfPoints) : this(null, null, numberOfPoints) { }

        public void InitalizeDrawSettings(Graphics g, Pen p)
        {
            SetGraphics(g);
            SetPen(p);
        }

        public void SetStarPoints(int num)
        {
            //Set number of points on the star
            pointNumber = num;
        }

        public override void Draw(bool highlight)
        {
            DrawStar(pointNumber, fill, highlight);
        }
    }
}