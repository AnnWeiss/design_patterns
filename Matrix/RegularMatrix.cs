using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class RegularMatrix : AMatrix
    {
        public RegularMatrix(int rows, int cols) : base(rows, cols) { }
        public override IVector create(int size) => new RegularVector(size);
    }
}
