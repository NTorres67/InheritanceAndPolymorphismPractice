using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Membership
    {
        // fields
        private int memberID;
        private bool isActive;


        // Properties
        public int MemberID
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }


        // Constructors
        public Membership()
        {
            // default constructor
        }

        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID;
            this.isActive = isActive;
        }


        // Method
        public virtual void Activate() // activate membership
        {
            if(isActive == false) // if it is this change false to true
            {
                isActive = true;
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active.");
            }



        }




    }
}
