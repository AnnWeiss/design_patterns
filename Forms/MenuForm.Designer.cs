
namespace design_patterns
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMatrx = new System.Windows.Forms.GroupBox();
            this.radioButtonSparse = new System.Windows.Forms.RadioButton();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.groupBoxBorder = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.buttonGraphic = new System.Windows.Forms.Button();
            this.buttonCons = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonRenum = new System.Windows.Forms.Button();
            this.groupBoxMatrx.SuspendLayout();
            this.groupBoxBorder.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMatrx
            // 
            this.groupBoxMatrx.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxMatrx.Controls.Add(this.radioButtonSparse);
            this.groupBoxMatrx.Controls.Add(this.radioButtonRegular);
            this.groupBoxMatrx.Location = new System.Drawing.Point(67, 43);
            this.groupBoxMatrx.Name = "groupBoxMatrx";
            this.groupBoxMatrx.Size = new System.Drawing.Size(296, 144);
            this.groupBoxMatrx.TabIndex = 0;
            this.groupBoxMatrx.TabStop = false;
            this.groupBoxMatrx.Text = "Генерация матрицы:";
            // 
            // radioButtonSparse
            // 
            this.radioButtonSparse.AutoSize = true;
            this.radioButtonSparse.Location = new System.Drawing.Point(52, 89);
            this.radioButtonSparse.Name = "radioButtonSparse";
            this.radioButtonSparse.Size = new System.Drawing.Size(135, 24);
            this.radioButtonSparse.TabIndex = 3;
            this.radioButtonSparse.TabStop = true;
            this.radioButtonSparse.Text = "Разреженная";
            this.radioButtonSparse.UseVisualStyleBackColor = true;
            this.radioButtonSparse.CheckedChanged += new System.EventHandler(this.radioButtonSparse_CheckedChanged);
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(52, 46);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(102, 24);
            this.radioButtonRegular.TabIndex = 2;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "Обычная";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            this.radioButtonRegular.CheckedChanged += new System.EventHandler(this.radioButtonRegular_CheckedChanged);
            // 
            // groupBoxBorder
            // 
            this.groupBoxBorder.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxBorder.Controls.Add(this.checkBox1);
            this.groupBoxBorder.ForeColor = System.Drawing.Color.Black;
            this.groupBoxBorder.Location = new System.Drawing.Point(398, 45);
            this.groupBoxBorder.Name = "groupBoxBorder";
            this.groupBoxBorder.Size = new System.Drawing.Size(296, 142);
            this.groupBoxBorder.TabIndex = 1;
            this.groupBoxBorder.TabStop = false;
            this.groupBoxBorder.Text = "Граница матрицы:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Показывать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxView
            // 
            this.groupBoxView.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxView.Controls.Add(this.buttonGraphic);
            this.groupBoxView.Controls.Add(this.buttonCons);
            this.groupBoxView.Location = new System.Drawing.Point(366, 242);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(413, 142);
            this.groupBoxView.TabIndex = 2;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "Вывод:";
            // 
            // buttonGraphic
            // 
            this.buttonGraphic.BackColor = System.Drawing.Color.Thistle;
            this.buttonGraphic.Location = new System.Drawing.Point(230, 46);
            this.buttonGraphic.Name = "buttonGraphic";
            this.buttonGraphic.Size = new System.Drawing.Size(163, 68);
            this.buttonGraphic.TabIndex = 1;
            this.buttonGraphic.Text = "В окне";
            this.buttonGraphic.UseVisualStyleBackColor = false;
            this.buttonGraphic.Click += new System.EventHandler(this.buttonGraphic_Click);
            // 
            // buttonCons
            // 
            this.buttonCons.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonCons.Location = new System.Drawing.Point(31, 46);
            this.buttonCons.Name = "buttonCons";
            this.buttonCons.Size = new System.Drawing.Size(163, 68);
            this.buttonCons.TabIndex = 0;
            this.buttonCons.Text = "На консоль";
            this.buttonCons.UseVisualStyleBackColor = false;
            this.buttonCons.Click += new System.EventHandler(this.buttonCons_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.buttonRestore);
            this.groupBox1.Controls.Add(this.buttonRenum);
            this.groupBox1.Location = new System.Drawing.Point(67, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Декорирование";
            // 
            // buttonRestore
            // 
            this.buttonRestore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRestore.Location = new System.Drawing.Point(52, 100);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(167, 45);
            this.buttonRestore.TabIndex = 1;
            this.buttonRestore.Text = "Восстановить";
            this.buttonRestore.UseVisualStyleBackColor = false;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonRenum
            // 
            this.buttonRenum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRenum.Location = new System.Drawing.Point(52, 37);
            this.buttonRenum.Name = "buttonRenum";
            this.buttonRenum.Size = new System.Drawing.Size(167, 45);
            this.buttonRenum.TabIndex = 0;
            this.buttonRenum.Text = "Перенумеровать";
            this.buttonRenum.UseVisualStyleBackColor = false;
            this.buttonRenum.Click += new System.EventHandler(this.buttonRenum_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(812, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxView);
            this.Controls.Add(this.groupBoxBorder);
            this.Controls.Add(this.groupBoxMatrx);
            this.Name = "MenuForm";
            this.Text = "Вывод матрицы";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.groupBoxMatrx.ResumeLayout(false);
            this.groupBoxMatrx.PerformLayout();
            this.groupBoxBorder.ResumeLayout(false);
            this.groupBoxBorder.PerformLayout();
            this.groupBoxView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMatrx;
        private System.Windows.Forms.RadioButton radioButtonSparse;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.GroupBox groupBoxBorder;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Button buttonGraphic;
        private System.Windows.Forms.Button buttonCons;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonRenum;
    }
}