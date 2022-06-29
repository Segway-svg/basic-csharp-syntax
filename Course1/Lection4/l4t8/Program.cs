using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t8
{
    /* 
     * Создайте метод Compare(), который принимает в себя целое число и выводит на экран фразу:
     *  1) "Число отрицательное", если переданное число меньше нуля.
     *  2) "Число положительное", если переданное число больше нуля.
     *  3) "Введён 0!!!", если введён ноль.
     * Внутри метода Main() вызовите метод 3 раза, передавая ему в качестве аргумента числа:
     *  1) 10.
     *  2) 0.
     *  3) -777.
     */
    
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program program = new Program();
            program.Compare(10);
            program.Compare(0);
            program.Compare(-777);
        }
        void Compare(int num)
        {
            if (num == 0) Console.WriteLine("Введён 0!!!");
            else if (num < 0) Console.WriteLine("Число отрицательное");
            else Console.WriteLine("Число положительное");
        }
    }
}
