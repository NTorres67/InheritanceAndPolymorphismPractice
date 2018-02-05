using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Shape
    {

        // fields
        private int sides;

        // Properties
        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }


        // Constructors
        public Shape()
        {
            // default constructor
        }

        public Shape(int sides)
        {
            this.sides = sides;
        }

        // Mehtods

        

        public class Rectangle : Shape
        {
            private double area;

            public double Area
            {
                get { return this.area; }
                set { this.area = value; }
            }
            
            public Rectangle(double area) // derived class == different type of shape
            {
                this.area = area;
            }

        }


    }
}
