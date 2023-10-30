using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//1 и 2 хадача
            /*
            int x;
            WriteLine("введите х: ");
            x = Convert.ToInt32(ReadLine());
            WriteLine("сколько раз вызвать метод?");
            int raz = Convert.ToInt32(ReadLine());
           
            void Func()
            {
               double y = Math.Pow(x, 2);
                WriteLine(y);
            }
            Clear();
            for (int i = 0; i <= raz; i++)
            {
                Func();
            }
            */
            //3 задача
            /*
            int x;
            WriteLine("введите х: ");
            x = Convert.ToInt32(ReadLine());
            
            void Func()
            {
                double y = 3 * Math.Pow(x,2) + 8 * x - 10 / 15;
                WriteLine(y);
            }
            Func(); 
            */
            //5
            /*
            int x;
            WriteLine("введите х: ");
            x = Convert.ToInt32(ReadLine());

            void Func()
            {
                double y = 4 * Math.Pow(x, 2) + 1 / x - 5;
                WriteLine(y);
            }
            void Func1()
            {
                double y = 3 * Math.Pow(x, 2) - 2;
                WriteLine(y);
            }
            if (x < 5)
            {
                Func();
            }
            else
            {
                Func1();
            }
            */
            //6
            int a;
            WriteLine("введите a: ");
            a = Convert.ToInt32(ReadLine());
            int b;
            WriteLine("введите b: ");
            b = Convert.ToInt32(ReadLine());

            void FuncDel()
            {
                double y = a / b ;
                WriteLine("деление: " +y);
            }
            void FuncSum()
            {
                double y = a + b;
                WriteLine("сложение: " +y);
            }
            void FuncMul()
            {
                double y = a * b;
                WriteLine("умножение: " +y);
            }
            void FuncRaz()
            {
                double y = a - b;
                WriteLine("разность: " +y);
            }
            FuncDel();
            FuncMul();
            FuncRaz();
            FuncSum();
            ReadKey();
        }
    }
}
