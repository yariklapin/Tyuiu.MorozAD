using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAd.Sprint0.Task7.V0.lib;
namespace Tyuiu.MorozAd.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #0                                                            *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                          *");
            Console.WriteLine("* Задние # 7                                                           *");
            Console.WriteLine("* Вариант #0                                                           *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Условие:                                                             *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения двух *");
            Console.WriteLine("* одинааковых массивов по длине.                                       *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Исходные данные:                                                     *");
            Console.WriteLine("************************************************************************");

            int[] arrrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrrayNums1.Length; i++)
            {
                Console.Write(arrrayNums1[i]+ ",");
            }
            Console.WriteLine();

            int[] arrrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrrayNums2.Length; i++)
            {
                Console.Write(arrrayNums2[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Результат:                                                           *");
            Console.WriteLine("************************************************************************");

            if (arrrayNums1.Length == arrrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrrayNums1, arrrayNums2);
                Console.WriteLine("Сумма : ");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ",");
                }
            }
            else
            {
                Console.WriteLine("Ошибка!!!!!!!!!!!!");
            }
             Console.ReadKey();
            }

        }
    }

