using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MorozAd.Sprint0.Task5.V0.lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = {0},на 0 делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}