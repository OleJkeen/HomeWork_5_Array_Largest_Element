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
            int maxLines = 0;
            int maxColumns = 0;
            int minRandomNumber = 10;
            int maxRandomNumber = 99;
            int count = 0;

            int[,] array = new int[numberOfLines, numberOfColumns];
            Random randomArrayNumbers = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = randomArrayNumbers.Next(minRandomNumber + 1, maxRandomNumber + 1);
                    Console.Write(array[i, j] + " ");
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                        maxLines = i;
                        maxColumns = j;
                        array[maxLines, maxColumns] = 0;
                        count = 1;
                    }
                    else if (array[i, j] == maxElement)
                    {
                        count++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-----------------------------\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == maxElement)
                    {
                        array[i, j] = 0;
                        count--;
                    }
                    else if (count == 0)
                    {
                        break;
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

            Console.WriteLine($"\nМаксимальное число в массиве {maxElement}");
            Console.ReadLine();
        }
    }
}
