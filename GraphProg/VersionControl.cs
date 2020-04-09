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
        private readonly List<List<Shape>> Drawings = new List<List<Shape>>(); // List containing a list of shapes representing each version of the drawing

        int backSteps = 0; //How many times drawing has been undone

        int Index => Drawings.Count - backSteps - 1; //Index of current drawing

        public ShapeVersionControl()
        {
            Drawings.Add(new List<Shape>());//Add empty list to drawings
        }

        public void Undo()
        {
            //Go to previous list of shapes
            if(Drawings.Count - backSteps > 1)
            backSteps++;
        }

        public void Redo()
        {
            //Goto next list of shapes
            if(backSteps > 0)
            backSteps--; 
        }

        public List<Shape> GetShapeList()
        {
            //Return list of drawings
            return Drawings.Count == 0 ? new List<Shape>() : Drawings[Index];
        }

        public void ChangeShape(ref Shape shape, string to, int numberOfSides)
        {
            int index = GetShapeList().IndexOf(shape); //Get index of shape to be changed

            //Create new list of shapes that will be used for versuon control
            List<Shape> singleDrawing = new List<Shape>();
            singleDrawing.AddRange(Drawings[Index]);

            //Get draw information of old shape
            DrawInformation dI = shape.DrawInformation;
            int rA = shape.RotateAmount;

            if (to == "Square")
            {
                //Convert shape to square
                singleDrawing[index] = new Square(shape.Graphics, shape.Pen);
            }
            else if (to == "Circle")
            {
                //Convert shape to Circle
                singleDrawing[index] = new Circle(shape.Graphics, shape.Pen);
            }
            else if (to == "RightAngledTriangle")
            {
                //Convert shape to RightAngledTriangle
                singleDrawing[index] = new RightAngledTriangle(shape.Graphics, shape.Pen);
            }
            else if (to == "Triangle")
            {
                //Convert shape to Triangle
                singleDrawing[index] = new Triangle(shape.Graphics, shape.Pen);
            }
            else if (to == "Pentagon")
            {
                //Convert shape to Pentagon
                singleDrawing[index] = new Pentagon(shape.Graphics, shape.Pen);
            }
            else if (to == "Diamond")
            {
                //Convert shape to Diamond
                singleDrawing[index] = new Diamond(shape.Graphics, shape.Pen);
            }
            else if (to == "Polygon")
            {
                //Convert shape to Polygon
                singleDrawing[index] = new VariableSidedPolygon(shape.Graphics, shape.Pen, numberOfSides);
            }
            else if (to == "Star")
            {
                //Convert shape to VariablePointedStar
                singleDrawing[index] = new VariablePointedStar(shape.Graphics, shape.Pen, numberOfSides);
            }
            else return;

            //Give new shape old shape properties
            shape = singleDrawing[index];
            singleDrawing[index].SetDrawLocationInformation(dI);
            singleDrawing[index].RotateAmount = rA;

            //Remove drawings after current index
            if (backSteps > 0)
            {
                Drawings.RemoveRange(Drawings.Count - backSteps, backSteps);
                backSteps = 0;
            }

            //Add new drawing
            Drawings.Add(singleDrawing);
        }

        public void RotateShape(ref Shape shape, int rotateAmount)
        {
            //Rotate shape and create new shape list 

            int index = GetShapeList().IndexOf(shape);
            GetShapeList()[index].RotateAmount = rotateAmount;
        }

        public void AddShape(Shape shape)
        {
            //Add shape to shape list 
            List<Shape> singleDrawing = new List<Shape>();
            singleDrawing.AddRange(Drawings[Index]);
            singleDrawing.Add(shape);

            //Remove drawings after current index
            if (backSteps > 0)
            {
                Drawings.RemoveRange(Drawings.Count - backSteps, backSteps);
                backSteps = 0;
            }

            Drawings.Add(singleDrawing);
        }

        public void RemoveShape(List<Shape> shapes)
        {
            //Remove shape from shape list 
            List<Shape> singleDrawing = new List<Shape>();
            singleDrawing.AddRange(Drawings[Index]);

            foreach (Shape shape in shapes)
            {
                singleDrawing.Remove(shape);
            }

            //Remove drawings after current index
            if (backSteps > 0)
            {
                Drawings.RemoveRange(Drawings.Count - backSteps, backSteps);
                backSteps = 0;
            }

            Drawings.Add(singleDrawing);
        }

    }
}
