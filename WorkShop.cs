using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProjectRemake
{
    public class WorkShop
    {
        public string NameWorkShop { get; }
        public int FullSalary { get; set; }
        public int NumberOfEmployee { get; set; }
        public WorkShop(Person person)
        {
            NameWorkShop = person.NameWorkShop;
            FullSalary = person.Salary;
            NumberOfEmployee = 1;
        }
    }
}
