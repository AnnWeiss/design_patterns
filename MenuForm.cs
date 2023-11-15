﻿using System;
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
        SomeMatrix matrx;
        FormDraw frm = new FormDraw();
        public MenuForm()
        {
            InitializeComponent();
        }
        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            matrx = new RegularMatrix(6, 6, new VisualInConsole());
            MatrixInitiator.FillMatrix(matrx, matrx.rowsCount * matrx.colsCount, 20);
        }
        private void radioButtonSparse_CheckedChanged(object sender, EventArgs e)
        {
            matrx = new SparseMatrix(6, 6,new VisualInConsole());
            MatrixInitiator.FillMatrix(matrx, 5, 20);
        }
        private void MenuForm_Load(object sender, EventArgs e) { }
        private void buttonCons_Click(object sender, EventArgs e)
        {
            matrx.visualisation = new VisualInConsole(false, true);
            if (checkBox1.Checked)
            {
                matrx.visualisation = new VisualInConsole(true,true);
            }
            else
            {
                matrx.visualisation = new VisualInConsole(false, true);
            }
            matrx.Draw();
        }
        private void buttonGraphic_Click(object sender, EventArgs e)
        {
            matrx.visualisation = new VisualInGraphic(false, true);
            if (checkBox1.Checked)
            {
                matrx.visualisation = new VisualInGraphic(true, true);
            }
            else
            {
                matrx.visualisation = new VisualInGraphic(false, true);
            }
            matrx.Draw();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {

        }

        private void buttonRenum_Click(object sender, EventArgs e)
        {
            //matrx = new Renumbering(new Renumbering(matrx));
        }
    }
}