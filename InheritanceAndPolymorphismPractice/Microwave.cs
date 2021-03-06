﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Microwave : Appliance
    {
        // fields
        private int watts;
        private string brand;


        // Properties
        public int Watts
        {
            get { return this.watts; }
            set { this.watts = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }


        // Constructors
        public Microwave()
        {
            // default constructor
        }

        public Microwave(int watts, string brand)
        {
            this.watts = watts;
            this.brand = brand;
        }


        // Methods
        public override void Work()
        {
            //throw new NotImplementedException(); // autocomplete - do not want to throw an exception <==> delete

            Console.WriteLine("I emit radioactive waves.");
            Console.WriteLine("It heats up your food.");
        }



    }
}
