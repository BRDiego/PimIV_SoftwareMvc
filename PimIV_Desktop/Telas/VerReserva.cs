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

namespace PimIV_Desktop.Telas
{
    public partial class VerReserva : UserControl
    {
        public VerReserva()
        {
            InitializeComponent();
        }

        public void PopularDadosReserva(int id)
        {
            string connection = "Data Source=DESKTOP-6FNB3PC\\SQLEXPRESS;Initial Catalog=Pim4Dev;Integrated Security=True";
            string query = "SELECT R.Idreserva AS [idreserva], R.reserva_status AS [status], " +
                           "r.datacheckin AS [checkin], r.datacheckout AS [checkout], " +
                           "r.adultos AS [adultos], r.CRIANCAS AS [criancas], " +
                           "r.DESPESAS AS [despesas], 10 AS [pago], " +
                           "h.nome AS [hospede], h.sexo AS [sexo], " +
                           "h.cpf AS [cpf], h.passaporte AS [passaporte], " +
                           "h.DATANASC AS [datanasc], h.email AS [email], " +
                           "H.telefone as [telefone], q.numero AS [numquarto], " +
                           "q.tipo AS [tipo] " +
                           "FROM Reserva R, Hospede h, Quarto q " +
                           "WHERE R.IDRESERVA = " + id + " AND R.Id_quarto = Q.IDQuarto AND R.ID_Hospede = H.IDHospede";

            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                lblHospede.Text = reader["hospede"].ToString();
                lblNumQuarto.Text = reader["numquarto"].ToString();
                lblTipoQuarto.Text = reader["tipo"].ToString();
                lblReservaID.Text = reader["idreserva"].ToString();
                lblSexo.Text = reader["sexo"].ToString();
                lblNasc.Text = reader["datanasc"].ToString();
                lblTelefone.Text = reader["telefone"].ToString();
                lblCPF.Text = reader["cpf"].ToString();
                lblPassaporte.Text = reader["passaporte"].ToString();
                lblEmail.Text = reader["email"].ToString();
                lblAdultos.Text = reader["adultos"].ToString();
                lblCriancas.Text = reader["criancas"].ToString();
                lblCheckin.Text = reader["checkin"].ToString();
                lblCheckOut.Text = reader["checkout"].ToString();
                lblStatus.Text = reader["status"].ToString();
                lblDespesas.Text = "R$ "+ reader["despesas"].ToString();
                lblPago.Text = "R$ " + reader["pago"].ToString();

                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro durante a população dos dados da reserva\n" +
                    err.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnConsumos_Click(object sender, EventArgs e)
        {
        }

        private void VerReserva_Load(object sender, EventArgs e)
        {

        }

    }
}
