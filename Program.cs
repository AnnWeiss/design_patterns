using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MenuForm());
            
            Console.ReadKey(true);
        }
    }
}
