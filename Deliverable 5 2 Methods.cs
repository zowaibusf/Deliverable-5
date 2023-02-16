/*
 Author: Zowaib Farooq
 Date1/31/2023
 Description:This is a C# console application that uses two methods
*/

using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 5 and 15:");

            try
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput >= 5 && userInput <= 15)
                {
                    int[] array = PopulateArray(userInput);

                    Console.WriteLine("The elements of the array are: ");
                    foreach (int item in array)
                    {
                        Console.Write(item + " ");
                    }

                    int sum = SumArray(array);
                    Console.WriteLine("\nThe sum is: " + sum);
                }
                else
                {
                    Console.WriteLine("Invalid input. The number must be between 5 and 15.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. The input must be a valid integer number.");
            }
        }

        static int[] PopulateArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10, 51);
            }

            return array;
        }

        static int SumArray(int[] array)
        {
            int sum = 0;

            foreach (int item in array)
            {
                sum += item;
            }

            return sum;
        }
    }
}
