using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class Renumbering_Decorator : IMatrix 
    {
        IMatrix matrix;
        int[] rows, cols;
        public IVisualisation Visualisation { get => Visualisation; set => Visualisation = value; }
        public int ColsCount { get => ColsCount; }
        public int RowsCount { get => RowsCount; }
        public int this[int j, int i]
        {
            get => matrix[rows[j], cols[i]];
            set => matrix[rows[j], cols[i]] = value;
        }
        public Renumbering_Decorator(IMatrix matrix)
        {
            cols = new int[matrix.ColsCount];
            rows = new int[matrix.RowsCount];
            this.matrix = matrix;
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
            Drawer.DrawMatrixAlgo(Visualisation, this);
        }
        public IMatrix ReturnBase()
        {
            return matrix;
        }
    }
}
