using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class HorizontalMatrices : IMatrix
    {
        IMatrix matrix;
        public IVisualisation Visualisation { get; set; }
        public int ColsCount { get; set; }
        public int RowsCount { get; set; }
        public int this[int row, int col]
        {
            get => matrix[row, col];
            set => matrix[row, col] = value;
        }
        public void AddMatrix(IMatrix matrx)
        {
            matrix = matrx;
        }
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
