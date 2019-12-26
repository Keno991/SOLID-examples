using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.RIGHT
{
    interface IAirplane
    {
        void Fly();
    }

    interface ICar
    {
        void Drive();
    }

    class Mercedes : ICar
    {
        public void Drive()
        {
            Console.WriteLine("driving");
        }
    }

    class Boeing : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("flying");
        }
    }
}
