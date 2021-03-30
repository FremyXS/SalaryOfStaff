using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalaryOfStaff
{
    public static class Info
    {
        public static string[] info { get; private set; }
        public static List<Worker> ListOfWorkers { get; private set; }

        public static void GetInfo()
        {
            info = File.ReadAllLines("FileWithStaff.txt");
            ListOfWorkers = new List<Worker>();

            foreach(var i in info)
            {
                var worker = new Worker(i.Split(';'));
                ListOfWorkers.Add(worker);
            }
        }

    }
}
