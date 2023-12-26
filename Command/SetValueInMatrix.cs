using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    
    class SetValueInMatrix : ICommand
    {
        int row, col, val;

        protected
        AMatrix receiver;
        public SetValueInMatrix(AMatrix matrx, int row, int col, int val)
        {
            receiver = matrx;
            this.col = col;
            this.row = row;
            this.val = val;
        }
        public void Execute()
        {
            //receiver[row, col] = val;
            //mementos[numCommands] = receiver.CreateMemento(i,j);
            //commands[numCommands] = this;
            //if (numCommands > highWater)
            //    highWater = numCommands;
            //numCommands++;
            
        }
        public void Undo()
        {
           // if (numCommands == 0)
           // {
           //     return;
           // }
           // receiver.ReinstateMemento() = commands[numCommands - 1];
           //(mementos[numCommands - 1]);
           // _numCommands--;
        }
    }
}
