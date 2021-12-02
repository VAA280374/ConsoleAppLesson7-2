using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону куба : ");
            double _a = Convert.ToDouble(Console.ReadLine());
            double _aV, _aS;
            _box(ref _a, out _aV, out _aS);
            Console.WriteLine("Объем куба = {0}", _aV);
            Console.WriteLine("Площадь поверхности куба = {0}", _aS);

            Console.ReadKey();

        }
        static void _box(ref double a, out double V, out double S)
        {
            V = a * a * a;
            S = a * a * 6;
        }
    }
}
