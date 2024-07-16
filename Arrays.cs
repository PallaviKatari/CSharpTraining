using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class Arrays
    {
        public static void OneDimArray()
        {
            int[] array1 = new int[2] { 1, 2 };
            int[] array2 = new int[] { 11, 2, 31, 14, 25 };
            int[] array3 = { 1, 2, 3,4, 5, 6 };
            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(array2.Length);
            Console.WriteLine(array2.Max());
            Console.WriteLine(array2.Min());
            Console.WriteLine(array2.Sum());
            Console.WriteLine(array2.Average());
            Array.Sort(array2);
            Array.Reverse(array2);
            foreach(int i in array2)
            {
                Console.WriteLine(i);
            }

        }

        public static void TwoDimArray()
        {
            int[,] numbers = new int[,]
            {
                { 1, 2 },
                { 2, 3 },
                { 3, 4 }
            };
            // Control Statements
            // Looping and Conditional
            // Looping - Iteration - Entry (while,for) ,Exit (do-while)
            // Conditional - simple if, if-else, else if, nested if , switch-case

            for(int i = 0;i<3;i++)
            {
                for(int j = 0;j<2;j++)
                {
                    Console.Write(numbers[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Array of Arrays
        /// </summary>
        public static void JaggedArray()
        {
            int[][] arrays = new int[][]
            {
                new int[3]{1,2,3},// 0th index
                new int[2]{4,5}, // 1st index
                new int[3]{5,6,7} // 2nd index
            };
            for (int i = 0; i<arrays.Length;i++)
            {
                for(int j = 0; j < arrays[i].Length;j++)
                {
                    Console.Write($"{arrays[i][j]}");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            OneDimArray();
            Console.WriteLine("************************");
            TwoDimArray();
            Console.WriteLine("************************");
            JaggedArray();
            Console.ReadLine();
            
        }
    }
}
