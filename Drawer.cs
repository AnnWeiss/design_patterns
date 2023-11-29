using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class Drawer
    {
        public static void DrawMatrixAlgo(IVisualisation visualisation, IMatrix mtrx)
        {
            visualisation.RefreshArea();
            visualisation.DrawBorder(mtrx.colsCount, mtrx.rowsCount);
            for (int i = 0; i < mtrx.colsCount; i++)
            {
                for (int j = 0; j < mtrx.rowsCount; j++)
                {
                    visualisation.DrawVals(mtrx[i,j], i, j, mtrx.rowsCount);
                }
            }
        }
    }
}
