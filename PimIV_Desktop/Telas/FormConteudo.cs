using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace PimIV_Desktop.Telas
{
    public partial class formConteudo : Form
    {
        private string Funcionario = "";
        private Button BotaoAtivo = null;
        private Point posicaoPainel;
        private Point novaPosicao = new Point();
        private Point posIniBotoes;

        public formConteudo(string nome, string cargo)
        {
            InitializeComponent();
            Funcionario = nome;
            switch (cargo)
            {
                case "Recepcionista":
                    btnNovaReserva.Visible = true;
                    btnMapaReservas.Visible = true;
                    break;
                case "Governanca":
                    btnMapaQuartos.Visible = true;
                    btnConsumos.Visible = true;
                    btnEstoque.Visible = true;
                    break;
                case "Gerente":
                    foreach (Button btn in panelBotoes.Controls)
                    {
                        btn.Visible = true;
                    }
                    break;
            }
        }

        public void SetarMensagem(string mensagem)
        {
            lblMensagem.Text = mensagem;
        }

        private void MarcarBotao(object item)
        {
            if (BotaoAtivo != null)
            {
                BotaoAtivo.ForeColor = Color.Black;
                BotaoAtivo.BackColor = Color.Transparent;
            }
            if (item is Button)
            {
                BotaoAtivo = item as Button;
                BotaoAtivo.BackColor = Color.MidnightBlue;
                BotaoAtivo.ForeColor = Color.White;
            }
        }

        private void Conteudo_Load(object sender, EventArgs e)
        {
            posicaoPainel = panel_Inicial.Location;
            posIniBotoes = panelBotoes.Location;

            timer1.Start();
            lblData.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDia.Text = DateTime.Now.ToString("dddd");

            string dia = lblDia.Text;
            dia = dia.ToUpper();
            string p1 = dia.Substring(1);
            p1 = p1.ToLower();
            dia = dia.Remove(1);
            dia += p1;

            if (dia.Contains('-'))
            {
                dia = dia.Remove(dia.IndexOf('-'));
                dia += "-Feira";
            }
            lblDia.Text = dia;

            lblBemVindo.Text += Funcionario;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("HH:mm");
            lblSeg.Text = DateTime.Now.ToString("ss");
        }

        private void Conteudo_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if (form is FormLogin)
                {
                    form.Show();
                }
            }
        }


        private void PicboxLogoFixo_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            panel_Inicial.BringToFront();
        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            novaReserva1.BringToFront();
        }

        private void btnMapaReservas_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            mapaReservas1.BringToFront();
            //mapaReservas1.Controls["verReserva1"].Visible = false;
            //mapaReservas1.Controls["dgviewReservas"].BringToFront();
        }

        private void btnMapaQuartos_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            mapaQuartos1.BringToFront();

        }

        private void btnConsumos_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            gerirConsumos1.BringToFront();

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            gerirProdutos1.BringToFront();

        }

        private void btnHospedes_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            listaHospedes1.BringToFront();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            listaFuncionarios1.BringToFront();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            relatorios1.BringToFront();
        }

        private void btnPrecos_Click(object sender, EventArgs e)
        {
            MarcarBotao(sender);
            editarPrecos1.BringToFront();
        }

        private void formConteudo_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1280)
            {

                novaPosicao.X = panelBotoes.Location.X;
                novaPosicao.Y = (this.Size.Height / 2) - (panelBotoes.Size.Height / 2);
                panelBotoes.Location = novaPosicao;

                novaPosicao.X = this.Size.Width - 512;
                novaPosicao.Y = panelBoasvindas.Location.Y;
                panelBoasvindas.Location = novaPosicao;

                novaPosicao.X = (int)(this.Size.Width * 0.25);
                novaPosicao.Y = panelBotoes.Location.Y;
                panel_Inicial.Location = novaPosicao;
            }
            else
            {
                panel_Inicial.Location = posicaoPainel;
                panelBotoes.Location = posIniBotoes;

                novaPosicao.X = this.Size.Width - 512;
                novaPosicao.Y = panelBoasvindas.Location.Y;
                panelBoasvindas.Location = novaPosicao;
            }

        }

        private void panel_Inicial_LocationChanged(object sender, EventArgs e)
        {
            foreach(object item in this.Controls)
            {
                if (item is UserControl)
                {
                    UserControl aux = item as UserControl;
                    aux.Location = panel_Inicial.Location;
                }
            }
        }
    }
}
