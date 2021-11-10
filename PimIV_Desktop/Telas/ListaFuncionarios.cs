using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimIV_Desktop.Telas
{
    public partial class ListaFuncionarios : UserControl
    {
        public ListaFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            dadosFuncionario1.Visible = true;
            dadosFuncionario1.BringToFront();
        }

        private void ListaFuncionarios_Leave(object sender, EventArgs e)
        {
            dadosFuncionario1.SendToBack();
            dadosFuncionario1.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
