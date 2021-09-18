using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_2v2_BalaevaEM
{
    class Transport
    {


        public Transport()
        {
            this.marka = "No marka";
            this.maxSpeed = 200; //средняя максимальная скорость
            this.carrying = 0; // средняя грузоподъёмность
            this.year = 2019;
            this.country = "No cantry";
            this.number = 0;
        }
        public Transport(string marka) : this()
        {
            this.marka = marka;
           
        }

        public Transport(string marka, string country) : this()
        {
            this.marka = marka;
            this.country = country;
        }
        public Transport(string marka, string country, int number) : this()
        {
            this.marka = marka;
            this.country = country;
            this.number = number;
        }

        public Transport(string marka, int maxSpeed, int carrying, int year, string country, int number)
        {
            this.marka = marka;
            this.maxSpeed = maxSpeed;
            this.carrying = carrying;
            this.year = year;
            this.country = country;
            this.number = number;
        }


        public void Passport()
        {
            //паспортные данные автомобиля
            Console.WriteLine("Марка автомобиля: {0};\n Максимальная скорость: {1}; Грузоподъёмность: {2}; Год:{3}; Страна производителя: {4}; Интервал: {5} Номер: {6}",
               Marka, MaxSpeed, Carrying, Year, Country, interval(), Number);
        }
        //для унарных
        public void Passport(string m)
        {
            Console.WriteLine("У {0} \n  Максимальная скорость: {1}; Грузоподъёмность: {2}; Год:{3}; Страна производителя: {4}; Интервал: {5}; Серийный Номер: {6}",
                Marka, MaxSpeed, Carrying, Year, Country, interval(), Number, m);
        }
        //для бинарных
        public void Passport(string m, int k)
        {
            for (int i = 0; i < k; i++)
                Console.WriteLine("У {0} \n  Максимальная скорость: {1}; Грузоподъёмность: {2}; Год:{3}; Страна производителя: {4}; Интервал: {5}; Серийный Номер: {6}",
                Marka, MaxSpeed, Carrying, Year, Country, interval(), Number, m);
        }
        //ОПЕРАЦИИ
        //унарные операции
        public static Transport operator ++(Transport m)
        {
            Transport transport = new Transport(m.marka);
            transport.carrying = m.carrying + 20;//если не хватает грузоподъемности, то можно прибавить на 20 (приблизительная грузоподъемность)
            return transport;
        }
        public static Transport operator --(Transport m)
        {
            Transport transport = new Transport(m.marka);//убавление номера возможно только на 1
            transport.carrying = m.carrying -1;
            return transport;
        }
        // бинарные операции
        public static Transport operator +(int k, Transport m )
        {
            Transport transport = new Transport(m.marka);
            transport.number = k + m.number  ;//перемещение номера 
            return transport;
        }
        public static Transport operator -(Transport m, int k )
        {
            Transport transport = new Transport(m.marka);
            transport.year = m.year - k ; //изменение года
            return transport;
        }
       
      


        //преобразование вида

        public static implicit operator int(Transport m)
        {
            return m.maxSpeed; //неявное преобразование
        }
      
        public static explicit operator Transport(int h)
        {
            return new Transport("FromInt", h, 100,2015,"Германия",6);  //явное преобразование
        }

        public void Carryings()
        {
            //увеличить или уменьшить максимальную скорость 
            Console.WriteLine("1 - увеличить скорость\n2 - уменьшить скорость");
            a = Convert.ToInt32(Console.ReadLine());
           
            if (a == 1)
            {
                Console.WriteLine("Увеличить на: ");
                a = Convert.ToInt32(Console.ReadLine());
                MaxSpeed += a;
                Console.WriteLine("Скорость увеличена на " + MaxSpeed);
                
            }
            else if (a == 2)
            {
                Console.WriteLine("Уменьшить на: ");
                a = Convert.ToInt32(Console.ReadLine());
                MaxSpeed -= a;
                Console.WriteLine("Скорость уменьшена на " + MaxSpeed);
                

            }
        }
        public string interval()
        {
            //интервал грузоподъемности
           if (carrying >= 700 && carrying <= 1000) return "Грузоподъемность в интервале";
            else
                return "Грузоподъемность вне интервала";

        }
        //методы, свойства
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 300) maxSpeed = 300; // до 300км/ч легкового авомобиля 
                else if (value < 0) maxSpeed = 0;
                else maxSpeed = value;
            }
        }
        public int Carrying
        {
            get { return carrying; }
            set
            {
                if (value > 1000) carrying = 1000; //грузоподъемность до 1000 кг
                else if (value < 50) carrying = 50; //т.к. там есть хотя бы 1 человек
                else carrying = value;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 2019) year = 2020;
                else if (value < 2010) year = 2000; //2000x годов в диапазоне 2000 до 2009
                else year = value;
            }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
      
         //поля
        private int number;//номер транспорта
        private string marka; //марка автомобиля
        private int maxSpeed; // максимальная скорость
        private int carrying; // грузоподъемность
        private int year; //год производства
        private string country; //страна производства
        private int a = -1;

        
    }
}
