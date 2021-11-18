using System;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class DadosHospede : UserControl
    {
        private HospedeDAO _hospedeDAO = new HospedeDAO();

        public DadosHospede()
        {
            InitializeComponent();
        }

        private void LimparDadosHospede()
        {
            txtNome.Clear();
            txtEmail.Clear();
            dudSexo.ResetText();
            dtPickerNasc.ResetText();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtPassaporte.Clear();
            lblAttDados.Text = "dataAt";
            comboStatus.SelectedItem = null;
            lblAttLogin.Text = "dataAt";
            txtNomeUsuario.Clear();
            txtSenha.Clear();
        }

        public void PreencherCampos(Hospede hosp)
        {
            txtNome.Text = hosp.Nome;
            dtPickerNasc.Value = hosp.DataNascimento;
            txtEmail.Text = hosp.Email;
            txtCPF.Text = hosp.CPF;
            txtPassaporte.Text = hosp.Passaporte;
            txtTelefone.Text = hosp.Telefone;
            dudSexo.Text = hosp.Sexo.ToString();
            comboStatus.Text = hosp.Status;
            lblAttDados.Text = hosp.DataAtualizacao.ToString();
            if (hosp.Conta != null)
            {
                txtNomeUsuario.Text = hosp.Conta.NomeUsuario;
                txtSenha.Text = hosp.Conta.Senha;
                lblAttLogin.Text = hosp.Conta.DataAtualizacao.ToString();

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnLimpar.Parent.Name);
            LimparDadosHospede();
        }

        private void DadosHospede_Load(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidacoesForms.ValidarFormulario(groupDadosPessoais.Controls,
                out string mensagem);
            MessageBox.Show(mensagem);
            if (mensagem == "")
            {
                Hospede hosp = new Hospede();
                hosp.Nome = txtNome.Text;
                hosp.DataNascimento = dtPickerNasc.Value;
                hosp.Sexo = dudSexo.SelectedItem.ToString()[0];
                hosp.Email = txtEmail.Text;
                hosp.Telefone = txtTelefone.Text;
                hosp.setarCPF(txtCPF.Text);
                hosp.Passaporte = txtPassaporte.Text;
                hosp.Status = comboStatus.SelectedItem.ToString();
                _hospedeDAO.InserirHospede(hosp, out string msg);
                ValidacoesForms.ExibirMensagem(msg);
                LimparDadosHospede();
            }
        }

        private void DadosHospede_Leave(object sender, EventArgs e)
        {
            LimparDadosHospede();
        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {
            if(txtCPF.Text.Length == 11 || txtPassaporte.Text.Length > 5)
            {
                Hospede hospede = new Hospede();
                hospede.setarCPF(txtCPF.Text);
                hospede = _hospedeDAO.Carregar(hospede.CPF);
                Conta conta = new Conta();
                conta.NomeUsuario = txtNomeUsuario.Text;
                conta.Senha = txtSenha.Text;
                conta.HospAssociado = hospede;
                string mensagem;
                ContaDAO cDAO = new ContaDAO();
                mensagem = cDAO.Inserir_Att(conta);
                ValidacoesForms.ExibirMensagem(mensagem);
                LimparDadosHospede();
            }
            else
            {
                ValidacoesForms.ExibirMensagem("CPF não inserido");
            }
        }

    }
}
