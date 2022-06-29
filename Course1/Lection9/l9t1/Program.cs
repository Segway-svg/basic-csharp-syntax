﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t1
{
    /*
     * Внутри класса Program создано 5 статических методов. Сделайте так, чтобы они вызывали друг друга по цепочке:
     *      1) Метод Main() вызывает метод ChainMethod4().
     *      2) Метод ChainMethod4() вызывает метод ChainMethod3().
     *      3) Метод ChainMethod3() вызывает метод ChainMethod2().
     *      4) Метод ChainMethod2() вызывает метод ChainMethod1().
     *      5) Метод ChainMethod1() вызывает метод ChainMethod().
     * Внутри метода ChainMethod() выведите на экран все кадры его стека.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Stack stack = new Stack();
            ChainMethod4();

        }

        public static void ChainMethod4()
        {
            /* Добавьте свой код ниже */
            ChainMethod3();
        }

        public static void ChainMethod3()
        {
            /* Добавьте свой код ниже */
            ChainMethod2();
        }

        public static void ChainMethod2()
        {
            /* Добавьте свой код ниже */
            ChainMethod1();
        }

        public static void ChainMethod1()
        {
            /* Добавьте свой код ниже */
            ChainMethod();
        }

        public static void ChainMethod()
        {
            /* Добавьте свой код ниже */
            StackTrace st = new StackTrace(true);
            for (int i = 0; i < st.FrameCount; i++)
            {
                StackFrame sf = st.GetFrame(i);
                Console.WriteLine(sf);
            }
        }
    }
}
