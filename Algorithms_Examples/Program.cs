using System;

namespace Algorithms_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSortExample bubbleSort = new BubbleSortExample();
            int[] mas = { 1, 5, 3, 4, 2 };
            foreach (int item in bubbleSort.BubbleSort(mas))
                Console.Write($"{item}, ");
            Console.WriteLine();
            foreach (int item in bubbleSort.BubbleSortDesc(mas))
                Console.Write($"{item}, ");
            Console.ReadKey();
        }
    }
}
