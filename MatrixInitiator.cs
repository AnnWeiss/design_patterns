using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    static class MatrixInitiator
    {
       public static void FillMatrix(IMatrix matrix, int nonZeroCount, int maxValue)
       {
            Random rnd = new Random();
            int curCount = 0;
            if (nonZeroCount > matrix.RowsCount * matrix.ColsCount)
            {
                throw new Exception("Число элементов больше числа элементов в матрице!");
            }
            for (int i = 0; i < matrix.RowsCount; i++)
            {
                for (int j = 0; j < matrix.ColsCount; j++)
                {
                    curCount++;
                    if (curCount > nonZeroCount) { return; }
                    matrix[i,j] = rnd.Next(1, maxValue);
                }
            }
       }
    }
}
