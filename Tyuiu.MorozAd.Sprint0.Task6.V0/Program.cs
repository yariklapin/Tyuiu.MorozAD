using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAd.Sprint0.Task6.V0.lib;

namespace Tyuiu.MorozAd.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность = " + DataService.SubrationArray(numsArray));
            Console.WriteLine("Произвидение = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
