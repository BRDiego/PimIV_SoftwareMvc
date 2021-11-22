using System;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class GerirProdutos : UserControl
    {
        private ProdutoDAO pDAO = new ProdutoDAO();
        private Produto atual = new Produto();
        public GerirProdutos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            if(txtNome.Text == "" || txtValor.Text == "" || txtValor.Text.Contains("."))
            {
                mensagem = "Corrija os campos. Utilize , no valor e não '.' (Ponto)";
            }
            if(mensagem == "")
            {
                atual.Nome = txtNome.Text;
                atual.Quantidade = int.Parse(nudQtde.Value.ToString());
                atual.Preco = double.Parse(txtValor.Text);
                atual.Validade = dtpValidade.Value;
                mensagem = pDAO.Inserir_Att(atual);
            }
            ValidacoesForms.ExibirMensagem(mensagem);
            AtualizarLista();
            LimparAreaProdutos();
        }

        private void gboxNovoConsumo_Layout(object sender, LayoutEventArgs e)
        {
            dgviewProdutos.DataSource = pDAO.ListarStatus("ATIVO");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string mensagem = pDAO.Deletar(atual);
            ValidacoesForms.ExibirMensagem(mensagem);
            btnDeletar.Enabled = false;
            AtualizarLista();
            LimparAreaProdutos();
        }
        
        private void AtualizarLista()
        {
            dgviewProdutos.DataSource = pDAO.ListarStatus("ATIVO");
            dtpValidade.MinDate = DateTime.Now.AddDays(30);
        }

        private void dgviewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para carregar um produto, dê um duplo clique na linha correspondente");
                return;
            }
            string nome = dgviewProdutos[1, e.RowIndex].Value.ToString();
            atual = pDAO.Carregar(nome);
            PreencherCampos();
            btnDeletar.Enabled = true;
        }

        private void PreencherCampos()
        {
            txtNome.Text = atual.Nome;
            txtValor.Text = atual.Preco.ToString();
            nudQtde.Value = atual.Quantidade;
            dtpValidade.Value = atual.Validade;
        }

        private void LimparAreaProdutos()
        {
            txtNome.Clear();
            txtValor.Clear();
            nudQtde.Value = 0;
            dtpValidade.Refresh();
            atual.Id = 0;
        }

        private void GerirProdutos_Enter(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
