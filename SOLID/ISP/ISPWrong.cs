using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.WRONG
{
    interface IVehicle
    {
        void Drive();
        void Fly();
    }

    class Mercedes : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("driving");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    class Boeing : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("flying");
        }
    }
}
