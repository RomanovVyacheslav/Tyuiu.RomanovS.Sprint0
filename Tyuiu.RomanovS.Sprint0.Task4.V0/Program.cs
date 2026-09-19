using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RomanovS.Sprint0.Task4.V0.Lib;

namespace Tyuiu.RomanovS.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов метода вычитания Subtraction
            Console.WriteLine(DataService.Subtraction(15, 5));
            //Вызов метода умножения Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //Вызов метода деления Division
            Console.WriteLine(DataService.Division(5, 5));
            //Задержка окна консоли средствами метода ReadKey
            Console.ReadKey();
        }
    }
}
