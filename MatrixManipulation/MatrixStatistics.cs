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
            for (int i = 0; i < matrix.RowsCount; i++)
            {
                for (int j = 0; j < matrix.ColsCount; j++)
                {
                    sum += matrix[i,j];
                }
            }
            return sum;
        }
        public double AvgValue() 
        {
            int sum = 0;
            for (int i = 0; i < matrix.RowsCount; i++)
            {
                for (int j = 0; j < matrix.ColsCount; j++)
                {
                    sum += matrix[i,j];
                }
            }
            return sum/matrix.RowsCount*matrix.ColsCount;
        }
        public int MaxValue() 
        {
            int max = 0;
            for (int i = 0; i < matrix.RowsCount; i++)
            {
                for (int j = 0; j < matrix.ColsCount; j++)
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
            for (int i = 0; i < matrix.RowsCount; i++)
            {
                for (int j = 0; j < matrix.ColsCount; j++)
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
