using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_Array_Largest_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfColumns = 10;
            int numberOfLines = 10;
            int maxElement = int.MinValue;
            int minRandomNumber = 10;
            int maxRandomNumber = 99;

            int[,] array = new int[numberOfLines, numberOfColumns];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minRandomNumber, maxRandomNumber + 1);
                    Console.Write(array[i, j] + " ");
                    
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nМаксимальное число в массиве {maxElement}");
            Console.WriteLine("\n\n-----------------------------\n");

            for (int i =0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement == array[i, j])
                    {
                        array[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
