using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Animal
    {

        // Add four fields to your base class.
        // Add two Properties to your class.
        // Add a constructor to your derived class that includes a call to your base class.
        // Add two methods to your derived classes.
        // Add a method to your base class and use it in both of your derived classes.

        // fields
        private string name;
        private string color;
        private string breed;
        private int shoulderHeight;
        

        // Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int ShoulderHeight
        {
            get { return this.shoulderHeight; }
            set { this.shoulderHeight = value; }
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        // Constructors

        public Animal()
        {
            // default constructor
        }

        public Animal(string name, string color, int shoulderHeight, string breed)
        {
            this.name = name;
            this.color = color;
            this.shoulderHeight = shoulderHeight;
            this.breed = breed;
        }


        // Method ............... ADD


    }
}
