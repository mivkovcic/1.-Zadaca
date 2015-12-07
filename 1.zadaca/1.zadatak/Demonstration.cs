﻿using System;

namespace _1.zadatak
{
    public class Demonstration
    {
        public static void Main(string[] args)
        {
            IntegerList list = new IntegerList();
            ListExample(list);
        }

        public static void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1);
            listOfIntegers.Add(2);
            listOfIntegers.Add(3);
            listOfIntegers.Add(4);
            listOfIntegers.Add(5);
            // lista je [1,2,3,4,5]

            // Mičemo prvi element liste.
            listOfIntegers.RemoveAt(0);
            // Lista je [2,3,4,5]

            // Mičemo element liste čija je vrijednost "5".
            listOfIntegers.Remove(5);
            // Lista je [2,3,4]

            Console.WriteLine(listOfIntegers.Count);
            // 3

            Console.WriteLine(listOfIntegers.Remove(100));
            // false, nemamo element u vrijednosti 100

            Console.WriteLine(listOfIntegers.RemoveAt(5));
            // false, nemamo ništa na poziciji 5

            // Brišemo sav sadržaj kolekcije
            listOfIntegers.Clear();

            Console.WriteLine(listOfIntegers.Count);
            // 0

            Console.ReadLine();
        }
    }
}
