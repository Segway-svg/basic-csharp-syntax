using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t18
{
    /*
     * Добавьте публичную статическую переменную users, которая хранит в себе информацию о пользователях в формате "фамилия-имя"
     * в класс Program, тип переменной определяете самостоятельно.
     * В методе Main() заполните переменную users 10 значениями введенными с клавиатуры. Создайте публичный статический метод
     * GetStatistic, который:
     *      1) Принимает в качестве входящего параметра тип переменной users.
     *      2) Возвращает список строк, который содержит список всех имён из users и указывает количество их повторений в users в формате
     * "NAME - ХХХ повторений", где NAME имя из users, а ХХХ - количество повторений имени NAME в users.
     * Внутри метода Main() выведите результат работы метода GetStatistic(), каждое значение с новой строки.
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        public static Dictionary<string, string> users = new Dictionary<string, string>();
        
        public static List<string> GetStatistic(Dictionary<string, string> users)
        {
            List<string> repeats = new List<string>();
            foreach(var userValue in users.Values)
            {
                repeats.Add(userValue);
            }

            Dictionary<string, string>.Enumerator it = users.GetEnumerator();

            int repeatsIndex = 0;
            List<string> usedNames = new List<string>();
            while (it.MoveNext())
            {
                int countOfNames = 0;
                string name = it.Current.Value;
                for (int i = 0; i < users.Count; i++)
                {
                    if (name == repeats[i]) countOfNames++;
                }

                if (usedNames.Contains(name)) continue;
                else
                {
                    repeats[repeatsIndex] = $"{name} - {countOfNames} повторений";
                    usedNames.Add(name);
                    repeatsIndex++;
                }
            }
            repeats.RemoveRange(repeatsIndex, users.Count - repeatsIndex);
            return repeats;
        }

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 0; i < 10; i++)
            {
                string lastName = Console.ReadLine();
                string firstName = Console.ReadLine();
                users.Add(lastName, firstName);
            }
            foreach (var user in GetStatistic(users)) Console.WriteLine(user);
        }
    }
}
//public static List<string> GetStatistic(Dictionary<string, string> users)
//{
//    List<string> repeats = new List<string>();
//    //foreach(var userValue in users.Values)
//    //{
//    //    repeats.Add(userValue);
//    //}

//    Dictionary<string, string>.Enumerator it = users.GetEnumerator();

//    //int repeatsIndex = 0;
//    List<string> usedNames = new List<string>();
//    while (it.MoveNext())
//    {
//        int countOfNames = 0;
//        string name = it.Current.Value;
//        for (int i = 0; i < users.Count; i++)
//        {
//            if (name == repeats[i]) countOfNames++;
//        }

//        if (usedNames.Contains(name)) continue;
//        else
//        {
//            Console.WriteLine("AAAA");
//            //repeats[repeatsIndex] = $"{name} - {countOfNames} повторений";
//            repeats.Add($"{name} - {countOfNames} повторений");
//            usedNames.Add(name);
//            //repeatsIndex++;
//        }
//    }
//    return repeats;
//}



//public static List<string> GetStatistic(Dictionary<string, string> users)
//{
//    List<string> repeats = new List<string>();
//    foreach (var userValue in users.Values)
//    {
//        repeats.Add(userValue);
//    }

//    Dictionary<string, string>.Enumerator it = users.GetEnumerator();

//    int repeatsIndex = 0;
//    List<string> usedNames = new List<string>();
//    while (it.MoveNext())
//    {
//        int countOfNames = 0;
//        string name = it.Current.Value;
//        for (int i = 0; i < users.Count; i++)
//        {
//            if (name == repeats[i]) countOfNames++;
//        }

//        if (usedNames.Contains(name)) continue;
//        else
//        {
//            repeats[repeatsIndex] = $"{name} - {countOfNames} повторений";
//            usedNames.Add(name);
//            repeatsIndex++;
//        }
//    }
//    return repeats;
//}