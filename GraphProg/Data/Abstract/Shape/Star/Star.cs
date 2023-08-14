using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphProg.Data.Implementation.Shape.Star
{
  
    public abstract class Star : Shape
    {
        protected Star(Graphics g, Pen pen) : base(g, pen) { shapeType = "Star"; }

        protected void DrawStar(int num_points, bool fill = false, bool highlight = false)
        {
            PointF[] points = MakeStarPoints(num_points);

            Matrix m = new Matrix();
            m.RotateAt(RotateAmount, DrawInformation.Center, MatrixOrder.Prepend);
            m.TransformPoints(points);

            this.fill = fill;
            Pen pen = highlight ? highLightPen : this.pen;
            DrawLinesThrough(pen, points);
            if (fill)
            {
                g.FillPolygon(fillBrush, points);
            }
        }

        private PointF[] MakeStarPoints(int num_points)
        {
            PointF[] output = new PointF[2 * num_points];

            float rx = Rect.Width / 2f;
            float ry = Rect.Height / 2f;
            float cx = Rect.X + rx;
            float cy = Rect.Y + ry;

            // Radius for the concave vertices.
            double concave_radius = CalculateConcaveRadius(num_points);

            // Make the points.
            double theta = -Math.PI / 2;
            double dtheta = Math.PI / num_points;

            for (int i = 0; i < num_points; i++)
            {
                output[2 * i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)), 
                    (float)(cy + ry * Math.Sin(theta)));

                theta += dtheta;

                output[2 * i + 1] = new PointF(
                    (float)(cx + rx * Math.Cos(theta) * concave_radius),
                    (float)(cy + ry * Math.Sin(theta) * concave_radius));

                theta += dtheta;
            }

            return output;
        }

        private double CalculateConcaveRadius(int num_points)
        {
            // For really small numbers of points.
            if (num_points < 5)
            {
                return 0.33f;
            }

            // Calculate angles to key points.
            double dtheta = 2 * Math.PI / num_points;

            double theta00 = -Math.PI / 2;
            double theta01 = theta00 + dtheta * 2;
            double theta10 = theta00 + dtheta;
            double theta11 = theta10 - dtheta * 2;

            // Find the key points.
            PointF pt00 = new PointF((float)Math.Cos(theta00), (float)Math.Sin(theta00));
            PointF pt01 = new PointF((float)Math.Cos(theta01), (float)Math.Sin(theta01));
            PointF pt10 = new PointF((float)Math.Cos(theta10), (float)Math.Sin(theta10));
            PointF pt11 = new PointF((float)Math.Cos(theta11), (float)Math.Sin(theta11));

            PointF[] keyPoints = new PointF[] { pt00, pt01, pt10, pt11 };

            // See where the segments connecting the points intersect.
            PointF intersection = GetIntersection(keyPoints);

            //return the calculated distance between the point of intersection and the center of the drawing
            return Math.Sqrt(intersection.X * intersection.X + intersection.Y * intersection.Y);
        }

        private PointF GetIntersection(PointF[] mP)
        {
            // Get the segments' parameters.
            float dx12 = mP[1].X - mP[0].X;
            float dy12 = mP[1].Y - mP[0].Y;

            float dx34 = mP[3].X - mP[2].X;
            float dy34 = mP[3].Y - mP[2].Y;

            // Solve for t1 and t2
            float denominator = (dy12 * dx34 - dx12 * dy34);

            float t1 = ((mP[0].X - mP[2].X) * dy34 + (mP[2].Y - mP[0].Y) * dx34) / denominator;

            // Find the point of intersection.
            return new PointF(mP[0].X + dx12 * t1, mP[0].Y + dy12 * t1);
        }
    }
}
