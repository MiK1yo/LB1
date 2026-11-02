using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Mar = "Жигули";
            car.Nom = "Т144ТО";
            car.Pr = 10350;
            car.show();
            double d = car.srpr();
            Console.WriteLine($"Среднегодовой пробег = {d} км/г.");
            Console.ReadKey();
        }

        class Car
        {
            // поля
            private string mar;
            private string nom;
            private int pr;

            // свойства - доступ к полям класса
            public string Mar
            {
                get { return mar; }
                set { mar = value; }
            }
            public string Nom
            {
                get { return nom; }
                set { nom = value; }
            }
            public int Pr
            {
                get { return pr; }
                set
                {
                    if (value >= 0) pr = value;
                }
            }
            // Конструкторы
            public Car()
            {
                mar = "";
                nom = "";
                pr = 0;
            }
            public Car(string m, string n, int p)
            {
                mar = m;
                nom = n;
                pr = p;
            }
            // Вычислительные методы
            public double srpr()
            {
                double rs = pr / 2;
                return rs;
            }
            public void show()
            {
                Console.WriteLine($"Автомобиль: марка = {Mar}, номер = {Nom}, пробег = {Pr}");
                return;
            }
        }
    }
}
