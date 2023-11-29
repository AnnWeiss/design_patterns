using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    abstract class SomeMatrix : IMatrix, IDrawable
    {
        int _colsCount, _rowsCount;
        IVisualisation _visualisation;
        protected IVector[] vectors;
        public IVisualisation visualisation { get => _visualisation; set => _visualisation = value; }
        public int colsCount { get => _colsCount; }
        public int rowsCount { get => _rowsCount; }
        public int this[int row, int col] 
        { 
            get => vectors[row][col]; 
            set => vectors[row][col] = value;
        }
        public SomeMatrix(int rows, int cols, IVisualisation visualisation)
        {
            _colsCount = cols;
            _rowsCount = rows;
            vectors = new IVector[rows];
            for (int i = 0; i < rows; i++)
            {
                vectors[i] = create(cols);
            }
            this.visualisation = visualisation;
        }
        public abstract IVector create(int size);
        public void Draw()
        {
            Drawer.DrawMatrixAlgo(visualisation, this);
        }
    }
    class RegularMatrix : SomeMatrix
    {
        public RegularMatrix(int rows, int cols, IVisualisation visualisation) : base(rows, cols, visualisation) { }
        public override IVector create(int size) => new RegularVector(size);
    }
    class SparseMatrix : SomeMatrix
    {
        public SparseMatrix(int rows, int cols, IVisualisation visualisation) : base(rows, cols, visualisation) { }
        public override IVector create(int size) => new SparseVector(size);
    }
}
