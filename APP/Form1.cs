using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class Form1 : Form
    {
        //Váriaves de negócio
        private BLL.Funcionario _FuncionarioBLL;

        private BLL.Setor _SetorBLL;

        public Form1()
        {
            InitializeComponent();

            //Construtores 
            if (_FuncionarioBLL == null)
            {
                _FuncionarioBLL = new BLL.Funcionario();
            }

            if (_SetorBLL == null)
            {
                _SetorBLL = new BLL.Setor();
            }

            tabControl2.SelectedIndexChanged += new EventHandler(tabControl2_SelectedIndexChanged);

            PopulaComboboxSetores();
        }

        private void btnCadastrarSetor_Click(object sender, EventArgs e)
        {
            if (VerificaCamposSetor())
            {
                _SetorBLL.CreateNewSetor(txtNomeSetor.Text);

                MessageBox.Show("Setor Cadastrado com sucesso !", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                LimpaCampos();
            }
            else
            {
                lblErro.Text = "O Campo NOME DO SETOR é obrigatório";
                lblErro.ForeColor = Color.Red;
            }
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (VerificaCamposFuncionario())
            {
                _FuncionarioBLL.CreateNewFuncionario(txtNomeFuncionario.Text, mskdCPFFuncionario.Text, Convert.ToDateTime(dtDataNascimentoFuncionario.Text), txtCargoFuncionario.Text, txtSalarioFuncionario.Text, Convert.ToInt32(cboSetorFuncionario.SelectedValue));

                MessageBox.Show("Funcionário Cadastrado com sucesso !", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                //LimpaCampos();
            }
            else
            {
                lblErroFuncionario.Text = "Favor Preencher todos os campos";
                lblErroFuncionario.ForeColor = Color.Red;
            }
        }

        private List<DTO.Setor> GetAllSetors()
        {
            List<DTO.Setor> Setores = _SetorBLL.GetAllSetors();

            return Setores;
        }

        private void PopulaComboboxSetores()
        {
            List<DTO.Setor> Setores = GetAllSetors();
            cboSetorFuncionario.DataSource = Setores;
            cboSetorFuncionario.DisplayMember = "sSetor";
            cboSetorFuncionario.ValueMember = "nldSetor";
        }

        private void LimpaCampos()
        {
            txtCargoFuncionario.Clear();
            txtNomeFuncionario.Clear();
            txtNomeSetor.Clear();
            txtSalarioFuncionario.Clear();
            mskdCPFFuncionario.Clear();
            lblErro.Text = "";
            lblErroFuncionario.Text = "";
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    PopulaComboboxSetores();
                    break;
                case 1:
                    PopulaComboboxSetores();
                    break;
            }
        }

        private bool VerificaCamposSetor()
        {
            if (string.IsNullOrEmpty(txtNomeSetor.Text))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        private bool VerificaCamposFuncionario()
        {
            if (string.IsNullOrEmpty(txtCargoFuncionario.Text) || string.IsNullOrEmpty(txtNomeFuncionario.Text) || string.IsNullOrEmpty(txtSalarioFuncionario.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
