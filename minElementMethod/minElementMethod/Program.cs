using System;

namespace minElementMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMatrix = MatrixInitializer.MatrixInitialize();

            (int[] demands, int[] stocks) = DemandsAndStocksInitializer.DemandsAndStocksInitialize(mainMatrix);

            TrafficCalculator.MatrixTrafficCheck(mainMatrix, demands, stocks);

            InputAndOutput.ResultOutput(mainMatrix);

            Console.ReadKey();
        }
    }
}
