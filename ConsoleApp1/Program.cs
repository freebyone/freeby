using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите количество картошки, потребление картошки и количество гнилой картошки");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double r = 0;
            double w = 0;
            do
            {
                r = (a * e) / 10;
                a = a - ((1 + w / 10) * b) - r;
                w++;
            }
            while (a <= d);
            if (w >= 10) 
            {
                Console.WriteLine(w);
            }
            else
                Console.WriteLine("Больше 10 месяцев");
        }
    }
}
