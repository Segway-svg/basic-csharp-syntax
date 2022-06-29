using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t12
{
    /*
     * Внутри метода Main() отсортируйте список экземпляров класса DogClient в порядке убывания. Критерии сортировки:
     *      1) По возрасту.
     *      2) Если возраст экземпляров равен, то они должны сортироваться между собой в порядке убывания их веса.
     *      3) Если возраст и вес равны, то они должны идти в том же порядке, в котором они добавлены в список.
     * Шаблон задачи изменять нельзя.
     */

    public class DogBank
    {
        public static List<DogClient> dogClientList = new List<DogClient>()
        {
            new DogClient("Барбос",1,5),
            new DogClient("Тризор",2,1),
            new DogClient("Ревизор",1,5),
            new DogClient("Терьер",2,5),
            new DogClient("Киллер",2,3),
            new DogClient("Бутч",3,7),
            new DogClient("Рекс",5,5),
            //new DogClient("Барбос",2,5),
            //new DogClient("Тризор",2,5),
            //new DogClient("Ревизор",2,1),
            //new DogClient("Терьер",2,5),
            //new DogClient("Киллер",2,3),
            //new DogClient("Бутч",2,1),
            //new DogClient("Рекс",2,5),

        };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            dogClientList = dogClientList.OrderByDescending(x => x.Age).ThenByDescending(x => x.Weight).ToList();

            //for (int i = 0; i < dogClientList.Count; i++)
            //{
            //    for (int j = i + 1; j < dogClientList.Count; j++)
            //    {
            //        if (dogClientList[i].Age < dogClientList[j].Age)
            //        {
            //            var tmp = dogClientList[i];
            //            dogClientList[i] = dogClientList[j];
            //            dogClientList[j] = tmp;
            //        }

            //        if (dogClientList[i].Age == dogClientList[j].Age && dogClientList[i].Weight < dogClientList[j].Weight)
            //        {
            //            var tmp = dogClientList[i];
            //            dogClientList[i] = dogClientList[j];
            //            dogClientList[j] = tmp;
            //        }
            //    }
            //}

            //List<List<int>> arr = new List<List<int>>();
            //arr.Add(new List<int>());
            //arr.Add(new List<int>());
            //arr.Add(new List<int>());
            //arr.Add(new List<int>());
            //arr.Add(new List<int>());
            //arr.Add(new List<int>());
            //for (int i = 0; i < dogClientList.Count - 1; i++)
            //{


            //    if (dogClientList[i].Age == dogClientList[i + 1].Age && dogClientList[i].Weight == dogClientList[i + 1].Weight)
            //    {
            //        Console.WriteLine("AAAAAAAAAAAAAAAAAAA");
            //        arr[i].Add(dogClientList.IndexOf(dogClientList[i]));
            //        arr[i].Add(dogClientList.IndexOf(dogClientList[i + 1]));
            //    }
            //}

            //for (int i = 0; i < arr.Count - 1; i++)
            //{
            //    for (int j = 0; j < arr[i].Count - 1; j++)
            //    {
            //        Console.WriteLine(arr[i][j]);
            //    }
            //}

            foreach (var dog in dogClientList)
            {
                Console.WriteLine(dog);
            }
        }
    }

    public class DogClient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public DogClient(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Я собачка {Name}! Мне {Age} лет и я вешу {Weight}!";
        }
    }
}
