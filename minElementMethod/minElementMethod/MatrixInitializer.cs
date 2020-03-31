using System;
using System.Collections.Generic;
using System.Text;

namespace minElementMethod
{
    class MatrixInitializer
    {
        public static Element[,] MatrixInitialize()
        {
            int rowsNumber = InputAndOutput.GetNumberFromUser("Enter number of rows : ");
            int columnsNumber = InputAndOutput.GetNumberFromUser("Enter number of columns : ");

            Element[,] matrix = new Element[rowsNumber, columnsNumber];

            _matrixRateInitialize(matrix);

            return matrix;
        }

        private static void _matrixRateInitialize(Element[,] matrix)
        {
            for (var rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++)
            {
                for (var columnNumber = 0; columnNumber < matrix.GetLength(1); columnNumber++)
                {
                    matrix[rowNumber, columnNumber].Value = InputAndOutput.
                        GetNumberFromUser($"Enter rate of [{rowNumber}, {columnNumber}] : ");
                }
            }
        }
    }
}
