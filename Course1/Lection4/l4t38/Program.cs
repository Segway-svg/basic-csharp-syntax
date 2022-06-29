using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t38
{
    /*
     * В классе Program создайте публичный статический метод GetIntAsString(), который принимает 1 целое число и возвращает строку:
     * 1) Если число от 1 до 9999 включительно – словесную форму полученного числа (Например: один (1), пятнадцать(15), одна тысяча девятьсот девяносто девять (1999))
     * 2) Если меньше 1 - "Слишком маленькое число".
     * 3) Если больше 9999 - "Слишком большое число".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 2000; i++)
            {
                Console.WriteLine(GetIntAsString(i));
            }
        }
        public static string GetIntAsString(int num)
        {
            int number = num;
            int thousand = 0;
            int hundred = 0;
            int ten = 0;
            int one = 0;
            if (num < 1) return "Слишком маленькое число";
            else if (num > 9999) return "Слишком большое число";
            else 
            {
                one = num % 10;
                num /= 10;
                ten = num % 10;
                num /= 10;
                hundred = num % 10;
                num /= 10;
                thousand = num % 10;
                num /= 10;

                string oneStr = "";
                string tenStr = "";
                string hundredStr = "";
                string thousandStr = "";

                switch(one)
                {
                    case 1:
                        oneStr = "один";
                        break;
                    case 2:
                        oneStr = "два";
                        break;
                    case 3:
                        oneStr = "три";
                        break;
                    case 4:
                        oneStr = "четыре";
                        break;
                    case 5:
                        oneStr = "пять";
                        break;
                    case 6:
                        oneStr = "шесть";
                        break;
                    case 7:
                        oneStr = "семь";
                        break;
                    case 8:
                        oneStr = "восемь";
                        break;
                    case 9:
                        oneStr = "девять";
                        break;
                }
                switch(ten)
                {
                    //case 1:
                    //    oneStr = "";
                    //    break;
                    case 2:
                        tenStr = "двадцать";
                        break;
                    case 3:
                       tenStr = "тридцать";
                        break;
                    case 4:
                       tenStr = "сорок";
                        break;
                    case 5:
                       tenStr = "пятьдесят";
                        break;
                    case 6:
                       tenStr = "шестьдесят";
                        break;
                    case 7:
                       tenStr = "семьдесят";
                        break;
                    case 8:
                       tenStr = "восемьдесят";
                        break;
                    case 9:
                       tenStr = "девяносто";
                        break;
                }
                switch(hundred)
                {
                    case 1:
                        hundredStr = "сто";
                        break;
                    case 2:
                        hundredStr = "двести";
                        break;
                    case 3:
                        hundredStr = "триста";
                        break;
                    case 4:
                        hundredStr = "четыреста";
                        break;
                    case 5:
                        hundredStr = "пятьсот";
                        break;
                    case 6:
                        hundredStr = "шестьсот";
                        break;
                    case 7:
                        hundredStr = "семьсот";
                        break;
                    case 8:
                        hundredStr = "восемьсот";
                        break;
                    case 9:
                        hundredStr = "девятьсот";
                        break;
                }
                switch(thousand)
                {
                    case 1:
                        thousandStr = "одна тысяча";
                        break;
                    case 2:
                        thousandStr = "две тысячи";
                        break;
                    case 3:
                        thousandStr = "три тысячи";
                        break;
                    case 4:
                        thousandStr = "четыре тысячи";
                        break;
                    case 5:
                        thousandStr = "пять тысяч";
                        break;
                    case 6:
                        thousandStr = "шесть тысяч";
                        break;
                    case 7:
                        thousandStr = "семь тысяч";
                        break;
                    case 8:
                        thousandStr = "восемь тысяч";
                        break;
                    case 9:
                        thousandStr = "девять тысяч";
                        break;
                }
                if (ten == 1)
                {
                    switch(one)
                    {
                        case(0):
                            tenStr = "десять";
                            break;
                        case (1):
                            tenStr = "одиннадцать";
                            break;
                        case (2):
                            tenStr = "двенадцать";
                            break;
                        case (3):
                            tenStr = "тринадцать";
                            break;
                        case (4):
                            tenStr = "четырнадцать";
                            break;
                        case (5):
                            tenStr = "пятнадцать";
                            break;
                        case (6):
                            tenStr = "шестнадцать";
                            break;
                        case (7):
                            tenStr = "семнадцать";
                            break;
                        case (8):
                            tenStr = "восемнадцать";
                            break;
                        case (9):
                            tenStr = "девятнадцать";
                            break;
                    }
                }

                if (thousand == 0 && hundred == 0 && ten == 1) return tenStr;
                if (thousand == 0 && hundred != 0 && ten == 1) return hundredStr + " " + tenStr;
                if (thousand != 0 && hundred == 0 && ten == 1) return thousandStr + " " + tenStr;
                if (ten == 1) return thousandStr + " " + hundredStr + " " + tenStr;


                if (thousand != 0 && hundred == 0 && ten == 0 && one == 0) return thousandStr;

                else if (thousand == 0 && hundred == 0 && ten == 0 && one != 0) return oneStr;
                else if (thousand == 0 && hundred == 0 && ten != 0 && one != 0) return tenStr + " " + oneStr;
                else if (thousand == 0 && hundred != 0 && ten != 0 && one != 0) return hundredStr + " " + tenStr + " " + oneStr;
                else if (thousand == 0 && hundred != 0 && ten != 0 && one == 0) return hundredStr + " " + tenStr;

                else if (thousand == 0 && hundred == 0 && ten != 0 && one == 0) return tenStr;
                else if (thousand != 0 && hundred != 0 && ten != 0 && one == 0) return thousandStr + " " + hundredStr + " " + tenStr;
                else if (thousand != 0 && hundred != 0 && ten == 0 && one != 0) return thousandStr + " " + hundredStr + " " + oneStr;
                else if (thousand != 0 && hundred == 0 && ten == 0 && one != 0) return thousandStr + " " + oneStr;
                else if (thousand == 0 && hundred == 0 && ten == 0 && one != 0) return hundredStr + " " + tenStr + " " + oneStr;
                else if (thousand == 0 && hundred == 0 && ten == 0 && one != 0) return hundredStr + " " + tenStr + " " + oneStr;
                else if (thousand == 0 && hundred != 0 && ten == 0 && one != 0) return hundredStr + " " + oneStr;
                else if (thousand == 0 && hundred != 0 && ten != 0 && one == 0) return hundredStr + " " + tenStr;
                else if (thousand == 0 && hundred != 0 && ten == 0 && one == 0) return hundredStr;
                else if (thousand != 0 && hundred != 0 && ten == 0 && one == 0) return thousandStr + " " + hundredStr;
                else if (thousand != 0 && hundred == 0 && ten == 0 && one == 0) return thousandStr;
                else if (thousand != 0 && hundred != 0 && ten == 0 && one == 0) return thousandStr + " " + hundredStr;
                else if (thousand != 0 && hundred == 0 && ten != 0 && one == 0) return thousandStr + " " + tenStr;
                else if (thousand != 0 && hundred == 0 && ten != 0 && one != 0) return thousandStr + " " + tenStr + " " + oneStr;

                return thousandStr + " " + hundredStr + " " + tenStr + " " + oneStr;
            }
        }
    }
}
