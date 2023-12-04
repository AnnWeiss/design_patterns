using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class HorizontalMatrices : IMatrix
    {
        List<IMatrix> matrices;
        public IVisualisation Visualisation { get; set; }

        //принадлежность столбца к определенной матрице
        Dictionary<int, int> colMembership;
        public int ColsCount { get; set; }
        public int RowsCount { get; set; }

        public int this[int row, int col]
        {
            get
            {
                int numOfMatrx = colMembership[col];
                if (matrices[numOfMatrx].RowsCount - 1 < row)
                {
                    return 0;
                }
                var im = matrices[numOfMatrx];
                return im[row, col];
            }
            set
            {
                int numOfMatrx = colMembership[col];
                var im = matrices[numOfMatrx];
                if (matrices[numOfMatrx].RowsCount - 1 < row)
                {
                    throw new Exception("запрос не соответствует существующему элементу!");
                }
                im[row, col] = value;
            }
        }
        public HorizontalMatrices()
        {
            colMembership = new Dictionary<int, int>();
            matrices = new List<IMatrix>();
        }
        public void AddMatrix(IMatrix matrx)
        {
            matrices.Add(matrx);

            if(RowsCount < matrx.RowsCount)
            {
                int addRows = matrx.RowsCount - RowsCount;
                RowsCount += addRows;
            }

            for (int i = ColsCount; i < matrx.ColsCount; i++)
            {
                colMembership.Add(i, matrices.Count - 1);
                ColsCount += 1;
            }
        }
        public void Draw()
        {
            Drawer.DrawMatrixAlgo(Visualisation, this);
        }
        public IMatrix ReturnBase()
        {
            return this;
        }
        public int GetMaxRows()
        {
            var maxRows = matrices.Max(r => r.RowsCount);
            return maxRows;
        }
    }
}
