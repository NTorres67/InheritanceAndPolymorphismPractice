using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Dishwasher : Appliance // red squiggly under "Dishwasher" until method is added
    {
        // fields 
        // invisible


        // Properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }


        // Constructors
        public Dishwasher()
        {
            // default constructor
        }

        public Dishwasher(double decibelLevel, bool hasHeatDry)
        {
            this.DecibelLevel = decibelLevel;
            this.HasHeatDry = hasHeatDry;
        }


        // Mehtods
        public override void Work()
        {
            Console.WriteLine("I was your dishes.");
            Console.WriteLine("wash, wash, wash");
        }

    }
}
