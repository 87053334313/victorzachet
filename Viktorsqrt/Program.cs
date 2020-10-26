using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viktorsqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычесляет площадь тругольника, по трем сторонам");
            Console.WriteLine("введи а");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("введи b");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("введи c");
            float c = float.Parse(Console.ReadLine());
            if (a < (b + c))
            {
                if (b < (a + c))
                {
                    if (c < (a + b))
                    {
                        Console.WriteLine("можно построить так как каждая сторона треугольнка меньше суммы двух других сторон ");
                        float p = (a + b + c) / 2;
                        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("Площадь S=" + s);
                    }
                    else
                    {
                        Console.WriteLine("Нельзя построить такой треуголник, так как c>=(a+b),а по правилу каждая сторона треуголника должна быть мeнешe чем сумма двух других");
                    }
                }
                else
                {
                    Console.WriteLine("Нельзя построить такой треуголник, так как b>=(a+c),а по правилу каждая сторона треуголника должна быть мeнешe чем сумма двух других ");
                }
            }
            else
            {
                Console.WriteLine("Нельзя построить такой треуголник, так как a>=(b+c),а по правилу каждая сторона треуголника должна быть мeнешe чем сумма двух других ");
            }
            Console.ReadKey();
        }
    }
}
