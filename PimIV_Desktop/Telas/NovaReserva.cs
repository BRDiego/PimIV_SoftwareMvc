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
        private ReservaDAO resDAO = new ReservaDAO();
        private TipoCustoDAO tDAO = new TipoCustoDAO();
        private QuartoDAO qDAO = new QuartoDAO();
        private HospedeDAO hDAO = new HospedeDAO();
        private Reserva atual = new Reserva();
        private Hospede hospede = new Hospede();
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
            btnGerarData.Enabled = false;
            mcaEstadia.Enabled = false;
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
                if(txtCheckOut.Text == "")
                {
                    txtCheckOut.Text = mcaEstadia.SelectionEnd.ToShortDateString();
                    PrepararReserva();
                }
                else
                {
                    txtCheckOut.Text = "";
                    txtCheckIn.Text = mcaEstadia.SelectionEnd.ToShortDateString();
                    txtDespesas.Clear();
                }
            }
        }

        private void NovaReserva_Leave(object sender, EventArgs e)
        {
            LimparNovaReserva();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            ValidacoesForms.ValidarFormulario(this.Controls,
                out string mensagem);
            if (mensagem == "" && atual.Despesas != 0)
            {
                string tipo = dudQuartos.Text;
                DateTime entrada = DateTime.Parse(txtCheckIn.Text);
                if(resDAO.TipoDisponivel(entrada,tipo, out int quarto))
                {
                    hospede.Nome = txtHospede.Text;
                    hospede.Sexo = CboxSexo.Text[0];
                    hospede.DataNascimento = DateTime.Parse(MtxtNasc.Text);
                    hospede.Telefone = txtTelefone.Text;
                    hospede.Email = txtEmail.Text;
                    hospede.setarCPF(txtCPF.Text);
                    hospede.Passaporte = txtPassaporte.Text;
                    mensagem = hDAO.Inserir_Att(hospede);
                    string cpfPass = txtCPF.Text.Length == 11 ? txtCPF.Text : txtPassaporte.Text;
                    hospede = hDAO.Carregar(cpfPass);
                    atual.Hospede = hospede;
                    atual.Quarto.Numero = quarto;
                    if(atual.ReservaValida(out mensagem))
                    {
                        mensagem = resDAO.Inserir_Att(atual);
                        LimparNovaReserva();
                    }
                }
                else
                {
                    mensagem = "Não há vagas para esta data com essas preferências";
                }
            }
            ValidacoesForms.ExibirMensagem(mensagem);
        }

        private void NovaReserva_Load(object sender, EventArgs e)
        {
            dudQuartos.Items.AddRange(tDAO.ListarTiposQuarto());
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

        private void dudQuartos_SelectedItemChanged(object sender, EventArgs e)
        {
            mcaEstadia.Enabled = true;
            btnGerarData.Enabled = true;
        }

        private void PrepararReserva()
        {
            atual.Adultos = int.Parse(nudAdultos.Value.ToString());
            atual.Criancas = int.Parse(nudCriancas.Value.ToString());
            atual.CheckIn = DateTime.Parse(txtCheckIn.Text);
            atual.CheckOut = DateTime.Parse(txtCheckOut.Text);
            int idTipo = dudQuartos.Items.IndexOf(dudQuartos.Text);
            double[] diarais = tDAO.DiariasAdueCri();
            atual.Quarto.Tipo = tDAO.Carregar(idTipo + 1);
            atual.CalcularDespesas(diarais[0], diarais[1]);
            txtDespesas.Text = atual.Despesas.ToString();
        }

        private void PreencherHospede()
        {
            txtHospede.Text = hospede.Nome;
            MtxtNasc.Text = hospede.DataNascimento.Date.ToString();
            txtEmail.Text = hospede.Email;
            txtCPF.Text = hospede.CPF;
            txtPassaporte.Text = hospede.Passaporte;
            txtTelefone.Text = hospede.Telefone;
            CboxSexo.Text = hospede.Sexo.ToString();
        }
    }
}
