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
    public partial class MapaQuartos : UserControl
    {
        public MapaQuartos()
        {
            InitializeComponent();
        }

        private void dgviewReservas_Leave(object sender, EventArgs e)
        {
            panelAcoesQuarto.Enabled = false;
        }

        private void dgviewQuartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelAcoesQuarto.Enabled = true;
        }

        private void btnNovoConsumo_Click(object sender, EventArgs e)
        {

        }

        private void MapaQuartos_Load(object sender, EventArgs e)
        {
            dudQuartos.Items.Add("1 Solteiro");
            dudQuartos.Items.Add("2 Solteiro");
            dudQuartos.Items.Add("1 Casal");
            dudQuartos.Items.Add("1 Casal 1 Solteiro");
            dudQuartos.Items.Add("1 Casal 2 Solteiro");

        }
    }
}
