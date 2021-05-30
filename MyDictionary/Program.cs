using System;
using System.Collections.Generic;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cars = new MyDictionary<int, string> ();

            cars.Add(1, "BMW");
            cars.Add(2, "Mercedes");
            cars.Add(3, "Audi");
            cars.Add(4, "Tofaş");
            cars.Add(5, "Volkswagen");

            Console.WriteLine("Total car brand: " + cars.Count);

            foreach (var car in cars.Values)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}
