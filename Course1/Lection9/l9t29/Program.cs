using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t29
{
    /*
     * Внутри класс Program создайте статический метод GetClientList(), который:
     *      1) Принимает стек экземпляров класса DogClient и стек экземпляров класса CatClient.
     *      2) Возвращает типизированный стек, содержащий экземлпяры классов DogClient и CatClient расположенные через одного.
     *      3) Если стек экземпляров классов DogClient больше стека CatClient на 1 или равен ему, то верхним элементом
     *      возвращаемого стека должен являться экземпляр класса DogClient.
     *      4) Если стек экземпляров классов DogClient меньше стека CatClient на 1, то верхним элементом
     *      возвращаемого стека должен являться экземпляр класса CatClient.
     *      5) Если разница в количестве элементов стеков экземпляров класса DogClient и CatClient больше 2, то
     *      метод должен вернуть null.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            CatClient catClient1 = new CatClient();
            CatClient catClient2 = new CatClient();
            CatClient catClient3 = new CatClient();
            
            DogClient dogClient1 = new DogClient();
            DogClient dogClient2 = new DogClient();
            DogClient dogClient3 = new DogClient();

            Stack<CatClient> catClientStack = new Stack<CatClient>();
            catClientStack.Push(catClient1);
            catClientStack.Push(catClient2);
            catClientStack.Push(catClient3);

            Stack<DogClient> dogClientStack = new Stack<DogClient>();
            dogClientStack.Push(dogClient1);
            dogClientStack.Push(dogClient2);
            dogClientStack.Push(dogClient3);

            Stack<object> answer = GetClientList(dogClientStack, catClientStack);
            int answerCount = answer.Count;
            for (int i = 0; i < answerCount; i++)
            {
                Console.WriteLine(answer.Pop());
            }
        }
        /* Добавьте свой код ниже */
        public static Stack<object> GetClientList(Stack<DogClient> dogClients, Stack<CatClient> catClients)
        {
            Stack<object> answer = new Stack<object>();
            if (Math.Abs(dogClients.Count - catClients.Count) >= 2)
            {
                return null;
            }
            // Попытаться объединить и сократить код
            //else if (dogClients.Count == catClients.Count || dogClients.Count - catClients.Count == 1)
            //{
            //    answer.Push(dogClients.Pop());
            //    while (true)
            //    {
            //        if (catClients.Count > 0)
            //        {
            //            answer.Push(catClients.Pop());
            //        }
            //        if (dogClients.Count > 0)
            //        {
            //            answer.Push(dogClients.Pop());
            //        }
            //        if (catClients.Count == 0 && dogClients.Count == 0)
            //        {
            //            break;
            //        }
            //    }
            //}
            // можно не надо...
            else if (dogClients.Count - catClients.Count == 1)
            {
                answer.Push(dogClients.Pop());
                while (true)
                {
                    if (catClients.Count > 0)
                    {
                        answer.Push(catClients.Pop());
                    }
                    if (dogClients.Count > 0)
                    {
                        answer.Push(dogClients.Pop());
                    }
                    if (catClients.Count == 0 && dogClients.Count == 0)
                    {
                        break;
                    }
                }
            }
            else if (dogClients.Count == catClients.Count)
            {
                answer.Push(catClients.Pop());
                while (true)
                {
                    if (dogClients.Count > 0)
                    {
                        answer.Push(dogClients.Pop());
                    }
                    if (catClients.Count > 0)
                    {
                        answer.Push(catClients.Pop());
                    }
                    if (catClients.Count == 0 && dogClients.Count == 0)
                    {
                        break;
                    }
                }
            }
            // можно не надо...
            else if (dogClients.Count + 1 == catClients.Count)
            {
                answer.Push(catClients.Pop());
                while (true)
                {
                    if (dogClients.Count > 0)
                    {
                        answer.Push(dogClients.Pop());
                    }
                    if (catClients.Count > 0)
                    {
                        answer.Push(catClients.Pop());
                    }
                    if (catClients.Count == 0 && dogClients.Count == 0)
                    {
                        break;
                    }
                }
                //while (dogClients.Count > 0 && catClients.Count > 0)
                //{
                //    answer.Push(dogClients.Pop());
                //    answer.Push(catClients.Pop());
                //}
            }
            return answer;
        }
    }

    public class DogClient
    {
        public override string ToString()
        {
            return "Клиент собачка";
        }
    }

    public class CatClient
    {
        public override string ToString()
        {
            return "Клиент котик";
        }
    }
}
