using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void GetCubeVolumeAndArea(double a, out double V, out double A)
        {
            V = a * a * a;
            A = a * a * 6;
        }

        static void Main(string[] args)
        {
            double a, V, A;
            Console.WriteLine("Введите сторону куба");
            a = Convert.ToDouble(Console.ReadLine());
            GetCubeVolumeAndArea(a, out V, out A);
            Console.WriteLine("Объем куба равен {0:f2}, площадь куба равна {1:.00}", V, A);
            Console.ReadKey();
        }
    }
}
