using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProjectRemake
{
    public class Info
    {
        private static int NumberOfManagers { get; set; }
        public static Person HighlyPaidSalaryPerson { get; private set; }
        public static Dictionary<string, WorkShop> AllWorkShops { get; private set; }
        private static void NumberOfManager()
        {
            NumberOfManagers = 0;

            foreach (var person in Program.AllStaffList)
            {
                if (person.Director == true) NumberOfManagers++;
            }
        }
        public static bool CheckManager()
        {
            NumberOfManager();

            if (NumberOfManagers > 2 || NumberOfManagers < 1)
                return false;
            else
                return true;
        }
        public static void GetAverageSalary()
        {
            AllWorkShops = new Dictionary<string, WorkShop>();

            HighlyPaidSalaryPerson = new Person(new string[] { "", "", "0", "true" });

            foreach (Person person in Program.AllStaffList)
            {
                if (person.Director == true)
                    SetHighlyPaidManager(person);
                else
                    GetInfoOfOneEmployee(person);
            }

            SetAverage();
        }
        private static void GetInfoOfOneEmployee(Person person)
        {
            if (AllWorkShops.ContainsKey(person.NameWorkShop)) SetSalary(person);
            else SetNewWorkshop(person);
        }
        private static void SetNewWorkshop(Person person)
        {
            var workshop = new WorkShop(person);
            AllWorkShops.Add(workshop.NameWorkShop, workshop);
        }
        private static void SetSalary(Person person)
        {
            AllWorkShops[person.NameWorkShop].FullSalary += person.Salary;
            AllWorkShops[person.NameWorkShop].NumberOfEmployee += 1;
        }
        private static void SetAverage()
        {
            foreach (var i in AllWorkShops.Keys)
            {
                AllWorkShops[i].FullSalary /= AllWorkShops[i].NumberOfEmployee;
            }
        }
        private static void SetHighlyPaidManager(Person person)
        {
            if (person.Salary > HighlyPaidSalaryPerson.Salary)
                HighlyPaidSalaryPerson = person;
        }
    }
}
