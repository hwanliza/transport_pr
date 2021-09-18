using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_2v2_BalaevaEM
{
    class Moto : Transport
    {
        public string Kol { get; set; }
        public Moto(string marka, int maxSpeed, int carrying, int number, string kol) : base(marka)
        {
            MaxSpeed = maxSpeed;
            Carrying = carrying;
            Number = number;
            Kol = kol; //коляска
        }
        public void Think()
        {
            if (Kol == "yes")
            {
                Carrying = Carrying;
                Console.WriteLine("Марка мотоцикла: {0};\n Максимальная скорость: {1}; Грузоподъёмность: {2}; Номер: {3}; Коляска: {4}",
               Marka, MaxSpeed, Carrying, Number, Kol);
            }
            else if (Kol == "no")
            {
                Carrying = 0;
                Console.WriteLine("Марка мотоцикла: {0};\n Максимальная скорость: {1}; Грузоподъёмность: {2}; Номер: {3}; Коляска: {4}",
               Marka, MaxSpeed, Carrying, Number, Kol);
            }
        }
        new public void Passport()
        {
            Console.WriteLine("Марка мотоцикла: {0};\n Максимальная скорость: {1}; Грузоподъёмность: {2}; Номер: {3}; Коляска: {4}",
                Marka, MaxSpeed, Carrying, Number, Kol);
        }
    }
}
