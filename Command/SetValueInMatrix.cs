using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class SetValueInMatrix : ICommand
    {
        IMatrix matrx;
        int row, col, val;
        public SetValueInMatrix(IMatrix matrx, int row, int col, int val)
        {
            this.matrx = matrx;
            this.col = col;
            this.row = row;
            this.val = val;
        }
        public void Execute()
        {
            matrx[row, col] = val;
        }
        public void Undo()
        {
            //blyaaa a kak kakat'
        }
    }
}
