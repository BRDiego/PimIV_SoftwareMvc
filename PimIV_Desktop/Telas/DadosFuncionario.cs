using System;
using System.Data;
using System.Windows.Forms;
using DAL;
using Model;

namespace PimIV_Desktop.Telas
{
    public partial class DadosFuncionario : UserControl
    {
        private FuncionarioDAO fDAO = new FuncionarioDAO();
        public DadosFuncionario()
        {
            InitializeComponent();
        }

        private void LimparDadosFuncionario()
        {
            txtNome.Clear();
            dtpNasc.ResetText();
            dudSexo.ResetText();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtPassaporte.Clear();
            txtSalario.Clear();
            txtCargo.Clear();
            comboStatusHos.ResetText();
            comboStatusFun.ResetText();
            lblAttFunc.Text = "dataAt";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosFuncionario();
        }

        private void DadosFuncionario_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection sexo = this.dudSexo.Items;
            sexo.Add("M");
            sexo.Add("F");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }

        private void DadosFuncionario_Leave(object sender, EventArgs e)
        {
            LimparDadosFuncionario();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Nome = txtNome.Text;
            func.DataNascimento = dtpNasc.Value;
            func.Sexo = dudSexo.Text[0];
            func.Email = txtEmail.Text;
            func.Telefone = txtTelefone.Text;
            func.setarCPF(txtCPF.Text);
            func.Passaporte = txtPassaporte.Text;
            func.Status = comboStatusHos.SelectedItem.ToString();

            func.Cargo = txtCargo.Text;
            func.Salario = double.Parse(txtSalario.Text);
            func.StatusFunc = (comboStatusFun.Text);

            string retorno = fDAO.Inserir_Att(func);
            ValidacoesForms.ExibirMensagem(retorno);

        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {
            ValidacoesForms.ValidarFormulario(groupDadosLogin.Controls
                , out string mensagem);
            if (mensagem != "")
            {

                MessageBox.Show(mensagem);
            }
            MessageBox.Show(btnSalvarLogin.Parent.Name);
        }
    }
}
