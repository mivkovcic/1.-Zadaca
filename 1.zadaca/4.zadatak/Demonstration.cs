using System;

namespace _4.zadatak
{
    public class Demonstration
    {
        public static void Main(string[] args)
        {
            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
