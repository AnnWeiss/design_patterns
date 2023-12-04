using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    interface IVector
    {
        int dimension
        {
            get;
        }
        int this[int index] //индексирование
        {
            get;
            set;
        }
    }
}
