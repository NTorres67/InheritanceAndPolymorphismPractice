using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Dog : Animal
    {
        // ** LOOK AT BASE CONSTRUCTOR EXAMPLE SLIDE **

        // fields
        private bool weight;
        
        
        // Properties
        public bool Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        
        // Constructors

        public Dog()
        {
            // default constructor
        }

        public Dog(bool weight)
        {
            this.Weight = weight;
        }


        // Methods
        
        public string CanCarry()
        {
            if (weight == false)
            {
                weight = true;
                return "Please pick me up.";

            }
            else if (weight == true)
            {
                weight = false;
                return "Please put me down.";
            }
            else
            {
                return "";
            }


        }
    }
}
