using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };

            void InsertionSort(int[] array)
            {
                int n = array.Length;
                for (int j = 1; j < n; j++)
                {
                    int chave = array[j];
                    int i = j - 1;
                    while (i >= 0 && array[i] > chave)
                    {
                        array[i + 1] = array[i];
                        i--;
                    }
                    array[i + 1] = chave;
                }
            }

            InsertionSort(vetor);
            Console.WriteLine("Vetor ordenado:");
            Console.WriteLine(string.Join(", ", vetor));
        }
    }
}
