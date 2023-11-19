using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            car Ford = new car();
            Ford.name = "Mustang";
            Ford.year = 2021;
            Ford.color = "white";
            Ford.maxSpeed = 100;
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);
            Ford.fullThrottle();
            car Opel = new car();
            Opel.name = "Astra";
            Opel.year = 2020;
            Opel.color = "blue";
            Opel.maxSpeed = 120;
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.color);
            Opel.fullThrottle();
            Console.ReadKey();
        }
    }
}
