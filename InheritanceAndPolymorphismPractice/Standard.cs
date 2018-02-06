using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Standard : Membership
    {
        // fields
        // invisible - creats fields behind seens

        // Properties
        public int Cost { get; set; } // writes out your "get and/or set" properties
                                        // works only when fields are not defined above
                                        // pros = faster, cleaner, 
                                        // cons = lack of readability, unable to play with fields

        
        // Constructors
        public Standard()
        {
            //default constructor
        }

        public Standard(int cost)
        {
            Cost = cost;
        }


        // Methods
        public override void Activate()
        {
            //base.Activate(); ==> automatically populates (does everything in base method  **delete out**
            if (IsActive == false) // copied from base method - capitalize the "i"
            {
                IsActive = true;
                Console.WriteLine("Your standard membership has been activated."); // added "standard"
            }
            else
            {
                Console.WriteLine("Your standard membership is already active."); // added "standard"
            }
        }

    }
}
