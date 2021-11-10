using System;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class GerirConsumos : UserControl
    {
        private ReservaDAO _reservaDAO = new ReservaDAO();
        public GerirConsumos()
        {
            InitializeComponent();
        }

        public void teste(int maximo)
        {
            nudQtde.Maximum = maximo;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ValidacoesForms.ValidarFormulario(btnAdicionar.Parent.Controls,
                out string mensagem);
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void GerirConsumos_Load(object sender, EventArgs e)
        {
            foreach(string prod in _reservaDAO.CarregarProdutosAtivos())
            {
                comboProdutos.Items.Add(prod); 
            }
        }
    }
}
