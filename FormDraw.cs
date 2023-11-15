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
    public partial class FormDraw : Form
    {
        Bitmap bmp;
        public Bitmap _bmp
        {
            get => bmp;
            set => bmp = value;
        }
        public FormDraw()
        {
            InitializeComponent();
            mainPictureBox.Size = new Size(400, 300);
            bmp = new Bitmap(mainPictureBox.Size.Width, mainPictureBox.Size.Height);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormDraw_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
