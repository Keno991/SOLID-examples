using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.RIGHT
{
    class Employee
    {
        public void CalculatePay()
        {
            //business logic here
        }
    }

    class EmployeeRepository
    {
        public Employee Save(Employee employee)
        {
            //persistance here

            return default;
        }
    }
}
