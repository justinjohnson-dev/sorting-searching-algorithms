using System;
namespace sorting_searching.Searches
{
    public class BinarySearch
    {
        public int RecursiveSearch(int[] list, int key, int low, int high)
        {
            if (low > high)
            {
                return -low - 1;
            }

            int mid = (low + high) / 2;
            if (key.Equals(mid))
            {
                return mid;
            }
           
            if (key.CompareTo(mid) < 0)
            {
                return RecursiveSearch(list, key, low, mid - 1);
            }
            else
            {
                return RecursiveSearch(list, key, mid + 1, high);
            }
        }
    }
}
