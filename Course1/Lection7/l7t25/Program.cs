//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace l7t25
//{
//    /*
//     * На вход в метод Main() подается массив строк, который содержит сведения из некоторого системного журнала логов.
//     * Каждая строка - это отдельный лог, событие, которое произошло и было зафиксировано. Нам необходимо вычислить
//     * пользователей, которые являются спамерами, и добавить их IP-адрес в список заблокированных.
//     * Формат строки лога:
//     * ID_EVENT_USER_DATETIME_STATUS, где:
//     *      1) ID - число, ID лога;
//     *      2) EVENT - строка с типом события (message, act, request);
//     *      3) USER - строка с учетной записью пользователя;
//     *      4) DATETIME - числовое представление даты создания события;
//     *      5) STATUS - строка с информацией о статусе события.
//     * Список всех пользователей и их IP-адресов находится переменной allUsers, где ключ это учетная запись пользователя.
//     * Список заблокированных пользователей и их IP-адреса должны находится в переменной blockedUsers.
//     * Логика определения спамеров должна быть следующая:
//     *      1) Если пользователь оправляет сообщение (event - message) чаще чем 1 раз в 5 секунд.
//     *      2) Если пользователь отправляет запрос чаще чем 1 раз в 2 секунды.
//     * Выведите в консоль всех заблокированных пользователей в формате: "ACCOUNT_SURNAME_NAME - IP" каждое значение с новой строки, где:
//     *      ACCOUNT - учетная запись пользователя;
//     *      SURNAME - фамилия пользователя;
//     *      NAME - имя пользователя;
//     *      IP - IP-адрес пользователя.
//     * Вся логика работы программы должна быть реализована в методе Main(), остальные элементы шаблона изменять нельзя.
//     */

//    public class Analyzer
//    {
//        public static void Main(string[] args)
//        {
//            /* Добавьте свой код ниже */
//            Dictionary<string, DateTime> messages = new Dictionary<string, DateTime>();
//            Dictionary<string, DateTime> request = new Dictionary<string, DateTime>();

//            for (int i = 0; i < args.Length; i++)
//            {
//                string[] tokens = args[i].Split('_');
//                if (!messages.ContainsKey(tokens[2]))
//                {
//                    messages.Add(tokens[2], new DateTime(long.Parse(tokens[3])));
//                }
//                else if (!request.ContainsKey(tokens[2]))
//                {
//                    request.Add(tokens[2], new DateTime(long.Parse(tokens[3])));
//                }
//                else if (tokens[1] == "request")
//                {
//                    if (new DateTime(long.Parse(tokens[3])).Subtract(request[tokens[2]]).TotalSeconds < 2) {
//                        if (!Program.blockedUsers.ContainsKey(tokens[2]))
//                        {
//                            Program.blockedUsers.Add(tokens[2], Program.allUsers[tokens[2]]);
//                        }
//                        else
//                        {
//                            request[tokens[2]] = new DateTime(long.Parse(tokens[3]));
//                        }
//                    }
//                }
//                else if (tokens[1] == "message")
//                {
//                    if (new DateTime(long.Parse(tokens[3])).Subtract(messages[tokens[2]]).TotalSeconds < 5)
//                    {
//                        if (!Program.blockedUsers.ContainsKey(tokens[2]))
//                        {
//                            Program.blockedUsers.Add(tokens[2], Program.allUsers[tokens[2]]);
//                        }
//                        else
//                        {
//                            messages[tokens[2]] = new DateTime(long.Parse(tokens[3]));
//                        }
//                    }
//                }
//            }

//            foreach (var item in Program.allUsers)
//            {
//                Console.WriteLine($"{item.Value.Account}_{item.Value.Surname}_{item.Value.Name} - {item.Value.IP}");
//            }
//        }
//    }

//    public static class Program
//    {
//        public static Dictionary<string, UserInfo> allUsers = new Dictionary<string, UserInfo>();
//        public static Dictionary<string, UserInfo> blockedUsers = new Dictionary<string, UserInfo>();
//        static Program()
//        {
//            allUsers.Add("StormRage", new UserInfo("StormRage", "10.11.12.168", "Рядовой", "Билли"));
//            allUsers.Add("Pepe", new UserInfo("Pepe", "192.196.11.21", "Жабка", "Пепе"));
//            allUsers.Add("Guffi", new UserInfo("Guffi", "192.11.51.168", "Джон", "Гук"));
//            allUsers.Add("CatTim", new UserInfo("CatTim", "33.7.122.225", "Тим", "Кот"));
//        }
//    }

