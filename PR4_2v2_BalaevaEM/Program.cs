using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//Вариант 2, Балаева Елизавета 11ИС-133
namespace PR4_2v2_BalaevaEM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =-1;

            Transport bmw = new Transport("BMW X7", 245, 835, 2019, "США", 1);
            bmw.Passport();



            Transport lexus = new Transport("Lexus UX", 190, 445, 2019, "Япония", 2);
            lexus.Passport();
            lexus = lexus - 2; //изменение года, логическая бинарная операция
            lexus.Passport();



            Transport volvo = new Transport("Volvo XC60", 200, 585, 2015, "Швеция", 3);
            volvo.Passport();
            volvo = 5 + volvo; // изменение номера на 5, логическая бинарная операция
            volvo.Passport();


            Transport ford = new Transport("Ford", "США", 4);
            ford.Passport();
            ford++;//унарная операция
            ford.Passport();

            Transport mercedes = new Transport("Mercedes-Benz", 318, 715, 2018, "Германия", 5);
            mercedes.Passport();
            int i = mercedes;//неявное преобразование
            mercedes = (Transport)245;//явное преобразование
            mercedes.Passport();

            Passenger ps = new Passenger("Lada", 160, 350, 10);
            ps.Passport();

            Moto mot = new Moto("Suzuky", 200, 60, 11, "yes");
            mot.Think();

            Truck mers = new Truck("Mers", 153, 12, "yes");
            mers.Tru();

            const int x = 5;
            int a = 150;
            int b = 250;
            Truck[] stado = new Truck[x];

            stado[0] = new Truck("lix", 154, 13, "yes");
            stado[1] = new Truck("mers", 300, 14, "no");
            stado[2] = new Truck("toyota", 254, 15, "no");
            stado[3] = new Truck("japan", 189, 16, "yes");
            stado[4] = new Truck("lexus", 146, 17, "yes");
           

            foreach (Truck elem in stado) elem.Tru();
           

            //выбор транспорта по номеру
            for (; n != 0;)
            {
                Console.WriteLine("Желаете изменить свойства транспорта?\n1-да\n2-нет");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Укажите номер транспорта");
                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1: bmw.Carryings(); break;
                        case 2: lexus.Carryings(); break;
                        case 3: volvo.Carryings(); break;
                        case 4: ford.Carryings(); break;
                        case 5: mercedes.Carryings(); break;
                        default: Console.WriteLine("Такого транспорта не существует"); break;
                    }
                }
                else if (n == 0 || n == 2) n = 0;
                else
                    Console.WriteLine("Ошибка! Попробуйте снова!");
            } //Выбор транспорта с которым будем работать

            Console.WriteLine("Press any key to close");



          

            Console.ReadKey();

        }
    }
}
