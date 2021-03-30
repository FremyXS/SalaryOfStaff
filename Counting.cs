using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryOfStaff
{
    public static class Counting
    {
        public static Dictionary<string, WorkShop> AllWorkShops { get; private set; } = new Dictionary<string, WorkShop>();
        public static string NameOfDirector { get; private set; }
        public static int SalaryOfDirector { get; private set; } = 0;
        private static void GetInfoForWorkShop()
        {
            foreach(var worker in Info.ListOfWorkers)
            {
                if (!AllWorkShops.ContainsKey(worker.NameWorkShop))
                {
                    SetNewWorkShop(worker);
                }
                else
                {
                    AddNewWorker(worker);
                }
            }
        }
        private static void SetNewWorkShop(Worker worker)
        {
            AllWorkShops.Add(worker.NameWorkShop, new WorkShop(worker));
        }
        private static void AddNewWorker(Worker worker)
        {
            AllWorkShops[worker.NameWorkShop] = new WorkShop(AllWorkShops[worker.NameWorkShop], worker);
        }
        public static void GetCounting()
        {
            Info.GetInfo();
            GetInfoForWorkShop();

            foreach(var nameWorkShop in AllWorkShops.Keys)
            {
                if(AllWorkShops[nameWorkShop].SalaryOfDirector.Count < 1 || AllWorkShops[nameWorkShop].SalaryOfDirector.Count > 2)
                {
                    throw new Exception($"Ошибка: в {nameWorkShop} не правильное количество Руководителей");
                }
                else
                {
                    GetHighlyPaid(nameWorkShop);
                }
            }
        }
        public static int GetAverageValue(string nameWorkShop)
        {
            return AllWorkShops[nameWorkShop].FullSalary / AllWorkShops[nameWorkShop].NumberOfEmployee;
        }
        private static void GetHighlyPaid(string nameWorkShop)
        {
            foreach(var i in AllWorkShops[nameWorkShop].SalaryOfDirector.Keys)
            {
                if(AllWorkShops[nameWorkShop].SalaryOfDirector[i] > SalaryOfDirector)
                {
                    SalaryOfDirector = AllWorkShops[nameWorkShop].SalaryOfDirector[i];
                    NameOfDirector = i;
                }
            }
        }
    }

}
