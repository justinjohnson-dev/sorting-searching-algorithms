using System;

namespace sorting_searching.Sorts
{
    public class BubbleSort
    {
        public BubbleSort(int[] array)
        {
            for (int min = 0; min < array.Length; min++)
            {
                Bubble(array, min);
            }
        }

        public void Bubble(int[] array, int min)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstNumber = array[i];
                int secondNumber = array[i + 1];

                if (firstNumber > secondNumber)
                {
                    Swap(array, i, i + 1);
                }
            }
        }

        public void Swap(int[] array, int numberOne, int numberTwo)
        {
            int temp = array[numberOne];
            array[numberOne] = array[numberTwo];
            array[numberTwo] = temp;
        }
    }
}
