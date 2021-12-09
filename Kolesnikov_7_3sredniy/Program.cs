using System;

namespace Kolesnikov_7_3sredniy
{
    class Program
    {
        struct Car
        {
            public string marka;
            public string proizvoditel;
            public string type;
            public string year;
            public string dateofreg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество машин:");
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Введите марку"+(i+1)+"машины");
                cars[i].marka = Console.ReadLine();
                Console.WriteLine("Введите производителя:");
                cars[i].proizvoditel = Console.ReadLine();
                Console.WriteLine("Введите тип машины:");
                cars[i].type = Console.ReadLine();
                Console.WriteLine("Введите год выпуска машины:");
                cars[i].year = Console.ReadLine();
                Console.WriteLine("Введите дату регистрации машины:");
                cars[i].dateofreg = Console.ReadLine();
            }
            foreach  (Car item in cars)
            {
                string[] dmy = item.dateofreg.Split(",");
                int day = int.Parse(dmy[0]);
                int month = int.Parse(dmy[1]);
                int year = int.Parse(dmy[2]);
                int dayNow = DateTime.Now.Day;
                int monthNow = DateTime.Now.Month;
                int yearNow = DateTime.Now.Year;
                if (((yearNow - year >16)&&(month <= monthNow)&&(day>dayNow))||(year == yearNow));
                {
                    Console.WriteLine(item.marka + "," + item.proizvoditel + "," + item.type +
                       "," + item.year + "," + item.dateofreg);
                }
            }
        }
    }
}
