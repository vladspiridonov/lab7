using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_of_triangle
{
    class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Первый треугольник");
            Console.Write("x:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z:");
            double z1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetSquare(x1, y1, z1);
            Console.WriteLine("второй треугольник");
            Console.Write("x:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z:");
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetSquare(x2, y2, z2);
            if (s1>s2)            
                Console.WriteLine("первый больше");
            else
                if(s1<s2)
                Console.WriteLine("второй больше");
            else
                Console.WriteLine("они равны");
            Console.ReadKey();
        }
    }
}
