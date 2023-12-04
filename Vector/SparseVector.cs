using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class SparseVector : IVector
    {
        int _dimension;
        Dictionary<int, int> values = new Dictionary<int, int>();
        public int this[int index] //индексирование
        {
            get 
            {
                int value = values.TryGetValue(index, out value) ? value : 0;
                return value;
            }
            set { values[index] = value; }
        }
        public SparseVector(int dimension)
        {
            _dimension = dimension;
        }
        public int dimension  
        {
            get => _dimension;
        }
    }
}
