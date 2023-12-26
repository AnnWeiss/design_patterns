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
            matrx = new RegularMatrix(6, 6);
            MatrixInitiator.FillMatrix(matrx, matrx.RowsCount * matrx.ColsCount, 20);
        }
        private void radioButtonSparse_CheckedChanged(object sender, EventArgs e)
        {
            matrx = new SparseMatrix(6, 6);
            MatrixInitiator.FillMatrix(matrx, 5, 20);
        }
        private void MenuForm_Load(object sender, EventArgs e) { }
        private void buttonCons_Click(object sender, EventArgs e)
        {
            //RegularMatrix matrx1 = new RegularMatrix(1, 3, new VisualInConsole());
            //MatrixInitiator.FillMatrix(matrx, matrx.RowsCount * matrx.ColsCount, 20);

            //RegularMatrix matrx2 = new RegularMatrix(2, 2, new VisualInConsole());
            //MatrixInitiator.FillMatrix(matrx, matrx.RowsCount * matrx.ColsCount, 20);

            //VerticalMatrices vm = new VerticalMatrices();
            //vm.AddTransposeMatrix(matrx1);
            //vm.AddMatrix(matrx2);
            //vm[0, 0] = 1;
            Drawer.DrawMatrixAlgo(new VisualInConsole(), matrx);

        }
        private void buttonGraphic_Click(object sender, EventArgs e)
        {
            Drawer.DrawMatrixAlgo(new VisualInGraphic(), matrx);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            buttonRestore.Enabled = false;
            buttonRestore.BackColor = Color.GhostWhite;
            buttonRenum.Enabled = true;
            buttonRenum.BackColor = Color.LightSteelBlue;

            matrx = new RenumberingDecorator(matrx);
            matrx = (matrx as RenumberingDecorator).ReturnBase();

        }

        private void buttonRenum_Click(object sender, EventArgs e)
        {
            //декорирование 2 раза
            //matrx = new Renumbering_Decorator(new Renumbering_Decorator(matrx));

            buttonRenum.Enabled = false;
            buttonRenum.BackColor = Color.GhostWhite;
            buttonRestore.Enabled = true;
            buttonRestore.BackColor = Color.LightSteelBlue;

            matrx = new RenumberingDecorator(matrx);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonEdit.Enabled = false;
            buttonEdit.BackColor = Color.GhostWhite;
            buttonUndo.Enabled = true;
            buttonUndo.BackColor = Color.LightSteelBlue;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            buttonUndo.Enabled = false;
            buttonUndo.BackColor = Color.GhostWhite;
            buttonEdit.Enabled = true;
            buttonEdit.BackColor = Color.LightSteelBlue;
        }
    }
}
