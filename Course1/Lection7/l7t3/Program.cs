using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t3
{
    /*
     * На вход в метод Main() будет подан массив строк args, каждая из строк будет содержать число типа double в строковом представлении, с различным количеством знаков после точки.
     * Создайте статический метод SmartCutter() который принимает массив строк и возвращает динамический массив, содержащий только те числа double из принятого массива, 
     * в которых количество знаков после точки меньше либо равно 3. 
     * Внутри метода Main() выведите результат работы метода SmartCutter() в консоль, каждый элемент с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            foreach (var i in SmartCutter(args))
            {
                Console.WriteLine(i);
            }
        }
        public static ArrayList SmartCutter(string[] arr)
        {
            ArrayList list = new ArrayList();
            
            foreach (string str in arr)
            {
                int answerCounter = 0;
                int i = 0;
                while(str[i] != ',') i++;
                for (i++ ; i < str.Length; i++) answerCounter++;
                
                if (answerCounter <= 3)
                {
                    if (double.TryParse(str, out double answer)) answer = double.Parse(str);
                    list.Add(answer);
                }
            }
            return list;
        }
    }
}




//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace l7t3
//{
//    /*
//     * На вход в метод Main() будет подан массив строк args, каждая из строк будет содержать число типа double в строковом представлении, с различным количеством знаков после точки.
//     * Создайте статический метод SmartCutter() который принимает массив строк и возвращает динамический массив, содержащий только те числа double из принятого массива, 
//     * в которых количество знаков после точки меньше либо равно 3. 
//     * Внутри метода Main() выведите результат работы метода SmartCutter() в консоль, каждый элемент с новой строки.
//     */

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            /* Добавьте свой код ниже */

//            string[] arg = new string[3];
//            arg[0] = "1,123";
//            arg[1] = "4,2";
//            arg[2] = "0,3";

//            foreach (var i in SmartCutter(arg))
//            {
//                Console.WriteLine(i);
//            }
//        }
//        public static ArrayList SmartCutter(string[] arr)
//        {
//            ArrayList list = new ArrayList();

//            foreach (string str in arr)
//            {
//                string symbol = "";
//                int i = 0;
//                while (str[i] != ',') i++;
//                for (i++; i < str.Length; i++) symbol += str[i];

//                if (double.TryParse(symbol, out double num)) num = double.Parse(symbol);

//                if (num <= 3)
//                {
//                    if (double.TryParse(str, out double answer)) answer = double.Parse(str);
//                    list.Add(answer);
//                }
//            }
//            return list;
//        }
//    }
//}
