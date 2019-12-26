using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.RIGHT
{
    class Worker
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual void Work()
        {
            // employee work
        }
    }

    class Employee : Worker
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public override void Work()
        {
            // employee work
        }

        public void CalculatePay()
        {
            // calculation logic
        }
    }

    class Intern : Worker
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public override void Work()
        {
            // intern work
        }
    }
}
