using System;
using System.Drawing;
using System.Windows.Forms;
using PimIV_Desktop.Telas;
using DAL;


namespace PimIV_Desktop
{
    public partial class FormLogin : Form
    {
        private Point posInicial;
        private ContaDAO _conta = new ContaDAO();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            posInicial = panelLogin.Location;
        }

        #region [Placeholders (campos vazios)]

        private void txtNomeUsuario_Enter(object sender, EventArgs e)
        {
            if(txtNomeUsuario.Text == " nome de usuário")
            {
                txtNomeUsuario.Text = "";
                txtNomeUsuario.ForeColor = Color.White;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == " senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.White;
            }
        }

        private void txtNomeUsuario_Leave(object sender, EventArgs e)
        {
            ColocarPlaceholder();
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            ColocarPlaceholder();
        }


        private void ColocarPlaceholder()
        {
            if (txtNomeUsuario.Text == "")
            {
                txtNomeUsuario.Text = " nome de usuário";
                txtNomeUsuario.ForeColor = Color.DimGray;
            }
            if (txtSenha.Text == "")
            {
                txtSenha.Text = " senha";
                txtSenha.ForeColor = Color.DimGray;
            }
        }
        #endregion

        private void FormLogin_Layout(object sender, LayoutEventArgs e)
        {
            txtNomeUsuario.Text = "";
            txtSenha.Text = "";
            ColocarPlaceholder();
        }

        private void FormLogin_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1280)
            {
                int x = (this.Size.Width / 2) - (panelLogin.Size.Width / 2);
                int y = (this.Size.Height / 2) - (panelLogin.Size.Height / 2);
                panelLogin.Location = new Point(x, y);
            }
            else
            {
                panelLogin.Location = posInicial;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsuario.Text;
            string senha = txtSenha.Text;
            if (_conta.ValidarFuncionario(nome, senha, out string func, 
                out string cargo))
            {
                lblMensagem.Text = "Carregando aplicação...";
                formConteudo conteudo = new formConteudo(func, cargo);
                conteudo.Show();
                this.Hide();
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Login incorreto.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Carregando aplicação...";
            formConteudo conteudo = new formConteudo("HeadMaster", "Gerente");
            conteudo.Show();
            this.Hide();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
