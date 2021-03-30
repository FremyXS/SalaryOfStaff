using System;

namespace SalaryOfStaff
{
    class Program
    {
        static void Main(string[] args)
        {            
            Counting.GetCounting();
            WriteCounting();
        }
        private static void WriteCounting()
        {
            foreach(var i in Counting.AllWorkShops.Keys)
            {
                Console.WriteLine($"{i}: {Counting.GetAverageValue(i)}");
            }

            Console.WriteLine(Counting.NameOfDirector + ": " + Counting.SalaryOfDirector);
        }
    }
}
