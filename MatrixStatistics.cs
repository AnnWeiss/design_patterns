using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class MatrixStatistics
    {
        IMatrix matrix;
        public MatrixStatistics(IMatrix matrix)
        {
            this.matrix = matrix;
        }
        public int SumValues() 
        {
            int sum = 0;
            for (int i = 0; i < matrix.rowsCount; i++)
            {
                for (int j = 0; j < matrix.colsCount; j++)
                {
                    sum += matrix[i,j];
                }
            }
            return sum;
        }
        public double AvgValue() 
        {
            int sum = 0;
            for (int i = 0; i < matrix.rowsCount; i++)
            {
                for (int j = 0; j < matrix.colsCount; j++)
                {
                    sum += matrix[i,j];
                }
            }
            return sum/matrix.rowsCount*matrix.colsCount;
        }
        public int MaxValue() 
        {
            int max = 0;
            for (int i = 0; i < matrix.rowsCount; i++)
            {
                for (int j = 0; j < matrix.colsCount; j++)
                {
                    if(matrix[i,j] > max)
                    {
                        max = matrix[i,j];
                    }
                }
            }
            return max;
        }
        public int NonZeroCount() 
        {
            int count = 0;
            for (int i = 0; i < matrix.rowsCount; i++)
            {
                for (int j = 0; j < matrix.colsCount; j++)
                {
                    if (matrix[i,j] != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