//    public class UserInfo
//    {
//        public string Account { get; set; }
//        public string IP { get; set; }

//        public string Name { get; set; }
//        public string Surname { get; set; }

//        public UserInfo(string account, string ip, string name, string surname)
//        {
//            Account = account;
//            IP = ip;
//            Name = name;
//            Surname = surname;
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t25
{
    /*
     * На вход в метод Main() подается массив строк, который содержит сведения из некоторого системного журнала логов.
     * Каждая строка - это отдельный лог, событие, которое произошло и было зафиксировано. Нам необходимо вычислить
     * пользователей, которые являются спамерами, и добавить их IP-адрес в список заблокированных.
     * Формат строки лога:
     * ID_EVENT_USER_DATETIME_STATUS, где:
     *      1) ID - число, ID лога;
     *      2) EVENT - строка с типом события (message, act, request);
     *      3) USER - строка с учетной записью пользователя;
     *      4) DATETIME - числовое представление даты создания события;
     *      5) STATUS - строка с информацией о статусе события.
     * Список всех пользователей и их IP-адресов находится переменной allUsers, где ключ это учетная запись пользователя.
     * Список заблокированных пользователей и их IP-адреса должны находится в переменной blockedUsers.
     * Логика определения спамеров должна быть следующая:
     *      1) Если пользователь оправляет сообщение (event - message) чаще чем 1 раз в 5 секунд.
     *      2) Если пользователь отправляет запрос чаще чем 1 раз в 2 секунды.
     * Выведите в консоль всех заблокированных пользователей в формате: "ACCOUNT_SURNAME_NAME - IP" каждое значение с новой строки, где:
     *      ACCOUNT - учетная запись пользователя;
     *      SURNAME - фамилия пользователя;
     *      NAME - имя пользователя;
     *      IP - IP-адрес пользователя.
     * Вся логика работы программы должна быть реализована в методе Main(), остальные элементы шаблона изменять нельзя.
     */

    public class Analyzer
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, long> LastMessageTime = new Dictionary<string, long>();
            Dictionary<string, long> LastRequestTime = new Dictionary<string, long>();

            foreach (string l in args)
            {
                string[] tokens = l.Split('_');
                if ((LastMessageTime.ContainsKey(tokens[2])) || (LastRequestTime.ContainsKey(tokens[2])))
                { continue; }
                LastMessageTime.Add(tokens[2], 0);
                LastRequestTime.Add(tokens[2], 0);
            }
            foreach (string l in args)
            {
                string[] tokens = l.Split('_');
                string LogEvent = tokens[1];
                string AccountName = tokens[2];

                long eventDateTime = Convert.ToInt64(tokens[3]);
                if (Program.blockedUsers.ContainsKey(AccountName))
                { continue; }

                switch (LogEvent)
                {
                    case "message":
                        {
                            if (Math.Abs(LastMessageTime[AccountName] - eventDateTime) < 50000000)
                            { Program.blockedUsers.Add(AccountName, Program.allUsers[AccountName]); }
                            LastMessageTime[AccountName] = eventDateTime;
                            break;
                        }
                    case "request":
                        {
                            if (Math.Abs(LastRequestTime[AccountName] - eventDateTime) < 20000000)
                            { Program.blockedUsers.Add(AccountName, Program.allUsers[AccountName]); }
                            LastRequestTime[AccountName] = eventDateTime;
                            break;
                        }
                }
            }
            foreach (UserInfo user in Program.blockedUsers.Values)
            {
                Console.WriteLine($"{user.Account}_{user.Surname}_{user.Name} - {user.IP}");
            }
        }
    }

    public static class Program
    {
        public static Dictionary<string, UserInfo> allUsers = new Dictionary<string, UserInfo>();
        public static Dictionary<string, UserInfo> blockedUsers = new Dictionary<string, UserInfo>();
        static Program()
        {
            allUsers.Add("StormRage", new UserInfo("StormRage", "10.11.12.168", "Рядовой", "Билли"));
            allUsers.Add("Pepe", new UserInfo("Pepe", "192.196.11.21", "Жабка", "Пепе"));
            allUsers.Add("Guffi", new UserInfo("Guffi", "192.11.51.168", "Джон", "Гук"));
            allUsers.Add("CatTim", new UserInfo("CatTim", "33.7.122.225", "Тим", "Кот"));
        }
    }

    public class UserInfo
    {
        public string Account { get; set; }
        public string IP { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public UserInfo(string account, string ip, string name, string surname)
        {
            Account = account;
            IP = ip;
            Name = name;
            Surname = surname;
        }
    }
}