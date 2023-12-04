using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class CommandHandler
    {
        int index;
        List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            if(index < commands.Count)
            {
                commands.RemoveRange(index, commands.Count - index);
            }
            commands.Add(command);
            command.Execute();
            index++;
        }

        public void UndoCommand()
        {
            if (commands.Count == 0) { return; }

            if (index > 0)
            {
                commands[index - 1].Undo();
                index--;
            }
        }
    }
}
