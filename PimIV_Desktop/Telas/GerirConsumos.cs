using System;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class GerirConsumos : UserControl
    {
        private ReservaDAO _reservaDAO = new ReservaDAO();
        private ProdutoDAO _pDAO = new ProdutoDAO();
        private ConsumoDAO _cDAO = new ConsumoDAO();
        private Consumo atual = new Consumo();
        public GerirConsumos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(nudQtde.Value > 0)
            {
                atual.Reserva.Id = int.Parse(comboRes.Text);
                atual.Produto.Nome = comboProdutos.Text;
                atual.Quantidade = int.Parse(nudQtde.Value.ToString());
                atual.Total = double.Parse(txtValor.Text);
                string mensagem = _cDAO.Inserir_Att(atual);
                ValidacoesForms.ExibirMensagem(mensagem);
                LimparAreaConsumos();
            }
            AtualizarLista();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string mensagem = _cDAO.Deletar(atual);
            ValidacoesForms.ExibirMensagem(mensagem);
            btnDeletar.Enabled = false;
            AtualizarLista();
            LimparAreaConsumos();
            
        }

        private void nudQtde_ValueChanged(object sender, EventArgs e)
        {
            txtValor.Text = (double.Parse(nudQtde.Value.ToString())
                * atual.Produto.Preco).ToString();
        }

        private void comboProdutos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            atual.Produto = _pDAO.Carregar(comboProdutos.Text);
            nudQtde.Enabled = true;
        }

        private void AtualizarLista()
        {
            dgviewConsumos.DataSource = _cDAO.Listar();
            if(comboProdutos.Items.Count == 0)
            {
                foreach (string prod in _pDAO.CarregarProdutosAtivos())
                {
                    comboProdutos.Items.Add(prod);
                }
            }
            if (comboRes.Items.Count == 0)
            {
                foreach (string res in _reservaDAO.CarregarReservasAtivas())
                {
                    comboRes.Items.Add(res);
                }
            }
        }

        private void dgviewConsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para carregar um consumo, dê um duplo clique na linha correspondente");
                return;
            }
            int id = int.Parse(dgviewConsumos[0, e.RowIndex].Value.ToString());
            atual = _cDAO.Carregar(id);
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            comboProdutos.Text = atual.Produto.Nome;
            comboRes.Text = atual.Reserva.Id.ToString();
            nudQtde.Value = atual.Quantidade;
            txtValor.Text = atual.Total.ToString();
            //esse if testa se o produto está inativo (deletado)
            if (comboProdutos.Text == "")
            {
                MessageBox.Show("Produto inativo. Não é possível alterar consumo, apenas deletar");
                btnAdicionar.Enabled = false;
            }
            btnDeletar.Enabled = true;
        }

        private void GerirConsumos_Leave(object sender, EventArgs e)
        {
            LimparAreaConsumos();
        }

        private void LimparAreaConsumos()
        {
            btnAdicionar.Enabled = true;
            txtValor.Clear();
            nudQtde.Value = 0;
            comboProdutos.SelectedItem = null;
            comboRes.SelectedItem = null;
            atual.Id = 0;
        }

        private void gboxNovoConsumo_Enter(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
