using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    abstract class AMatrix : IMatrix, IMementable
    {
        int state;
        protected IVector[] vectors;
        public int ColsCount { get; set; }
        public int RowsCount { get; set; }
        public int this[int row, int col] 
        { 
            get => vectors[row][col]; 
            set => vectors[row][col] = value;
        }
        public AMatrix(int rows, int cols)
        {
            ColsCount = cols;
            RowsCount = rows;
            vectors = new IVector[rows];
            for (int i = 0; i < rows; i++)
            {
                vectors[i] = create(cols);
            }
        }
        public abstract IVector create(int size);
        public IMatrix ReturnBase()
        {
            return this;
        }
        public Memento CreateMemento(int i, int j)
        {
            return new Memento(this[i, j]);
        }
        public void ReinstateMemento(Memento memo, int i, int j)
        {
            this[i, j] = memo.State;
        }
    }
}
