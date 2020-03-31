using System;
using System.Collections.Generic;
using System.Text;

namespace minElementMethod
{
    class TrafficCalculator
    {
        public static void MatrixTrafficCheck(Element[,] matrix, int[] demands, int[] stocks)
        {
            newCatch:

            var minValue = int.MaxValue;
            var minRow = 0;
            var minColumn = 0;

            for (var rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++) 
            {
                for (var columnNumber = 0; columnNumber < matrix.GetLength(1); columnNumber++) 
                {
                    if ((demands[columnNumber] != 0) && (stocks[rowNumber] != 0) 
                        && (matrix[rowNumber, columnNumber].Value < minValue)) 
                    {
                        minValue = matrix[rowNumber, columnNumber].Value;
                        minRow = rowNumber;
                        minColumn = columnNumber;
                    }
                }
            }
            if ((demands[minColumn] != 0) && (stocks[minRow] != 0))
            {
                _matrixTrafficCalculate(matrix, demands, stocks, minRow, minColumn);
                goto newCatch;
            }
        }

        private static void _matrixTrafficCalculate(Element[,] matrix, int[] demands, int[] stocks, int rowNumber, int columnNumber)
        {
            if (demands[columnNumber] > stocks[rowNumber]) 
            {
                matrix[rowNumber, columnNumber].Delivery = stocks[rowNumber]; 
                demands[columnNumber] -= stocks[rowNumber];
                stocks[rowNumber] = 0;
            }
            else
            {
                matrix[rowNumber, columnNumber].Delivery = demands[columnNumber];
                stocks[rowNumber] -= demands[columnNumber];
                demands[columnNumber] = 0;
            }
        }
    }
}
