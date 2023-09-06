using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SpirinIS.ConsoleApp.Lab0.V0.Lib;

namespace Tyuiu.SpirinIS.ConsoleApp.Lab0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной K");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной W");
            int w = Convert.ToInt32(Console.ReadLine());

            DataService solve = new DataService();

            var result = solve.Calc(k, w);

            Console.WriteLine("Сумма K + W = " + result);

            Console.ReadKey();
        }
    }
}
