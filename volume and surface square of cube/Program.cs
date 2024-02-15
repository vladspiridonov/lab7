using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume_and_surface_square_of_cube
{
    class Program
    {
        static void CubeSquareVolume (double a, out double s, out double v)
        {
            v = a * a * a;
            s = a * a * 6;
        }
        static void Main(string[] args)
        {
            Console.Write("Сторона куба а:");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            CubeSquareVolume(a,out s,out v);
            Console.WriteLine("s = {0:.00}", s);
            Console.WriteLine("v = {0:.00}", v);
            Console.ReadKey();
        }
    }
}
