using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static List<int> Sum(List<int> listInt)
        {
            List<int> newListInt = new List<int>();
            for (int i = 0; i < listInt.Count / 2; i++)
            {
                newListInt.Add(listInt[i] + listInt[listInt.Count - i - 1]);
            }
            if (listInt.Count % 2 != 0) newListInt.Add(listInt[listInt.Count / 2]);
            return newListInt;
        }
        static void Main(string[] args)
        {
            List<int> listInt = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(",", Sum(listInt).ToArray()));
        }
    }
}
