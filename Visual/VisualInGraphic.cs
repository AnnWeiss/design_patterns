using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace design_patterns
{
    class VisualInGraphic : IVisualisation
    {
        FormDraw frm;
        Graphics flagGraphics;
        public bool border { get; set; }
        public bool elems { get; set; }
        public VisualInGraphic(bool border, bool elems)
        {
            frm = new FormDraw();
            this.border = border;
            this.elems = elems;
            flagGraphics = Graphics.FromImage(frm._bmp);
        }
        public VisualInGraphic()
        {
            frm = new FormDraw();
            border = true;
            elems = true;
            flagGraphics = Graphics.FromImage(frm._bmp);
        }
        public void RefreshArea()
        {
            flagGraphics.Clear(Color.White);
        }
        public void DrawBorder(int colsCount, int rowsCount)
        {
            Graphics flagGraphics = Graphics.FromImage(frm._bmp);
            flagGraphics.FillRectangle(Brushes.White, 0, 0, frm._bmp.Width, frm._bmp.Height);
            frm.mainPictureBox.Image = frm._bmp;
            frm.mainPictureBox.Invalidate();
            Font font = new Font("Arial", 16, GraphicsUnit.Pixel);

            if (!border) return;
            string[] s = new string[colsCount + 2];
            for (int i = 0; i < 5 * rowsCount; i++)
            {
                s[0] += ".";
                for (int j = 1; j < s.Length - 1; j++)
                {
                    if (i == 0 || i == 5 * rowsCount - 1)
                    {
                        s[j] += "|";
                    }
                    else
                    {
                        s[j] += " ";
                    }

                }
                s[s.Length - 1] += ".";
            }
            for (int i = 0; i < s.Length; i++)
            {
                flagGraphics.DrawString(s[i], font, Brushes.Red, 0, i * 20);
            }
            frm.Show();
        }
        public void DrawVals(int val, int n, int m, int rowsCount)
        {
            Graphics flagGraphics = Graphics.FromImage(frm._bmp);
            Font font = new Font("Arial", 10, GraphicsUnit.Pixel);
            string s = val.ToString();
            string zero = Convert.ToString(0);
            if (s == zero)
            {
                flagGraphics.DrawString(" ", font, Brushes.Red, m * 20 + 10, n * 20 + 20);
                frm.Show();
                return;
            }
            flagGraphics.DrawString(s, font, Brushes.Red, m * 20 + 10, n * 20 + 20);
            frm.Show();
        }
    }
}
