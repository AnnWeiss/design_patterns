using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class Memento : IMemento
    {
        public string State { get; set; }
        Mementable mementable;
        public Memento(string state)
        {
            State = state;
        }
        public void Restore()
        {
        }
    }
}
