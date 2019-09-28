using System;
using System.Collections;

namespace gfg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 1, 2, 3, 4, 5, 11, 10, 9 };
            bool result = ArrayOperation.CheckForPair(arr, 5);

          //  Assert.AreEqual(result, true);
        }
    }

    public class ArrayOperation
    {
        //Given an array A[] and a number x, check for pair in A[] with sum as x
        public static bool CheckForPair(int[] arr, int targetSum)
        {
            // result value that carry the result
            bool result = false;

            //sort array           
            Array.Sort(arr);

            int low, heigh;

            // low is the first item in the array
            low = 0;
            // heigh id the last item in the array
            heigh = arr.Length - 1;

            while (low < heigh)
            {
                if (arr[low] + arr[heigh] == targetSum)
                {
                    result = true;
                    break;
                }
                if (arr[low] + arr[heigh] < targetSum)
                {

                    // increase low                    
                    low++;                    
                }
                else
                {
                    // decreasde the high
                    heigh--;
                }
            }
            // return the result
            return result;
        }


        public static bool CheckForPair_Hash(int[] arr, int targetSum)
        {
            // result value that carry the result
            bool result = false;
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < arr.Length; i++)
            {
                // if the other pair found in the hash table
                if (hashtable.ContainsKey(Math.Abs( arr[i] - targetSum)))
                {
                    result = true;
                    break;
                }
                else
                {
                    hashtable.Add(arr[i], null);
                }
                
            }

            // return the result
            return result;
        }
    }
}
