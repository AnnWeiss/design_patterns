using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class RenumberingDecorator : IMatrix 
    {
        IMatrix matrix;
        Random rnd;

        int[] rows, cols;
        public IVisualisation Visualisation { get; set; }
        public int ColsCount { get; }
        public int RowsCount { get; }
        public int this[int j, int i]
        {
            get => matrix[rows[j], cols[i]];
            set => matrix[rows[j], cols[i]] = value;
        }
        public RenumberingDecorator(IMatrix matrix)
        {
            cols = new int[matrix.ColsCount];
            rows = new int[matrix.RowsCount];

            ColsCount = matrix.ColsCount;
            RowsCount = matrix.RowsCount;

            this.matrix = matrix;

            rnd = new Random();

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
