using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class VerticalMatrices : IMatrix
    {
        List<IMatrix> matrices;
        public IVisualisation Visualisation { get; set; }

        //принадлежность ячейки к определенной матрице
        Dictionary<(int,int), int> cellMembership;
        public int ColsCount { get; set; }
        public int RowsCount { get; set; }

        public int this[int row, int col]
        {
            get
            {
                int numOfMatrx = cellMembership[(row,col)];
                if (matrices[numOfMatrx].RowsCount - 1 < row)
                {
                    return 0;
                }
                var im = matrices[numOfMatrx];
                return im[row, col];
            }
            set
            {
                int numOfMatrx = cellMembership[(row, col)];
                var im = matrices[numOfMatrx];
                if (matrices[numOfMatrx].RowsCount < row)
                {
                    throw new Exception("запрос не соответствует существующему элементу!");
                }
                im[row, col] = value;
            }
        }
        public VerticalMatrices()
        {
            cellMembership = new Dictionary<(int,int), int>();
            matrices = new List<IMatrix>();
        }
        public void AddMatrix(IMatrix matrx)
        {
            matrices.Add(matrx);

            if (ColsCount < matrx.ColsCount)
            {
                int addCols = matrx.ColsCount - ColsCount;

                if (addCols < 0) { addCols *= -1; }

                ColsCount += addCols;
            }

            for (int i = 0; i < matrx.ColsCount; i++)
            {
                for (int j = 0; j < matrx.RowsCount; j++)
                {
                    cellMembership[(RowsCount, i)] = matrices.Count - 1;
                    RowsCount += 1;
                }
            }
        }
        public void AddTransposeMatrix(IMatrix matrx)
        {
            var matrxTr = new TransposeDecorator(matrx);
            matrices.Add(matrxTr);

            if (ColsCount < matrx.ColsCount)
            {
                int addCols = matrx.ColsCount - ColsCount;

                if (addCols < 0) { addCols *= -1; }

                ColsCount += addCols;
            }

            for (int i = 0; i < matrxTr.ColsCount; i++)
            {
                for (int j = RowsCount; j < matrxTr.RowsCount; j++)
                {
                    cellMembership[(j, i)] = matrices.Count - 1;
                    RowsCount += 1;
                }
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
        public int GetSumCols()
        {
            var sumCols = matrices.Sum(r => r.ColsCount);
            return sumCols;
        }
    }
}
