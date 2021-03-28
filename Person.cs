using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProjectRemake
{
    public class Person
    {
        public string Name { get; }
        public string NameWorkShop { get; }
        public int Salary { get; set; }
        public bool Director { get; }

        public Person(string[] info)
        {
            Name = info[0];
            NameWorkShop = info[1];
            Salary = int.Parse(info[2]);

            if (info.Length == 4) Director = Convert.ToBoolean(info[3]);
            else Director = false;
        }
    }
}
