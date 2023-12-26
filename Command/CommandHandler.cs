using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    class CommandHandler
    {
        Stack<ICommand> commands = new Stack<ICommand>();
        private static CommandHandler instance;
        private CommandHandler() { }

        public static CommandHandler GetInstance()
        {
            if (instance == null) { instance = new CommandHandler(); }
            return instance;
        }

        public void AddCommand(ICommand command)
        {
            commands.Push(command);
            command.Execute();
        }

        public void UndoCommand()
        {
            if (commands.Count == 0) { return; }

            ICommand command = commands.Pop();
            command.Undo();
        }
    }
}
