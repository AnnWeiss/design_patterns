using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class SparseMatrix : ASomeMatrix
    {
        public SparseMatrix(int rows, int cols, IVisualisation visualisation) : base(rows, cols, visualisation) { }
        public override IVector create(int size) => new SparseVector(size);
    }
}
