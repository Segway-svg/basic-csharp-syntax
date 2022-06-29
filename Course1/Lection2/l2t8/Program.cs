using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t8
{
    /*
     * Внутри метода Main() выведите в консоль значения всех переменных, каждое с новой строки.
     * 
     * Visual Studio мощная и современная IDE, её возможности - это отдельная наука. Сегодня мы узнаем
     * чуть-чуть больше о её функциях и познакомимся с функцией автоматической генерации фрагментов кода.
     * Как видишь, нам предстоит в задаче сделать 5 выводов в консоль, для того чтобы сделать это быстрее, 
     * тебе достаточно:
     *      1) Установи указатель строки внутри метода Main() на новую строку.
     *      2) Напиши cw и ДВА раза нажми клавишу TAB.
     *      3) Насладись результатом!
     *      
     * P.S. Таких фишек в IDE вагон, с самыми полезными из них мы будем знакомиться по мере необходимости.
     */

    public class Program
    {
        static string s1 = "А";
        static string s2 = "чо";
        static string s3 = "так";
        static string s4 = "можно";
        static string s5 = "было???";
        
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
        }
    }
}
