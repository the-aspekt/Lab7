using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static double GetTriangleArea(double a, double b, double c)
        {
            double halfP = 0.5 * (a + b + c);
            double area = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
            return area;
        }

        static void GetTriangleSides(out double a, out double b, out double c)
        {
            Console.WriteLine("Введите первую сторону треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника");
            c = Convert.ToDouble(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            double a1, b1, c1, a2, b2, с2;
            Console.WriteLine("Введите параметры первого треугольника");
            GetTriangleSides(out a1, out b1, out c1);
            Console.WriteLine("Введите параметры второго треугольника");
            GetTriangleSides(out a2, out b2, out с2);
            if (GetTriangleArea(a1, b1, c1) > GetTriangleArea(a2, b2, с2))
                Console.WriteLine("Первый треугольник больше!");
            else if (GetTriangleArea(a1, b1, c1) < GetTriangleArea(a2, b2, с2))
                Console.WriteLine("Второй треугольник больше!");
            else Console.WriteLine("Оба треугольника равны!");
            Console.ReadKey();
        }
    }
}
