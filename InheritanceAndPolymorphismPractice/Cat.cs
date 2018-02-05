using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Cat : Animal
    {
        // fields
        private bool sharpClaws;

        //Properties
        public bool SharpClaws
        {
            get { return this.sharpClaws; }
            set { this.sharpClaws = value; }
        }

        // Constructors
        public Cat()
        {
            // default constructor
        }

        public Cat(bool sharpClaws)
        {
            this.sharpClaws = sharpClaws;
        }

        // Method
        public string Scratch()
        {
            if (sharpClaws == false)
            {
                sharpClaws = true;
                return "Please pick me up.";

            }
            else if (sharpClaws == true)
            {
                sharpClaws = false;
                return "Please put me down.";
            }
            else
            {
                return "";
            }


        }

    }
}
