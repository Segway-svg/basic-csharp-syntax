﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t20
{
    /*
     * Внутри метода Main() произведите обмен значениями переменных А и переменной C между собой.
     * Объявлять дополнительные переменные запрещено. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static int A = 77;
        public static int C = 93;

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            A = A + C;
            C = A - C;
            A = C - A;
            A *= -1;
            Console.WriteLine(A);
            Console.WriteLine(C);
        }
    }
}
