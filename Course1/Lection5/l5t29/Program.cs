using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t29
{
    /*
     * В классе Program добавьте публичное статическое поле deleteCount, которое должно увеличиваться каждый раз при уничтожении
     * экземпляра класса. Добавьте соответствующую логику деструктору класса Program
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        public static int deleteCount = 0;
        ~Program()
        {
            deleteCount += 1;
        }
        public static void Main(string[] args)
        {

        }
    }
}
