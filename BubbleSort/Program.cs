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

            void BubbleSort(int[] numeros)
            {
                int n = numeros.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (numeros[j] > numeros[j + 1])
                        {
                            int temp = numeros[j];
                            numeros[j] = numeros[j + 1];
                            numeros[j + 1] = temp;
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
