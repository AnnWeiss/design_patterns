using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class Memento : IMemento
    {
        public int State { get; set; }
        public Memento(int state)
        {
            State = state;
        }
        public void RestoreState(Memento memento)
        {
            State = memento.State;
        }
    }
}
