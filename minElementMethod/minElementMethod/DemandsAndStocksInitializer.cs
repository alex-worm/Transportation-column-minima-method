using System;
using System.Collections.Generic;
using System.Text;

namespace minElementMethod
{
    class DemandsAndStocksInitializer
    {
        public static (int[], int[]) DemandsAndStocksInitialize(Element[,] matrix)
        {
            int[] demands = new int[matrix.GetLength(1)];
            for (var rowNumber = 0; rowNumber < matrix.GetLength(1); rowNumber++)
            {
                demands[rowNumber] = InputAndOutput.GetNumberFromUser($"Enter demand #{rowNumber} : ");
            }

            int[] stocks = new int[matrix.GetLength(0)];
            for (var columnNumber = 0; columnNumber < matrix.GetLength(0); columnNumber++)
            {
                stocks[columnNumber] = InputAndOutput.GetNumberFromUser($"Enter stock #{columnNumber} : ");
            }
            return (demands, stocks);
        }
    }
}
