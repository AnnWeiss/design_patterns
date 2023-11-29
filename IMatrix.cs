using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    interface IMatrix
    {
        int colsCount
        {
            get;
        }
        int rowsCount
        {
            get;
        }
        int this[int row, int col] //индексирование
        {
            get;
            set;
        }
        IVisualisation visualisation
        {
            get;
            set;
        }
        void Draw();
    }
}
