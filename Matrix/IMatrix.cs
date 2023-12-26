using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    interface IMatrix
    {
        int ColsCount
        {
            get;
        }
        int RowsCount
        {
            get;
        }
        int this[int row, int col] 
        {
            get;
            set;
        }
    }
}
