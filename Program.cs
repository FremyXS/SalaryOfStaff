using System;
using System.IO;
using System.Collections.Generic;

namespace ExamProjectRemake
{
    class Program
    {
        public static string[] allStaffArray { get; } = File.ReadAllLines("FileWithStaff.txt");
        public static List<Person> AllStaffList { get; set; } = new List<Person>();
        static void Main(string[] args)
        {
            GetStaff();
            GetInfo();
        }
        private static void GetStaff()
        {
            foreach (var indexOfEmployee in allStaffArray)
            {
                var person = new Person(indexOfEmployee.Split(new char[] { ';' }));
                AllStaffList.Add(person);
            }
        }
        private static void GetInfo()
        {
            if (!Info.CheckManager())
                throw new Exception("Error");
            else
            {
                Info.GetAverageSalary();
                InputInfo();
            }

        }
        private static void InputInfo()
        {
            foreach(var i in Info.AllWorkShops.Keys)
            {
                Console.WriteLine($"{i}: {Info.AllWorkShops[i].FullSalary}");
            }

            Console.WriteLine(Info.HighlyPaidSalaryPerson.Name + " " + Info.HighlyPaidSalaryPerson.Salary);
        }
    }
    
}
