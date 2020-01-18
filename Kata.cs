using System;
using System.Collections.Generic;
using System.Text;

namespace OccurencesOfArray
{
    public class Kata
    {
        public static int[] FindAll(int[] array, int n)
        {

            List<int> arrayList = new List<int>();


            for (int j = 0; j < array.Length; j++)
            {
               
                    if (array[j] == n)
                    {
                        arrayList.Add(j);
                    }
                
            }

            return arrayList.ToArray();
        }
    }
}
