using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryOfStaff
{
    public class Worker
    {
        public string Name { get; }
        public string NameWorkShop { get; }
        public int Salary { get; }
        public bool Director { get; } = false;
        public Worker(string[] info)
        {
            Name = info[0];
            NameWorkShop = info[1];
            Salary = int.Parse(info[2]);
            Director = info.Length == 4 ? Convert.ToBoolean(info[3]) : false;
        }
    }
}
