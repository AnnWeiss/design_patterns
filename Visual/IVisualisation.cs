using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    interface IVisualisation
    {
        void DrawBorder(int n, int m);
        void DrawVals(int val, int i, int j, int rowsCount);
        void RefreshArea();
    }
}
