using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 33;
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
         * flag: True if number is self dividing.
         */
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                int temp, digit;
                bool flag;
                for (int i = x; i <= y; i++)
                {
                    flag = true;
                    temp = i;
                    while (temp > 0)
                    {
                        digit = temp % 10;
                        if (digit == 0 || i % digit != 0)
                        {
                            flag = false;
                        }
                        temp = temp / 10;
                    }
                    if (flag)
                        Console.WriteLine("" + i + " is a self dividing no. ");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
            Console.WriteLine();
        }

        public static void printSeries(int n)
        {
            try
            {
                for (int i = 0, c = 1; i < n; i++)
                {
                    for (int j = 0; j < i && c <= n; j++, c++)
                    {
                        Console.Write(i);
                        if (c != n) // to avoid the last comma
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

        public static void printTriangle(int n)
        {
            try
            {
                for (int i = n; i > 0; i--)
                {
                    for (int j = 0; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (i * 2) - 1; j++)
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

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int[] jewels = new int[S.Length];
                int c = 0;
                for (int i = 0; i < J.Length; i++)
                {
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (J[i] == S[j])
                        {
                            jewels[c] = S[j];
                            c++;

                        }
                    }
                }
                if (c != 0)
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

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                int[] subArray = new int[a.Length];

                for (int i = 0; i < a.Length; i++)
                {
                    subArray[i] = a[i];

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
