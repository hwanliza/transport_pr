using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_2v2_BalaevaEM
{
    class Truck : Transport
    {
        public string Pri { get; set; } //прицеп
        public Truck(string marka, int carrying, int number, string pri) : base(marka)
        {
            Number = number;
            Carrying = carrying;
            Pri = pri;
        }
        public void Tru()
        {
            if (Pri == "yes")
            {
                Carrying = Carrying * 2;
                Console.WriteLine("Марка грузовика: {0};\n  Грузоподъёмность: {1}; Номер: {2}; Прицеп: {3}",
               Marka, Carrying, Number, Pri);
            }
            else if (Pri == "no")
            {
                Carrying = Carrying;
                Console.WriteLine("Марка мотоцикла: {0};\n  Грузоподъёмность: {1}; Номер: {2}; Прицеп: {3}",
               Marka, Carrying, Number, Pri);
            }
        }
    }
}
