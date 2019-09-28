using System;
using System.Linq;
namespace ProgramForArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            //RotationWithMyWay(arr);
            RotationWithJuggling(arr, d);
            Console.Read();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        private static void RotationWithMyWay(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1];
                arr[arr.Length - 1] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        private static void RotationWithJuggling(int[] arr , int d)
        {
            int temp;
            int gcd = GCD(arr.Length, d);
            for (int i = 0; i < gcd; i++)
            {
                int j = i;
                int k = j + d;
                temp = arr[i];
                while (true)
                {                                                       
                    arr[j] = arr[k];
                    j = k;
                    k += d;
                    if (k >= arr.Length)
                    {
                        k = k - arr.Length;
                    }
                    if (k == i)
                    {
                        break;
                    }
                }
                arr[j] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        private static int GCD(int a, int b)
        {
            if (a % b != 0)
            {
               return GCD(b, a % b);
            }
            else
            {
                return (b);
            }

           
        }
        static void leftRotate(int[] arr, int d,
                         int n)
        {
            int i, j, k, temp;
            for (i = 0; i < GCD(d, n); i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }

    }
}
