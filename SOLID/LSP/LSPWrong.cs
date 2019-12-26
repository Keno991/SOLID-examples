using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.WRONG
{
    class Employee
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
                
        public virtual void Work()
        {
            // employee work
        }

        public void CalculatePay()
        {
            // calculation logic
        }
    }

    class Intern : Employee
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public override void Work()
        {
            // intern work
        }
    }
}
