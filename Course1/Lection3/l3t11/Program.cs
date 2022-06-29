﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t11
{
    /*
     * Создайте классы Dog и Cat в том же файле и том же namespace, что и класс Program. 
     * Создайте класс Human в том же файле и том же namespace, что и класс Program, а также объявите в нём строковую переменную name. 
     * Измените классы Cat и Dog таким образом, чтобы у них появилось поле owner, подумайте, какого типа оно должно быть. 
     * Внутри метода Main() класса Program создайте два экземпляра класса Human, присвойте их переменным catOwner 
     * и dogOwner, и по одному экземпляру классов Cat и Dog, присвойте их переменным с произвольными именами. 
     * Присвойте экземпляру catOwner имя Вася, а экземпляру dogOwner - имя Марго. Сделайте так, чтобы у каждого 
     * из созданных животных появился владелец и выведите их имена на экран в следующих форматах: 
     * "Владельца кота зовут: ХХХ", "Владельца собаки зовут: ХХХ", где ХХХ - имена владельцев животных, каждый вывод с новой строки. 
     * Все создаваемые элементы делайте публичными.
     */
    
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Human catOwner = new Human();
            Human dogOwner = new Human();
            Cat cat = new Cat();
            Dog dog = new Dog();

            catOwner.name = "Вася";
            dogOwner.name = "Марго";

            cat.owner.name = catOwner.name;
            dog.owner.name = dogOwner.name;

            Console.WriteLine($"Владельца кота зовут: {cat.owner.name}" + '\n'
                + $"Владельца собаки зовут: {dog.owner.name}");
        }
    }
    /* Добавьте свой код ниже */
    class Human
    {
        public string name;
    }

    class Dog
    {
        public Human owner = new Human();
    }

    class Cat
    {
        public Human owner = new Human();
    }
}