using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            solvePuzzle();
        }

        /*
         * function: printSelfDividingNumbers()
         * temp: Holds the number to be tested.
         * digit: Individual digits of the number.
         * flag: True, if number is self dividing.
         */
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                int temp, digit;
                bool flag;
                for (int i = x; i <= y; i++) // loop to check every number  in the given range.
                {
                    flag = true;
                    temp = i;
                    while (temp > 0) // loop to check every digit of the number.
                    {
                        digit = temp % 10;
                        if (digit == 0 || i % digit != 0)
                        {
                            flag = false;
                        }
                        temp = temp / 10;
                    }
                    if (flag)
                        Console.WriteLine("" + i + " is a self-dividing no. ");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
            Console.WriteLine();
        }

        /*
         * function: printSeries()
         * c: Count from 1 to the given number.
         */
        public static void printSeries(int n)
        {
            try
            {
                for (int i = 0, c = 1; i < n; i++) // Outer loop to traverse till n.
                {
                    for (int j = 0; j < i && c <= n; j++, c++) // Print number c times.
                    {
                        Console.Write(i);
                        if (c != n) // check to avoid the last comma.
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
            Console.WriteLine();

        }

        /*
         * function: printTriangle()
         */
        public static void printTriangle(int n)
        {
            try
            {
                for (int i = n; i > 0; i--) // Loop to print infividual rows.
                {
                    for (int j = 0; j < n - i; j++) // Loop to print space before the pattern.
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (i * 2) - 1; j++) // Loop to print the pattern.
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        /*
         * function: printSeries()
         * jewels: Store the matched jewels.
         */
        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int[] jewels = new int[S.Length];
                int c = 0;
                for (int i = 0; i < J.Length; i++) // Traverse through every jewel.
                {
                    for (int j = 0; j < S.Length; j++) // Traverse through every stone.
                    {
                        if (J[i] == S[j]) // Compare jewels amd stones.
                        {
                            jewels[c] = S[j];
                            c++;

                        }
                    }
                }
                if (c != 0) // Output if jewels found
                {
                    Console.Write(c + " (Since ");
                    for (int i = 0; i < c; i++)
                    {
                        Console.Write(jewels[i] + " ");
                    }
                    Console.WriteLine(" are jewels.)");
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return 0;
        }

        /*
         * function: getLargestCommonSubArray()
         * temp: Temporary array for swap.
         * subArray: Store largest common sub array.
         */
        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                if (b.Length < a.Length)
                {
                    int[] temp = b;
                    b = a;
                    a = temp;
                }
                int[] subArray = new int[a.Length];

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                        if (a[i] == b[j])
                        {
                            subArray[i] = a[i];
                            //recur

                        }
                        else
                        {

                        }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}
