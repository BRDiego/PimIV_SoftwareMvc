using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class ListaHospedes : UserControl
    {
        private HospedeDAO hDAO = new HospedeDAO();
        public ListaHospedes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscaCPF.Text.Length == 11)
            {
                string cpf = txtBuscaCPF.Text;
                HospedeDAO hDAO = new HospedeDAO();
                Hospede hospede = new Hospede();
                hospede = hDAO.Carregar(cpf);
                if(hospede.Id > 0)
                {
                    dadosHospede1.BringToFront();
                    dadosHospede1.PreencherCampos(hospede);
                    dadosHospede1.Visible = true;

                }
                else
                {
                    MessageBox.Show("CPF não registrado");
                }
            }
            else
            {
                if (comboStatus.Text != "") 
                {
                    dgviewHospedes.DataSource = hDAO.ListarStatus(comboStatus.Text);
                }
                else
                {
                    dgviewHospedes.DataSource = hDAO.ListarStatus("ATIVO");
                }
            }
            txtBuscaCPF.Text = "";
        }

        private void btnNovoHospede_Click(object sender, EventArgs e)
        {
            dadosHospede1.BringToFront();
            dadosHospede1.Visible = true;
        }

        private void ListaHospedes_Leave(object sender, EventArgs e)
        {
            dadosHospede1.SendToBack();
            dadosHospede1.Visible = false;
        }

        private void ListaHospedes_Enter(object sender, EventArgs e)
        {
            dgviewHospedes.DataSource = hDAO.ListarStatus("ATIVO");
        }
    }
}
