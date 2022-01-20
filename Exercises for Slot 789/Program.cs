using System;

namespace Exercises_for_Slot_789
{
    class Program
    {
        static int[] SumAdjacent(int[] arr)
        {
            int[] newArr = arr;
            int i = 0;
            while (i < newArr.Length - 1)
            {
                if (newArr[i] == newArr[i + 1])
                {
                    newArr[i] += newArr[i + 1];
                    for (int j = i + 1; j < newArr.Length - 1; j++)
                    {
                        newArr[j] = newArr[j + 1];
                    }
                    Array.Resize(ref newArr, newArr.Length - 1);
                }
                i++;
            }
            if (newArr.Length != arr.Length) return SumAdjacent(newArr);

            return newArr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 6, 1 };
            int[] newArr = SumAdjacent(arr);
            Console.WriteLine(string.Join(",", newArr));
        }
    }
}
