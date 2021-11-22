using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace PimIV_Desktop.Telas
{
    public partial class VerReserva : UserControl
    {
        private ReservaDAO resDAO = new ReservaDAO();
        private PagamentoDAO pDAO = new PagamentoDAO();
        private ConsumoDAO cDAO = new ConsumoDAO();
        Reserva res;
        
        public VerReserva()
        {
            InitializeComponent();
        }

        public void PopularDadosReserva(int id)
        {
            res = resDAO.Carregar(id, out double total);
            lblHospede.Text = res.Hospede.Nome;
            lblNasc.Text = res.Hospede.DataNascimento.Date.ToString();
            lblSexo.Text = res.Hospede.Sexo.ToString();
            lblEmail.Text = res.Hospede.Email;
            lblTelefone.Text = res.Hospede.Telefone;
            lblCPF.Text = res.Hospede.CPF;
            lblPassaporte.Text = res.Hospede.Passaporte;

            lblReservaID.Text = res.Id.ToString();
            lblNumQuarto.Text = res.Quarto.Numero.ToString();
            lblTipoQuarto.Text = res.Quarto.Tipo.NomeTipo;
            lblAdultos.Text = res.Adultos.ToString();
            lblCriancas.Text = res.Criancas.ToString();

            lblDespesas.Text = res.Despesas.ToString();
            lblPago.Text = total.ToString();
            lblCheckin.Text = res.CheckIn.ToString();
            lblCheckOut.Text = res.CheckOut.ToString();

            

            string status = res.Status;
            lblStatus.Text = status;
            switch (status)
            {
                case "RESERVADA":
                    btnIniciar.Enabled = true;
                    btnFinalizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    groupPagamento.Enabled = false;
                    break;
                case "INICIADA":
                    if (res.Despesas > total)
                    {
                        groupPagamento.Enabled = true;
                    }
                    btnIniciar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnFinalizar.Enabled = true;
                    break;
                case "FINALIZADA":
                    btnIniciar.Enabled = false;
                    btnFinalizar.Enabled = false;
                    btnCancelar.Enabled = false;
                    groupPagamento.Enabled = false;
                    break;
                case "CANCELADA":
                    btnIniciar.Enabled = false;
                    btnFinalizar.Enabled = false;
                    btnCancelar.Enabled = false;
                    groupPagamento.Enabled = false;
                    break;
            }

            dgviewConsumos.DataSource = cDAO.ListarPorReserva(res.Id);
            dgviewPagamentos.DataSource = pDAO.ListarPorReserva(res.Id);
        }

        private void btnAddPagamento_Click(object sender, EventArgs e)
        {
            if(txtValor.Text != "" && comboForma.Text != "")
            {
                Pagamento pag = new Pagamento();
                pag.Valor = double.Parse(txtValor.Text);
                pag.Forma = comboForma.Text;
                pag.Reserva = res;
                double soma = double.Parse(lblPago.Text) + pag.Valor;
                if(soma <= res.Despesas)
                {
                    string mensagem = pDAO.Inserir_Att(pag);
                    lblPago.Text = soma.ToString();
                    ValidacoesForms.ExibirMensagem(mensagem);
                    dgviewPagamentos.DataSource = pDAO.ListarPorReserva(res.Id);
                    lblPago.Text = soma.ToString();
                }
                else
                {
                    MessageBox.Show("Pagamento não pode exceder despesas totais");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos de pagamento");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            res.Cancelar();
            resDAO.Inserir_Att(res);
            PopularDadosReserva(res.Id);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(lblDespesas.Text != lblPago.Text)
            {
                ValidacoesForms.ExibirMensagem("Pagamento incompleto");
            }
            else
            {
                res.Finalizar();
                resDAO.Inserir_Att(res);
                PopularDadosReserva(res.Id);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(res.CheckIn.Date != DateTime.Now.Date)
            {
                ValidacoesForms.ExibirMensagem("O dia do checkin não é hoje");
            }
            else
            {
                res.Iniciar();
                resDAO.Inserir_Att(res);
                PopularDadosReserva(res.Id);
            }
        }
    }
}
