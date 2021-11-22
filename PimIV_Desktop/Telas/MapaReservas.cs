using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class MapaReservas : UserControl
    {
        private readonly ReservaDAO resDAO = new ReservaDAO();

        public MapaReservas()
        {
            InitializeComponent();
        }

        private void dgviewReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                MessageBox.Show("Para acessar uma reserva, dê um duplo clique na linha correspondente");
                return;
            }
            verReserva1.BringToFront();
            verReserva1.Visible = true;
            verReserva1.PopularDadosReserva(int.Parse(dgviewReservas[0,e.RowIndex].Value.ToString()));
        }


        private void checkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStatus.Checked)
            {
                comboStatus.Enabled = true;
                checkPeriodo.Checked = false;
                dtpPeriodo.Enabled = false;
            }
            else
            {
                comboStatus.SelectedItem = null;
                comboStatus.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime periodo = dtpPeriodo.Value;
            dgviewReservas.DataSource = resDAO.ListarData(periodo);
        }



        private void checkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPeriodo.Checked)
            {
                checkStatus.Checked = false;
                comboStatus.Enabled = false;
                dtpPeriodo.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                comboStatus.Enabled = true;
                btnBuscar.Enabled = false;
            }
        }

        private void comboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgviewReservas.DataSource = 
            dgviewReservas.DataSource = resDAO.ListarStatus(comboStatus.Text);
        }
    }
}
