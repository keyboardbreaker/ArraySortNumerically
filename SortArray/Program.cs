using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[]{ 5, 4, 3, 2, 5 };

            Array.Sort(intArray);
            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);
            
        }
    }
}
