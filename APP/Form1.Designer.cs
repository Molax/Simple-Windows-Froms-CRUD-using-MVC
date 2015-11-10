namespace APP
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCadastrarSetor = new System.Windows.Forms.Button();
            this.lvlNomeSetor = new System.Windows.Forms.Label();
            this.txtNomeSetor = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.cboSetorFuncionario = new System.Windows.Forms.ComboBox();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.txtCargoFuncionario = new System.Windows.Forms.TextBox();
            this.dtDataNascimentoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.mskdCPFFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblErroFuncionario = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(941, 434);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblErro);
            this.tabPage3.Controls.Add(this.btnCadastrarSetor);
            this.tabPage3.Controls.Add(this.lvlNomeSetor);
            this.tabPage3.Controls.Add(this.txtNomeSetor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(933, 408);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Setor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarSetor
            // 
            this.btnCadastrarSetor.Location = new System.Drawing.Point(448, 203);
            this.btnCadastrarSetor.Name = "btnCadastrarSetor";
            this.btnCadastrarSetor.Size = new System.Drawing.Size(151, 59);
            this.btnCadastrarSetor.TabIndex = 2;
            this.btnCadastrarSetor.Text = "Cadstrar";
            this.btnCadastrarSetor.UseVisualStyleBackColor = true;
            this.btnCadastrarSetor.Click += new System.EventHandler(this.btnCadastrarSetor_Click);
            // 
            // lvlNomeSetor
            // 
            this.lvlNomeSetor.AutoSize = true;
            this.lvlNomeSetor.Location = new System.Drawing.Point(230, 147);
            this.lvlNomeSetor.Name = "lvlNomeSetor";
            this.lvlNomeSetor.Size = new System.Drawing.Size(78, 13);
            this.lvlNomeSetor.TabIndex = 1;
            this.lvlNomeSetor.Text = "Nome do Setor";
            // 
            // txtNomeSetor
            // 
            this.txtNomeSetor.Location = new System.Drawing.Point(347, 144);
            this.txtNomeSetor.Name = "txtNomeSetor";
            this.txtNomeSetor.Size = new System.Drawing.Size(369, 20);
            this.txtNomeSetor.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblErroFuncionario);
            this.tabPage4.Controls.Add(this.btnCadastrarFuncionario);
            this.tabPage4.Controls.Add(this.cboSetorFuncionario);
            this.tabPage4.Controls.Add(this.txtSalarioFuncionario);
            this.tabPage4.Controls.Add(this.txtCargoFuncionario);
            this.tabPage4.Controls.Add(this.dtDataNascimentoFuncionario);
            this.tabPage4.Controls.Add(this.mskdCPFFuncionario);
            this.tabPage4.Controls.Add(this.txtNomeFuncionario);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.lblNome);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(933, 408);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Funcionário";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(781, 334);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(133, 55);
            this.btnCadastrarFuncionario.TabIndex = 12;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // cboSetorFuncionario
            // 
            this.cboSetorFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetorFuncionario.FormattingEnabled = true;
            this.cboSetorFuncionario.Location = new System.Drawing.Point(503, 217);
            this.cboSetorFuncionario.Name = "cboSetorFuncionario";
            this.cboSetorFuncionario.Size = new System.Drawing.Size(193, 21);
            this.cboSetorFuncionario.TabIndex = 11;
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(157, 217);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFuncionario.TabIndex = 10;
            // 
            // txtCargoFuncionario
            // 
            this.txtCargoFuncionario.Location = new System.Drawing.Point(503, 117);
            this.txtCargoFuncionario.Name = "txtCargoFuncionario";
            this.txtCargoFuncionario.Size = new System.Drawing.Size(193, 20);
            this.txtCargoFuncionario.TabIndex = 9;
            // 
            // dtDataNascimentoFuncionario
            // 
            this.dtDataNascimentoFuncionario.Location = new System.Drawing.Point(157, 118);
            this.dtDataNascimentoFuncionario.Name = "dtDataNascimentoFuncionario";
            this.dtDataNascimentoFuncionario.Size = new System.Drawing.Size(251, 20);
            this.dtDataNascimentoFuncionario.TabIndex = 8;
            // 
            // mskdCPFFuncionario
            // 
            this.mskdCPFFuncionario.Location = new System.Drawing.Point(503, 30);
            this.mskdCPFFuncionario.Mask = "000,000,000-00";
            this.mskdCPFFuncionario.Name = "mskdCPFFuncionario";
            this.mskdCPFFuncionario.Size = new System.Drawing.Size(87, 20);
            this.mskdCPFFuncionario.TabIndex = 7;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(157, 30);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(251, 20);
            this.txtNomeFuncionario.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(32, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatórios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(377, 318);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 3;
            // 
            // lblErroFuncionario
            // 
            this.lblErroFuncionario.AutoSize = true;
            this.lblErroFuncionario.Location = new System.Drawing.Point(260, 355);
            this.lblErroFuncionario.Name = "lblErroFuncionario";
            this.lblErroFuncionario.Size = new System.Drawing.Size(0, 13);
            this.lblErroFuncionario.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCadastrarSetor;
        private System.Windows.Forms.Label lvlNomeSetor;
        private System.Windows.Forms.TextBox txtNomeSetor;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cboSetorFuncionario;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.TextBox txtCargoFuncionario;
        private System.Windows.Forms.DateTimePicker dtDataNascimentoFuncionario;
        private System.Windows.Forms.MaskedTextBox mskdCPFFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblErroFuncionario;
    }
}

