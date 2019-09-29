using System;

namespace gfg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class ArrayOperaion
    {
        public static int Find(int[] arr, int target)
        {


            int pivotIndex = FindPivot(arr, 0, arr.Length - 1);

            // there are no pivot search for item by binary search with O(logn)
            if (pivotIndex == -1)
            {
                return BinarySearch(arr, 0, arr.Length - 1, target);
            }

            //second array after pivot element
            if (arr[pivotIndex] <= target && arr[arr.Length - 1] >= target)
            {
                return BinarySearch(arr, pivotIndex, arr.Length - 1, target);
            }
            else//first array befotr pivot element
            {
                return BinarySearch(arr, 0, pivotIndex - 1, target);
            }


        }

        // find pivot index
        private static int FindPivot(int[] arr, int l, int h)
        {
            int pivotIndex = -1;
            int mid = (l + h) / 2;

            // mid is the pivot
            if (arr[mid] < arr[mid - 1])
            {
                return mid;
            }

            if (arr[mid] > h)
            {
                return FindPivot(arr, mid + 1, h);
            }
            if (arr[mid] < l)
            {
                return FindPivot(arr, l, mid - 1);
            }


            return pivotIndex;

        }

        private static int BinarySearch(int[] arr, int l, int h, int target)
        {
            if (l > h)
            {
                return -1;
            }
            int mid = (l + h) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] > target)
            {
                return BinarySearch(arr, l, mid - 1,target);
            }
            else // (arr[mid] < target)
            {
                return BinarySearch(arr, mid + 1, h,target);
            }


          

        }
    }
}
