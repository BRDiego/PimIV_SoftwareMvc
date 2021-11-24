using System;
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

        public void PreencherCampos(Funcionario func)
        {
            txtNome.Text = func.Nome;
            dtpNasc.Value = func.DataNascimento;
            txtEmail.Text = func.Email;
            txtCPF.Text = func.CPF;
            txtPassaporte.Text = func.Passaporte;
            txtTelefone.Text = func.Telefone;
            dudSexo.Text = func.Sexo.ToString();
            comboStatusHos.Text = func.Status;
            lblAttHosp.Text = func.DataAtualizacao.ToString();
            txtCargo.Text = func.Cargo;
            txtSalario.Text = func.Salario.ToString();
            comboStatusFun.Text = func.StatusFunc;
            lblAttFunc.Text = func.DataAtualizacaoFunc.ToString();

            if (func.Conta != null)
            {
                txtNomeUsuario.Text = func.Conta.NomeUsuario;
                txtSenha.Text = func.Conta.Senha;
                lblAttLogin.Text = func.Conta.DataAtualizacao.ToString();
            }
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
            ValidacoesForms.ValidarFormulario(groupDadosPessoais.Controls, 
                out string mensagem);
            if (mensagem == "")
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

                mensagem = fDAO.Inserir_Att(func);
            }
            ValidacoesForms.ExibirMensagem(mensagem);

        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length == 11 || txtPassaporte.Text.Length > 5)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.setarCPF(txtCPF.Text);
                funcionario = fDAO.Carregar(funcionario.CPF);
                Conta conta = new Conta();
                conta.NomeUsuario = txtNomeUsuario.Text;
                conta.Senha = txtSenha.Text;
                conta.FuncAssociado = funcionario;
                ContaDAO cDAO = new ContaDAO();
                string mensagem = cDAO.Inserir_Att(conta);
                ValidacoesForms.ExibirMensagem(mensagem);
                LimparDadosFuncionario();
            }
            else
            {
                ValidacoesForms.ExibirMensagem("CPF ou passaporte não inserido");
            }
        }
    }
}
