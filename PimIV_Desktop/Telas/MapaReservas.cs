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

        private void MapaReservas_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void checkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStatus.Checked)
            {
                checkChin.Checked = false;
                checkChout.Checked = false;
                comboStatus.Enabled = true;
            }
            else
            {
                comboStatus.SelectedItem = null;
                comboStatus.Enabled = false;
            }
        }

        private void checkChin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChin.Checked)
            {
                checkStatus.Checked = false;
                btnBuscar.Enabled = true;
                dtpChin.Enabled = true;
            }
            else
            {
                dtpChin.Enabled = false;
            }
        }

        private void checkChout_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChout.Checked)
            {
                checkStatus.Checked = false;
                btnBuscar.Enabled = true;
                dtpChout.Enabled = true;
            }
            else
            {
                dtpChout.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboStatus.Enabled)
            {
                if(comboStatus.Text != "")
                {
                    dgviewReservas.DataSource = resDAO.ListarStatus(
                        comboStatus.Text);
                }
            }
        }


        private void MapaReservas_Layout(object sender, LayoutEventArgs e)
        {
        }
    }
}
