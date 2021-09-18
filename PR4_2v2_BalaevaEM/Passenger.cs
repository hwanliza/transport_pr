using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PR4_2v2_BalaevaEM
{
    class Passenger : Transport
    {
        public Passenger( string marka, int maxSpeed, int carrying, int number) : base(marka)
        {
            MaxSpeed = maxSpeed;
            Carrying = carrying;
            Number = number;
        }
        new public void Passport()
        {
            Console.WriteLine("Марка автомобиля: {0};\n Максимальная скорость: {1}; Грузоподъёмность: {2}; Номер: {3}",
               Marka, MaxSpeed, Carrying, Number);
        }
    }

}

