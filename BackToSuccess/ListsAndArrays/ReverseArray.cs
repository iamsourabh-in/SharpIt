using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.ListsAndArrays
{
    class ReverseArray
    {
        static int[] numbers = { 1, 2, 23, 123, 1243, 23, 23, 4, 234, 2, 53565, 745, 634, 534 };
        int[] reversed = new int[numbers.Length];
        public void Reverse()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                int maxcur = numbers.Length - i - 1;
                reversed[i] = numbers[maxcur];
            }
            Console.WriteLine("-------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(reversed[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}
