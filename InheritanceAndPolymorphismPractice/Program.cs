using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // To call methods and Properties of a class in the Program class,
            // yu have to create (instantiate) an object from the class.

            // =============================== APPLIANCE ==============================

            Microwave myMicrowave = new Microwave(1000, "Samsung");
            Dishwasher myDishwasher = new Dishwasher(0, true);

            myMicrowave.Work();

            myDishwasher.Work();




            // ================================ Membership ===============================
            
            //Standard gymMember1 = new Standard(100); // "100" is the cost of the membership
            //VIP gymMember2 = new VIP();

            //gymMember1.Activate();
            //gymMember2.Activate();

            

            // =========================================== Wizard =================

            //Wizard wizardOne = new Wizard(true);

            //HogwartsStudent longbottom = new HogwartsStudent(7);

            //DeathEater malfoy = new DeathEater();

            //wizardOne.MakeMagic();
            //longbottom.MakeMagic();
            //malfoy.MakeMagic();
            
        }
    }
}
