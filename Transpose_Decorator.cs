using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class Transpose_Decorator : IMatrix
    {
        IMatrix matrix;
        public IVisualisation Visualisation { get; set; }
        public int ColsCount { get; }
        public int RowsCount { get; }
        public int this[int j, int i]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }
        public Transpose_Decorator(IMatrix matrix)
        {
            this.matrix = matrix;
        }
        public void Draw()
        {
            Drawer.DrawMatrixAlgo(Visualisation, this);
        }
        public IMatrix ReturnBase()
        {
            return matrix;
        }
    }
}
