using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.ListsAndArrays
{
    public class Boxit
    {

        public void Looper(string sentence)
        {
            int maxLength = 0;
            int noOfWords = 0;
            string[] words = sentence.Split(' ');

            foreach (string x in words)
            {
                int tempLen = x.Length;
                if (tempLen > maxLength)
                    maxLength = tempLen;
            }

            noOfWords = words.Length + 1;
            maxLength = maxLength + 1;

            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < noOfWords; j++)
                {
                    Console.Write('*');
                }
            }



        }

        public static void Execute()
        {
            Boxit box = new Boxit();
            box.Looper("hi this is amazing");
        }
    }

}
