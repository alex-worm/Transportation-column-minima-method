using System;
using System.Collections.Generic;
using System.Text;

namespace minElementMethod
{
    class InputAndOutput
    {
        public static int GetNumberFromUser(string message)
        {
            Console.Write(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        public static void ResultOutput(Element[,] matrix)
        {
            Console.WriteLine("\nResult matrix:");

            for (var rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++) 
            {
                Console.WriteLine();
                for (var columnNumber = 0; columnNumber < matrix.GetLength(1); columnNumber++)
                {
                        Console.Write($"{matrix[rowNumber, columnNumber].Delivery}\t");
                }
            }

            var function = 0;

            for (var rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++)
            {
                Console.WriteLine();
                for (var columnNumber = 0; columnNumber < matrix.GetLength(1); columnNumber++)
                {
                    function += matrix[rowNumber, columnNumber].Delivery * matrix[rowNumber, columnNumber].Value;
                }
            }

            Console.WriteLine($"The function value is equal to {function}");
        }
    }
}
