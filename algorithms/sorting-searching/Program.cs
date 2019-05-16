using System;
using sorting_searching.Sorts;
using sorting_searching.Searches;

namespace sorting_searching
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAlgorithms();
        }

        // TODO:
        // Create a way for user to decide which algorithm they want to use
        // Allow user to input their own numbers
        // For searching algoritm, let user choose which number they want to find

        public static void RunAlgorithms()
        {
            // array we are running the algorithms on
            var array = new int[] { 5, 9, 1, 0, 60, 2, 88, 4 };


            // BubbleSort
            var bubbleSort = new BubbleSort(array);

            Console.WriteLine($"Sorted Array using BubbleSort is ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();


            // Binary Search and necessary variables
            var binarySearch = new BinarySearch();
            var key = 9;
            var min = array[0];
            var lengthOfArray = array.Length - 1;
            var max = array[lengthOfArray];

            Console.WriteLine($"Min number is {min}");
            Console.WriteLine($"Max number is {max}");
            Console.WriteLine($"Recursive Binary Search result is {binarySearch.RecursiveSearch(array, key, min, max)}");
        }
    }
}
