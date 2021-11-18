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

            //if (txtBuscaCPF.Text != "")
            //{
            //    Hospede h = new Hospede();
            //    h.CPF = txtBuscaCPF.Text;
            //    btnNovoHospede_Click(btnNovoHospede, e, h);
            //}
            //else if (comboStatus.SelectedItem != null)
            //{
            //    //listar por status
            //}
            //else
            //{
            //    btnListarTodos_Click(btnListarTodos,e);
            //}
        }

        private void btnNovoHospede_Click(object sender, EventArgs e)
        {
            dadosHospede1.BringToFront();
            dadosHospede1.Visible = true;
        }

        private void btnNovoHospede_Click(object sender, EventArgs e, Hospede hosp)
        {
            dadosHospede1.BringToFront();
            dadosHospede1.Visible = true;
            dadosHospede1.PreencherCampos(hosp);
        }

        private void btnNovoHospede_VisibleChanged(object sender, EventArgs e)
        {
            dgviewHospedes.DataSource = null;
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBuscaCPF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listando tudo");
        }

        private void ListaHospedes_Leave(object sender, EventArgs e)
        {
            dadosHospede1.SendToBack();
            dadosHospede1.Visible = false;
        }

        private void dgviewHospedes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //nao precisa, da pra usar o bring to front
            btnNovoHospede_Click(btnNovoHospede, e, new Hospede());
        }
    }
}
