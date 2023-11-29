using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class Renumbering_Decorator : IMatrix 
    {
        int _colsCount, _rowsCount;
        SomeMatrix smatrix;
        int[] rows, cols;
        IVisualisation _visualisation;
        public IVisualisation visualisation { get => _visualisation; set => _visualisation = value; }
        public int colsCount { get => _colsCount; }
        public int rowsCount { get => _rowsCount; }
        public int this[int j, int i]
        {
            get => smatrix[rows[j], cols[i]];
            set => smatrix[rows[j], cols[i]] = value;
        }
        public Renumbering_Decorator(IMatrix smatrix)
        {
            cols = new int[smatrix.colsCount];
            rows = new int[smatrix.rowsCount];
            this.smatrix = (SomeMatrix)smatrix;
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = i;
            }
            for (int i = 0; i < cols.Length; i++)
            {
                cols[i] = i;
            }
            RenumberRows();
            RenumberCols();
        }
        private void RenumberRows()
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
        private void RenumberCols()
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
        public void Draw()
        {
            Drawer.DrawMatrixAlgo(visualisation, this);
        }
    }
}
