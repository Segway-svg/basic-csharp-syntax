using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t22
{
    /*
     * Реализуйте класс Calculator, который должен включать в себя 4 статических метода:
     *      1) Sum, который возвращает сумму двух целых чисел.
     *      2) Dif, который возвращает разность двух целых чисел.
     *      3) Mult, который возвращает произведение двух целых чисел.
     *      4) AllSum, который возвращает сумму всех переданных элементов (элементов может быть 0, а может быть и более 1000).
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class Calculator
    {
        /* Добавьте свой код ниже */
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Dif(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int AllSum(params int[] a)
        {
            int answer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i];
            }
            return answer;
        }

    }
}
