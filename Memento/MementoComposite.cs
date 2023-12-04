using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class MementoComposite : IMemento
    {
        public string State { get; set; }
        public void Add(Memento memento)
        {
            State = memento.State;
        }
        public void Restore()
        {

        }
    }
}
