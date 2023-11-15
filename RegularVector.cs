using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class RegularVector : IVector
    {
        int _dimension;
        int[] array;
        public int this[int index] //индексирование
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public int dimension
        {
            get => _dimension;
        }
        public RegularVector(int dimension)
        {
            _dimension = dimension;
            array = new int[dimension];
        }
    }
}
