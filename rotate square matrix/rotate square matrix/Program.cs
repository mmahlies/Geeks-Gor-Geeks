// C# program to print a given 
// matrix in spiral form 
using System;

class GFG
{
    // Function print matrix in spiral form 
    static void spiralPrint(int m, int n, int[,] a)
    {
        int i, k = 0, l = 0;
        /* k - starting row index 
		m - ending row index 
		l - starting column index 
		n - ending column index 
		i - iterator 
		*/

        while (k < m && l < n)
        {
            // Print the first row 
            // from the remaining rows 
            for (i = l; i < n; ++i)
            {
                Console.Write(a[k, i] + " ");
            }
            k++;

            // Print the last column from the 
            // remaining columns 
            for (i = k; i < m; ++i)
            {
                Console.Write(a[i, n - 1] + " ");
            }
            n--;

            // Print the last row from 
            // the remaining rows 
            //  if (k < rowEnd)
            {
                for (i = n - 1; i >= l; --i)
                {
                    Console.Write(a[m - 1, i] + " ");
                }
                m--;
            }

            // Print the first column from 
            // the remaining columns 
            //if (columnStart < columnEnd)
            {
                for (i = m - 1; i >= k; --i)
                {
                    Console.Write(a[i, l] + " ");
                }
                l++;
            }
        }
    }

    // to rotate the matrix by 90 deg
    static void Rotate90Deg(int rowEnd, int columnEnd, int[,] a)
    {
        int i, rowStart = 0, columnStart = 0;
        /* rowStart - starting row index 
		rowEnd - ending row index 
		columnStart - starting column index 
		columnEnd - ending column index 
		i - iterator 
		*/

        while (rowStart < rowEnd && columnStart < columnEnd)
        {
            // Print the first row 
            // from the remaining rows 
            for (i = columnStart; i < columnEnd; ++i)
            {
                Console.Write(a[rowStart, i] + " ");
            }
            rowStart++;

            // Print the last column from the 
            // remaining columns 
            for (i = rowStart; i < rowEnd; ++i)
            {
                Console.Write(a[i, columnEnd - 1] + " ");
            }
            columnEnd--;

            // Print the last row from 
            // the remaining rows 
            //  if (k < rowEnd)
            {
                for (i = columnEnd - 1; i >= columnStart; --i)
                {
                    Console.Write(a[rowEnd - 1, i] + " ");
                }
                rowEnd--;
            }

            // Print the first column from 
            // the remaining columns 
            //if (columnStart < columnEnd)
            {
                for (i = rowEnd - 1; i >= rowStart; --i)
                {
                    Console.Write(a[i, columnStart] + " ");
                }
                columnStart++;
            }
        }
    }

    // Driver program 
    public static void Main()
    {
        int R = 5;
        int C = 5;
        int[,] a = {
                    { 2, 3, 4, 5 , 6},
                    { 17, 18, 19, 20, 7},
                    { 16, 25, 26, 21, 8 },
                    { 15, 24, 23, 22, 9}   ,
                    { 14, 13, 12, 11, 10}
                      };
        spiralPrint(R, C, a);
        var c = "";
    }
}

// This code is contributed by Sam007 
