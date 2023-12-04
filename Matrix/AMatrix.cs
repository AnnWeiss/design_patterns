using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    abstract class ASomeMatrix : IMatrix, IDrawable
    {
        protected IVector[] vectors;
        public IVisualisation Visualisation { get; set; }
        public int ColsCount { get; set; }
        public int RowsCount { get; set; }
        public int this[int row, int col] 
        { 
            get => vectors[row][col]; 
            set => vectors[row][col] = value;
        }
        public ASomeMatrix(int rows, int cols, IVisualisation visualisation)
        {
            ColsCount = cols;
            RowsCount = rows;
            vectors = new IVector[rows];
            for (int i = 0; i < rows; i++)
            {
                vectors[i] = create(cols);
            }
            Visualisation = visualisation;
        }
        public abstract IVector create(int size);
        public void Draw()
        {
            Drawer.DrawMatrixAlgo(Visualisation, this);
        }
        public IMatrix ReturnBase()
        {
            return this;
        }
    }
}
