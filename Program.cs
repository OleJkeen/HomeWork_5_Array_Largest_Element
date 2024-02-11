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
            int numberForMaxElement = 0;

            int[,] arrayNumbers = new int[numberOfLines, numberOfColumns];
            Random random = new Random();

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    arrayNumbers[i, j] = random.Next(minRandomNumber, maxRandomNumber + 1);
                    Console.Write(arrayNumbers[i, j] + " ");
                    if (maxElement < arrayNumbers[i, j])
                    {
                        maxElement = arrayNumbers[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nМаксимальное число в массиве {maxElement}");
            Console.WriteLine("\n\n-----------------------------\n");

            for (int i =0; i < arrayNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    if (maxElement == arrayNumbers[i, j])
                    {
                        arrayNumbers[i, j] = numberForMaxElement;
                    }
                }
            }

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    Console.Write(arrayNumbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
