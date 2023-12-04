using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace design_patterns
{
    class VisualInConsole : IVisualisation
    {
        public bool border { get; set; }
        public bool elems { get; set; }
        public VisualInConsole(bool border, bool elems)
        {
            this.border = border;
            this.elems = elems;
        }
        public VisualInConsole()
        {
            border = true;
            elems = true;
        }
        public void RefreshArea()
        {
            Console.Clear();
        }
        public void DrawBorder(int colsCount, int rowsCount) 
        {
            string text = "20\t20\t20\t20\t20\t";
            var border = $"+{"".PadLeft(text.Length + 27, '-')}+";
            if (!this.border)
            {
                Console.SetCursorPosition(3, 1);
                return;
            }
            text = "20\t20\t20\t20\t20\t";
            border = $"+{"".PadLeft(text.Length + 27, '-')}+";
            Console.WriteLine(border);
            text = "";
            for (int i = 0; i < colsCount; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    if (j == rowsCount - 1)
                    {
                        text = string.Concat(text, " " + " ");
                        continue;
                    }
                    text = string.Concat(text, " " + "\t");
                }
                Console.WriteLine($"| {text} |");
                text = "";
            }
            Console.WriteLine(border);
        }
        public void DrawVals(int val, int i, int j, int rowsCount)
        {
            if (i == 0 && j == 0)
            {
                Console.SetCursorPosition(1, 1);
            }
            if (val == 0 && j != rowsCount - 1)
            {
                Console.Write(" " + " " + "\t");
                return;
            }
            if (j == rowsCount - 1)
            {
                if (val == 0)
                {
                    Console.Write(" " + " " + "\n");
                    return;
                }
                Console.Write(val + " "+"\n");
                return;
            }
            Console.Write(val + " " + "\t");
        }
    }
}


