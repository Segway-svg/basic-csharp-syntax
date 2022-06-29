using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t13
{
    /*
     * Создайте статический метод GetDistance(), который должен вычислять и возвращать расстояние между двумя точками на координатной плоскости.
     * Метод должен принимать X1 и Y1 - координаты первой точки, а также X2 и Y2 - координаты второй точки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(GetDistance(0, 0, 1, 1));
        }
        public static double GetDistance(double X1, double Y1, double X2, double Y2)
        {
            return (double)Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));       
        }
    }
}
