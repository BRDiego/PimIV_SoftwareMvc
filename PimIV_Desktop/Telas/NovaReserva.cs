using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Model;
using DAL;

namespace PimIV_Desktop.Telas
{
    public partial class NovaReserva : UserControl
    {
        public static int qtde = 0;
        public NovaReserva()
        {
            InitializeComponent();
            qtde += 1;
            mcaEstadia.MinDate = DateTime.Now.Date;

        }

        private void LimparNovaReserva()
        {
            txtHospede.Clear();
            MtxtNasc.Clear();
            CboxSexo.ResetText();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtPassaporte.Clear();
            txtCheckIn.Clear();
            txtCheckOut.Clear();
            nudAdultos.Value = 1;
            nudCriancas.Value = 0;
            dudQuartos.ResetText();
            lblDespesas.ResetText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparNovaReserva();
        }

        private void btnGerarData_Click(object sender, EventArgs e)
        {
            if (txtCheckIn.Text == "")
            {
                txtCheckIn.Text = mcaEstadia.SelectionStart.ToShortDateString();
            }
            else
            {
                txtCheckOut.Text = mcaEstadia.SelectionEnd.ToShortDateString();
            }
        }

        private void NovaReserva_Leave(object sender, EventArgs e)
        {
            LimparNovaReserva();
        }

        private void nudCriancas_KeyUp(object sender, KeyEventArgs e)
        {

            nudCriancas.Text = "";
        }

        private void nudAdultos_KeyUp(object sender, KeyEventArgs e)
        {

            nudAdultos.Text = "";
        }

        private void dudQuartos_KeyUp(object sender, KeyEventArgs e)
        {

            //dudQuartos.Text = "";
        }

        private void CboxSexo_KeyUp(object sender, KeyEventArgs e)
        {
            //CboxSexo.Text = "";
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            ValidacoesForms.ValidarFormulario(btnReservar.Parent.Controls,
                out string mensagem);
            if (mensagem == "")
            {
                MessageBox.Show("LEGAL");
            }
            else
            {
                //exibir mensagem
            }
        }

        private void NovaReserva_Load(object sender, EventArgs e)
        {
            dudQuartos.Items.Add("1 Solteiro");
            dudQuartos.Items.Add("2 Solteiro");
            dudQuartos.Items.Add("1 Casal");
            dudQuartos.Items.Add("1 Casal 1 Solteiro");
            dudQuartos.Items.Add("1 Casal 2 Solteiro");
        }

        private void txtPassaporte_TextChanged(object sender, EventArgs e)
        {
            if(txtPassaporte.Text == "")
            {
                txtCPF.Enabled = true;
            }
            else
            {
                txtCPF.Enabled = false;
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtPassaporte.Enabled = true;
            }
            else
            {
                txtPassaporte.Enabled = false;
            }
        }
    }
}
