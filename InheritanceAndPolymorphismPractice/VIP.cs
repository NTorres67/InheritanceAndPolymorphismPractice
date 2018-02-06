using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class VIP : Membership
    {
        // fields
        // invisible


        // Proberties
        public bool IsSwanky { get; set; } // creating field behind the scenes for "private bool isSwanty"


        // Constructors
        public VIP()
        {
            // default constructor
        }

        public VIP(bool isSwanky) // "isSwanky" has nothing to do with "private bool isSwanky" in field 
                                  // completely different variable with the same name (convention)
        {
            this.IsSwanky = isSwanky;
            // "IsSwanky" reflects Property, "isSwanky" represents the parameter"
            // "isSwanky" is now the amount of "IsSwanky"
        }


        // Methods
        public override void Activate()
        {
            IsSwanky = true; // when activated "IsSwanky" gets set to true
            
            if (IsActive == false) 
            {
                IsActive = true;
                Console.WriteLine("You are now a big deal.");
            }
            else
            {
                Console.WriteLine("You're already a big deal");

            }
        }




    }
}
