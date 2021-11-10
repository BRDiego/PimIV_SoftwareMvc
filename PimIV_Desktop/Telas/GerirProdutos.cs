using System;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class GerirProdutos : UserControl
    {
        public GerirProdutos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ValidacoesForms.ValidarFormulario(btnAdicionar.Parent.Controls,
                out string mensagem);
            if(mensagem == "")
            {
                MessageBox.Show("TA JOIA");
            }
            else
            {
                ValidacoesForms.ExibirMensagem(mensagem);
            }
        }
    }
}
