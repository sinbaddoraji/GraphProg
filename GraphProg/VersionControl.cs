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
