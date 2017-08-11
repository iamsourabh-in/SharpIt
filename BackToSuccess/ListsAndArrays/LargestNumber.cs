using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.ListsAndArrays
{
    class LargestNumber
    {
        int [] numbers = {1123,1231,23,123,1,23,23,4,234,2,53565,745,634,534};
        int max = 0;
        public void FindLargest() {
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            Console.WriteLine("Largest is {0}", max);
            Console.ReadLine();
        }


    }
    
}
