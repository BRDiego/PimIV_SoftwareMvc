using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class EditarPrecos : UserControl
    {
        private TipoCustoDAO tDAO = new TipoCustoDAO();
        List<TipoCusto> Tipos = new List<TipoCusto>();
        private TipoCusto editando;
        public EditarPrecos()
        {
            InitializeComponent();
        }

        private void LimparEditarPrecos()
        {
            mtxtQuarto1.Clear();
            mtxtQuarto2.Clear();
            mtxtQuarto3.Clear();
            mtxtQuarto4.Clear();
            mtxtQuarto5.Clear();
            mtxtAdulto.Clear();
            mtxtCrianca.Clear();
        }

        private void btnSolt1_Click(object sender, EventArgs e)
        {
            double novoPreco = double.Parse(mtxtQuarto1.Text);
            editando = Tipos[0];
            editando.Preco = novoPreco;
            string mensagem = tDAO.Alterar(editando);
            editando = tDAO.Carregar(editando.Id);
            lblQuarto1.Text = editando.Preco.ToString();
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void EditarPrecos_Leave(object sender, EventArgs e)
        {
            LimparEditarPrecos();
        }

        private void EditarPrecos_Enter(object sender, EventArgs e)
        {
            Tipos = tDAO.CarregarTipos();
            lblQuarto1.Text = Tipos[0].Preco.ToString();
            lblQuarto2.Text = Tipos[1].Preco.ToString();
            lblQuarto3.Text = Tipos[2].Preco.ToString();
            lblQuarto4.Text = Tipos[3].Preco.ToString();
            lblQuarto5.Text = Tipos[4].Preco.ToString();
            diariaAdultos.Text = Tipos[5].Preco.ToString();
            diariaCriancas.Text = Tipos[6].Preco.ToString();

            mtxtQuarto1.Text = Tipos[0].Preco.ToString();
            mtxtQuarto2.Text = Tipos[1].Preco.ToString();
            mtxtQuarto3.Text = Tipos[2].Preco.ToString();
            mtxtQuarto4.Text = Tipos[3].Preco.ToString();
            mtxtQuarto5.Text = Tipos[4].Preco.ToString();
            mtxtAdulto.Text = Tipos[5].Preco.ToString();
            mtxtCrianca.Text = Tipos[6].Preco.ToString();

        }

        private void btnSolt2_Click(object sender, EventArgs e)
        {
            double novoPreco = double.Parse(mtxtQuarto1.Text);
            editando = Tipos[1];
            editando.Preco = novoPreco;
            string mensagem = tDAO.Alterar(editando);
            editando = tDAO.Carregar(editando.Id);
            lblQuarto2.Text = editando.Preco.ToString();
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void btnCasal_Click(object sender, EventArgs e)
        {
            double novoPreco = double.Parse(mtxtQuarto1.Text);
            editando = Tipos[2];
            editando.Preco = novoPreco;
            string mensagem = tDAO.Alterar(editando);
            editando = tDAO.Carregar(editando.Id);
            lblQuarto3.Text = editando.Preco.ToString();
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void btnFam1_Click(object sender, EventArgs e)
        {
            double novoPreco = double.Parse(mtxtQuarto1.Text);
            editando = Tipos[3];
            editando.Preco = novoPreco;
            string mensagem = tDAO.Alterar(editando);
            editando = tDAO.Carregar(editando.Id);
            lblQuarto4.Text = editando.Preco.ToString();
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void btnFam2_Click(object sender, EventArgs e)
        {
            double novoPreco = double.Parse(mtxtQuarto1.Text);
            editando = Tipos[4];
            editando.Preco = novoPreco;
            string mensagem = tDAO.Alterar(editando);
            editando = tDAO.Carregar(editando.Id);
            lblQuarto5.Text = editando.Preco.ToString();
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void btnDiaAdu_Click(object sender, EventArgs e)
        {
            double novoPreco = double.Parse(mtxtQuarto1.Text);
            editando = Tipos[5];
            editando.Preco = novoPreco;
            string mensagem = tDAO.Alterar(editando);
            editando = tDAO.Carregar(editando.Id);
            diariaAdultos.Text = editando.Preco.ToString();
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void btnDiaCri_Click(object sender, EventArgs e)
        {
            double novoPreco = double.Parse(mtxtQuarto1.Text);
            editando = Tipos[2];
            editando.Preco = novoPreco;
            string mensagem = tDAO.Alterar(editando);
            editando = tDAO.Carregar(editando.Id);
            diariaCriancas.Text = editando.Preco.ToString();
            ValidacoesForms.ExibirMensagem(mensagem);
        }
    }
}
