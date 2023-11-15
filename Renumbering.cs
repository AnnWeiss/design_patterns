using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class Renumbering : IMatrix //decorator
    {
        int _colsCount, _rowsCount;
        SomeMatrix smatrix;
        int[] rows, cols;
        IVisualisation visualisation;
        public int colsCount { get => _colsCount; }
        public int rowsCount { get => _rowsCount; }
        public int this[int row, int col]
        {
            get => smatrix._vectors[row][col];
            set => smatrix._vectors[row][col] = value;
        }
        public Renumbering(SomeMatrix smatrix)
        {
            cols = new int[smatrix.colsCount];
            rows = new int[smatrix.rowsCount];
            this.smatrix = smatrix;
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = i;
            }
            for (int i = 0; i < cols.Length; i++)
            {
                cols[i] = i;
            }
        }
        public void RenumberRows()
        {
            Random rnd = new Random();
            int first = rnd.Next(0, rows.Length - 1);
            int second = rnd.Next(0, rows.Length - 1);
            while (first == second)
            {
                first = rnd.Next(0, rows.Length - 1);
                second = rnd.Next(0, rows.Length - 1);
            }
            int tmp = rows[first];
            rows[first] = rows[second];
            rows[second] = tmp;
        }
        public void RenumberCols()
        {
            Random rnd = new Random();
            int first = rnd.Next(0, rows.Length - 1);
            int second = rnd.Next(0, rows.Length - 1);
            while (first == second)
            {
                first = rnd.Next(0, rows.Length - 1);
                second = rnd.Next(0, rows.Length - 1);
            }
            int tmp = cols[first];
            cols[first] = cols[second];
            cols[second] = tmp;
        }
        public void setDrawer(IVisualisation visualisation)
        {
            this.visualisation = visualisation;
        }
        public void DrawMe()
        {
            smatrix.visualisation = visualisation;
            RefreshArea();
            DrawBorder(cols.Length, rows.Length);
            for (int i = 0; i < cols.Length; i++)
            {
                for (int j = 0; j < rows.Length; j++)
                {
                    DrawVals(this[i, j], i, j, rows.Length);
                }
            }
        }
        private void RefreshArea() => visualisation.RefreshArea();
        private void DrawVals(int val, int i, int j, int rowsCount) => visualisation.DrawVals(val, i, j, rowsCount);
        private void DrawBorder(int colsCount, int rowsCount) => visualisation.DrawBorder(colsCount, rowsCount);
    }
}
