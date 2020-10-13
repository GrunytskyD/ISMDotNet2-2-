using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значення m");
            double numberm = double.Parse(Console.ReadLine());
            Console.WriteLine("Значення n");
            double numbern = double.Parse(Console.ReadLine());
            double z1  = numberm * numbern;
            double z2  =numberm/numbern;
            Console.WriteLine($"(z1){ z1}");
            Console.WriteLine($"(z2){z2}");
        }
    }
}
