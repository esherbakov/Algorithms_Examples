using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Examples
{
    public class BubbleSortExample
    {
        public int[] BubbleSort(int[] mas)
        {
            if (mas.Length < 2)
                return mas;
            int temp = new int();
            for (int i = 1; i < mas.Length; i++)
                for (int j = 0; j < mas.Length - i; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            return mas;
        }

        public int[] BubbleSortDesc(int[] mas)
        {
            if (mas.Length < 2)
                return mas;
            int temp = new int();
            for (int i = 1; i < mas.Length; i++)
                for (int j = 0; j < mas.Length - i; j++)
                {
                    if (mas[j] < mas[j + 1])
                    {
                        temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            return mas;
        }
    }
}
