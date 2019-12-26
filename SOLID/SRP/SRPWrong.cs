using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.WRONG
{
    class Employee
    {
        public void CalculatePay()
        {
            //business logic here
        }

        public Employee Save(Employee employee)
        {
            //persistance here

            return default;
        }
    }
}
