using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class TransposeDecorator : IMatrix
    {
        IMatrix matrix;
        public int ColsCount { get; }
        public int RowsCount { get; }
        public int this[int j, int i]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }
        public TransposeDecorator(IMatrix matrix)
        {
            this.matrix = matrix;
            ColsCount = matrix.RowsCount;
            RowsCount = matrix.ColsCount;
        }
        public IMatrix ReturnBase()
        {
            return matrix;
        }
    }
}
