using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSelection
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };

            void SelectionSort(int[] array)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[j] < array[min])
                        {
                            min = j;
                        }
                    }
                    if (i != min)
                    {
                        int temp = array[i];
                        array[i] = array[min];
                        array[min] = temp;
                    }
                }
            }

            SelectionSort(vetor);
            Console.WriteLine(string.Join(", ", vetor));
            Console.ReadKey();
        }
    }
}
