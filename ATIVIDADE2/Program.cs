using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vetor base desordenado.
            int[] numeros = { 72, 54, 59, 30, 31, 78, 2, 77, 82, 72 }; 

            Console.WriteLine("Vetor Original: " + string.Join(", ", numeros));
            Console.WriteLine("================================");

            // Ordenação usando o método Bubble Sort.
            int[] vetorBubble = (int[])numeros.Clone();
            BubbleSort(vetorBubble);
            Console.WriteLine("Bubble Sort: " + string.Join(", ", vetorBubble));

            // Ordenação usando o método Selection Sort.
            int[] vetorSelection = (int[])numeros.Clone();
            SelectionSort(vetorSelection);
            Console.WriteLine("Selection Sort: " + string.Join(", ", vetorSelection));

            // Ordenação usando o método Insertion Sort.
            int[] vetorInsertion = (int[])numeros.Clone();
            InsertionSort(vetorInsertion);
            Console.WriteLine("Insertion Sort: " + string.Join(", ", vetorInsertion));
        }

        // 1. Bubble Sort
        // Bubble Sort é o método mais lento, porém simples. Os valores altos "flutuam" para a direita.
        static void BubbleSort(int[] arr)
        {
            int temp;
            // Loop externo: Define o limite superior que vai diminuindo
            for (int outer = arr.Length - 1; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        // Troca (Swap)
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
            }
        }

        // 2. Selection Sort
        // Selection Sort é um método intermediário. Ele seleciona o menor valor e o coloca na posição correta.
        static void SelectionSort(int[] arr)
        {
            int minIndex, temp;
            for (int outer = 0; outer < arr.Length; outer++)
            {
                minIndex = outer; // Assume que o atual é o menor

                // Procura o verdadeiro menor no restante do vetor
                for (int inner = outer + 1; inner < arr.Length; inner++)
                {
                    if (arr[inner] < arr[minIndex])
                    {
                        minIndex = inner; // Atualiza o índice do menor valor
                    }
                }

                // Troca (Swap) o menor valor encontrado com o valor na posição 'outer'
                temp = arr[outer];
                arr[outer] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        // 3. Insertion Sort
        // Insertion Sort é o método mais rápido dos três. Ele constrói o vetor ordenado um elemento de cada vez.
        static void InsertionSort(int[] arr)
        {
            int inner, temp;
            for (int outer = 1; outer <arr.Length; outer++)
            {
                temp = arr[outer]; // O valor a ser inserido na parte ordenada 
                inner = outer;

                // Move os elementos da parte ordenada que são maiores que 'temp' para a direita
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp; // Insere 'temp' na posição correta
            }
        }
    }
}
