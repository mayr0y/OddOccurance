using System;
using System.Collections.Generic;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 1, 3, 3, 3, 3, 3, 3, 3, 1, 1, 2, 3, 4, 4 };
            int[] arr1 = Solution(arr);
            foreach (int a in arr1)
            {
                Console.WriteLine(a);
            }
        }

        static int[] Solution(int[] a)
        {
            int count = 0; //счетчик для подсчета повторений числа 
            Dictionary<int, int> counts = new Dictionary<int, int>();
            Array.Sort(a);
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i - 1])
                {
                    count++;
                }
                else
                {
                    counts.Add(a[i - 1], count += 1); //добавление в словарь key = число, value = число повторений 
                    count = 0;
                }

            }

            List<int> odd = new List<int>(); //Создание списка для добавление в него только чисел, которые встречаются нечетное количество раз

            foreach (KeyValuePair<int, int> kvp in counts)
            {
                if (kvp.Value % 2 != 0)
                {
                    odd.Add(kvp.Key);
                }
            }
            int[] arr = odd.ToArray();
            return arr;
        }
    }
}