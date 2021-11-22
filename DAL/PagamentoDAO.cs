using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;
using ConexaoDB;

namespace DAL
{
    public class PagamentoDAO : IListaPelaReserva
    {
        private ConexaoSQLServer _conexao = new ConexaoSQLServer();

        public string Inserir_Att(Pagamento pag)
        {
            try
            {
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("PAGA_Inserir", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@Valor", SqlDbType.Decimal).Value = pag.Valor;
                    procedure.Parameters.Add("@Forma", SqlDbType.VarChar).Value = pag.Forma;
                    procedure.Parameters.Add("@IdReserva", SqlDbType.Int).Value = pag.Reserva.Id;
                    procedure.Parameters.Add("@Retorno", SqlDbType.VarChar, 100)
                        .Direction = ParameterDirection.Output;

                    procedure.ExecuteNonQuery();

                    return procedure.Parameters["@Retorno"].Value.ToString();
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public double PagoPorReserva(int reserva)
        {
            try
            {
                double total;
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("PAGA_TotalRes", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@Id", SqlDbType.Int)
                        .Value = reserva;
                    object resultado = procedure.ExecuteScalar();
                    total = double.Parse(resultado.ToString());
                }
                return total;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataTable ListarPorReserva(int reserva)
        {
            try
            {
                DataTable tabela = new DataTable();
                using(SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("PAGA_ListarRes", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@Id", SqlDbType.Int).Value = reserva;

                    SqlDataAdapter da = new SqlDataAdapter(procedure);
                    da.Fill(tabela);
                }
                return tabela;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
