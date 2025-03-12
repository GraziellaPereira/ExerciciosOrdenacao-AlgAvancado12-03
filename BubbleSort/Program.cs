using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };

            void BubbleSort(int[] array)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            BubbleSort(vetor);
            Console.WriteLine(string.Join(", ", vetor));
            Console.ReadKey();
        }
    }
}
