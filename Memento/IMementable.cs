﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    interface IMementable
    {
        Memento CreateMemento(int i, int j);
    }
}
