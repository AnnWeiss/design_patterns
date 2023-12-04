using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_patterns
{
    public partial class MenuForm : Form
    {
        IMatrix matrx;
        public MenuForm()
        {
            InitializeComponent();
        }
        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            matrx = new RegularMatrix(6, 6, new VisualInConsole());
            MatrixInitiator.FillMatrix(matrx, matrx.RowsCount * matrx.ColsCount, 20);
        }
        private void radioButtonSparse_CheckedChanged(object sender, EventArgs e)
        {
            matrx = new SparseMatrix(6, 6,new VisualInConsole());
            MatrixInitiator.FillMatrix(matrx, 5, 20);
        }
        private void MenuForm_Load(object sender, EventArgs e) { }
        private void buttonCons_Click(object sender, EventArgs e)
        {
            RegularMatrix matrx1 = new RegularMatrix(1, 3, new VisualInConsole());
            MatrixInitiator.FillMatrix(matrx, matrx.RowsCount * matrx.ColsCount, 20);

            RegularMatrix matrx2 = new RegularMatrix(2, 2, new VisualInConsole());
            MatrixInitiator.FillMatrix(matrx, matrx.RowsCount * matrx.ColsCount, 20);

            Vertical_Matrices vm = new Vertical_Matrices();
            vm.AddTransposeMatrix(matrx1);
            vm.AddMatrix(matrx2);
            vm[0, 0] = 1;

            matrx.Visualisation = new VisualInConsole(false, true);
            if (checkBox1.Checked)
            {
                matrx.Visualisation = new VisualInConsole(true,true);
            }
            else
            {
                matrx.Visualisation = new VisualInConsole(false, true);
            }
            matrx.Draw();
        }
        private void buttonGraphic_Click(object sender, EventArgs e)
        {
            matrx.Visualisation = new VisualInGraphic(false, true);
            if (checkBox1.Checked)
            {
                matrx.Visualisation = new VisualInGraphic(true, true);
            }
            else
            {
                matrx.Visualisation = new VisualInGraphic(false, true);
            }
            matrx.Draw();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            matrx = matrx.ReturnBase();
        }

        private void buttonRenum_Click(object sender, EventArgs e)
        {
            //декорирование 2 раза
            //matrx = new Renumbering_Decorator(new Renumbering_Decorator(matrx));
            matrx = new Renumbering_Decorator(matrx);
        }
    }
}
