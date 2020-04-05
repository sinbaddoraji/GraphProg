using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProg
{
    public class ShapeVersionControl
    {
        private readonly List<List<Shape>> Drawings = new List<List<Shape>>();

        int backSteps = 0;

        int Index => Drawings.Count - backSteps - 1;

        public ShapeVersionControl()
        {
            Drawings.Add(new List<Shape>());
        }

        public void Undo()
        {
            if(Drawings.Count - backSteps > 1)
            backSteps++;
        }

        public void Redo()
        {
            if(backSteps > 0)
            backSteps--; 
        }

        public void PerformAction(List<Shape> resultingDrawing)
        {
            if(backSteps != 0)
            {
                Drawings.RemoveRange(Drawings.Count - backSteps, backSteps);
                backSteps = 0;
            }
            Drawings.Add(resultingDrawing);
        }

        public List<Shape> GetShapeList()
        {
            return Drawings.Count == 0 ? new List<Shape>() : Drawings[Index];
        }

        public void ChangeShape(ref Shape shape, string to, int num)
        {
            int index = GetShapeList().IndexOf(shape);

            List<Shape> singleDrawing = new List<Shape>();
            singleDrawing.AddRange(Drawings[Index]);

            DrawInformation dI = shape.DrawInformation;
            int rA = shape.RotateAmount;

            if (to == "Square")
            {
                singleDrawing[index] = new Square(shape.Graphics, shape.Pen);
            }

            if (to == "Circle")
            {
                singleDrawing[index] = new Circle(shape.Graphics, shape.Pen);
            }

            if (to == "RightAngledTriangle")
            {
                singleDrawing[index] = new RightAngledTriangle(shape.Graphics, shape.Pen);
            }

            if (to == "Triangle")
            {
                singleDrawing[index] = new Triangle(shape.Graphics, shape.Pen);
            }

            if (to == "Pentagon")
            {
                singleDrawing[index] = new Pentagon(shape.Graphics, shape.Pen);
            }

            if (to == "Diamond")
            {
                singleDrawing[index] = new Diamond(shape.Graphics, shape.Pen);
            }

            if (to == "Polygon")
            {
                singleDrawing[index] = new VariableSidedPolygon(shape.Graphics, shape.Pen, num);
            }

            if (to == "Star")
            {
                singleDrawing[index] = new VariablePointedStar(shape.Graphics, shape.Pen, num);
            }

            shape = singleDrawing[index];

            singleDrawing[index].SetDrawLocationInformation(dI);
            singleDrawing[index].RotateAmount = rA;
            Drawings.Add(singleDrawing);
        }

        public void RotateShape(ref Shape shape, int rotateAmount)
        {
            List<Shape> singleDrawing = new List<Shape>();
            singleDrawing.AddRange(Drawings[Index]);
            Drawings.Add(singleDrawing);

            int index = GetShapeList().IndexOf(shape);
            singleDrawing[index].RotateAmount = rotateAmount;
        }

        public void AddShape(Shape shape)
        {
            List<Shape> singleDrawing = new List<Shape>();
            singleDrawing.AddRange(Drawings[Index]);
            singleDrawing.Add(shape);

            if (backSteps > 0)
            {
                Drawings.RemoveRange(Drawings.Count - backSteps, backSteps);
                backSteps = 0;
            }

            Drawings.Add(singleDrawing);
        }

        public void RemoveShape(List<Shape> shapes)
        {
            List<Shape> singleDrawing = new List<Shape>();
            singleDrawing.AddRange(Drawings[Index]);

            foreach (Shape shape in shapes)
            {
                singleDrawing.Remove(shape);
            }

            if (backSteps > 0)
            {
                Drawings.RemoveRange(Drawings.Count - backSteps, backSteps);
                backSteps = 0;
            }

            Drawings.Add(singleDrawing);
        }

    }
}
