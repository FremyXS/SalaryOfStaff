using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryOfStaff
{
    public class WorkShop
    {
        public int FullSalary { get; private set; }
        public int NumberOfEmployee { get; private set; }
        public Dictionary<string, int> SalaryOfDirector { get; private set; } = new Dictionary<string, int>();
        public WorkShop(Worker worker)
        {
            if(worker.Director == false)
            {
                NumberOfEmployee = 1;
                FullSalary = worker.Salary;
            }
            else
            {
                SalaryOfDirector.Add(worker.Name, worker.Salary);
            }
        }
        public WorkShop(WorkShop workshop, Worker worker)
        {
            if(worker.Director == true)
            {
                workshop.SalaryOfDirector.Add(worker.Name, worker.Salary);               
            }
            else
            {
                workshop.NumberOfEmployee++;
                workshop.FullSalary += worker.Salary;
            }

            SalaryOfDirector = workshop.SalaryOfDirector;
            NumberOfEmployee = workshop.NumberOfEmployee;
            FullSalary = workshop.FullSalary;
        }
    }
}
