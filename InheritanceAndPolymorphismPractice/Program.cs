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
            // To call methods and Properties of a class in the Program calss,
            // yu have to create (instantiate) an object from the class.


            // ================================ Membership ===============================


            Standard gymMember1 = new Standard(100); // "100" is the cost of the membership
            VIP gymMember2 = new VIP();

            gymMember1.Activate();
            gymMember2.Activate();













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
