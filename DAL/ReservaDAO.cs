using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using ConexaoDB;

namespace DAL
{
    public class ReservaDAO : IListaPorStatus
    {
        private readonly ConexaoSQLServer  _conexao = new ConexaoSQLServer();
        private PagamentoDAO pDAO = new PagamentoDAO();
        public string Inserir_Att(Reserva reserva)
        {
            try
            {
                using(SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("RESE_Inserir", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    //9
                    procedure.Parameters.Add("@Id", SqlDbType.Int)
                        .Value = reserva.Id;
                    procedure.Parameters.Add("@Chin", SqlDbType.DateTime)
                        .Value = reserva.CheckIn;
                    procedure.Parameters.Add("@Chout", SqlDbType.DateTime)
                        .Value = reserva.CheckOut;
                    procedure.Parameters.Add("@StatusRes", SqlDbType.VarChar)
                        .Value = reserva.Status;
                    procedure.Parameters.Add("@NumAdultos", SqlDbType.Int)
                        .Value = reserva.Adultos;
                    procedure.Parameters.Add("@NumCriancas", SqlDbType.Int)
                        .Value = reserva.Criancas;
                    procedure.Parameters.Add("@Despesas", SqlDbType.Decimal)
                        .Value = reserva.Despesas;
                    procedure.Parameters.Add("@IdHospede", SqlDbType.Int)
                        .Value = reserva.Hospede.Id;
                    procedure.Parameters.Add("@NumQuarto", SqlDbType.Int)
                        .Value = reserva.Quarto.Numero;
                    procedure.Parameters.Add("@Retorno", SqlDbType.VarChar, 100)
                        .Direction = ParameterDirection.Output;
                    procedure.ExecuteNonQuery();
                    string retorno = procedure.Parameters["@Retorno"].Value.ToString();
                    return retorno;
                }
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public Reserva Carregar(int id, out double total)
        {
            try
            {
                Reserva reserva = new Reserva();
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("RESE_Carregar", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    SqlDataReader leitor = procedure.ExecuteReader();
                    leitor.Read();
                    reserva.Id = int.Parse(leitor[0].ToString());
                    reserva.CheckIn = DateTime.Parse(leitor[1].ToString());
                    reserva.CheckOut = DateTime.Parse(leitor[2].ToString());
                    reserva.Status = leitor[3].ToString();
                    reserva.Adultos = int.Parse(leitor[4].ToString());
                    reserva.Criancas = int.Parse(leitor[5].ToString());
                    reserva.Despesas = double.Parse(leitor[6].ToString());
                    reserva.Quarto.Numero = int.Parse(leitor[7].ToString());
                    reserva.Quarto.Tipo.NomeTipo = leitor[8].ToString();
                    reserva.Hospede.Nome = leitor[9].ToString();
                    reserva.Hospede.DataNascimento = DateTime.Parse(leitor[10].ToString());
                    reserva.Hospede.Sexo = leitor[11].ToString()[0];
                    reserva.Hospede.Email = leitor[12].ToString();
                    reserva.Hospede.Telefone = leitor[13].ToString();
                    reserva.Hospede.setarCPF(leitor[14].ToString());
                    reserva.Hospede.Passaporte = leitor[15].ToString();
                    leitor.Close();
                }
                total = pDAO.PagoPorReserva(id);
                return reserva;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataTable ListarStatus(string status)
        {
            DataTable tabela = new DataTable();
            try
            {
                using(SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("RESE_ListarStatus", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@Status", SqlDbType.VarChar)
                        .Value = status;

                    SqlDataAdapter da = new SqlDataAdapter(procedure);
                    da.Fill(tabela);
                }
                return tabela;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataTable ListarData(DateTime periodo)
        {
            DataTable tabela = new DataTable();
            try
            {
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("RESE_ListarData", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@Periodo", SqlDbType.Date)
                        .Value = periodo;

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

        public bool TipoDisponivel(DateTime entrada, string tipo, out int quarto)
        {
            quarto = 0;
            bool temVagas = false;
            try
            {
                using(SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("RESE_TipoDisponivel", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Entrada", SqlDbType.Date)
                        .Value = entrada;
                    procedure.Parameters.Add("@TipoDeQuarto", SqlDbType.VarChar)
                        .Value = tipo;

                    SqlDataReader leitor = procedure.ExecuteReader();
                    leitor.Read();
                    int result = int.Parse(leitor["RETORNO"].ToString());
                    if (result == 1)
                    {
                        quarto = int.Parse(leitor["numero"].ToString());
                        temVagas = true;
                    }
                    return temVagas;
                }
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public List<string> CarregarReservasAtivas()
        {
            try
            {

            List<string> saida = new List<string>();
            using (SqlConnection conn = _conexao.AbrirConexao())
            {
                string query = "SELECT r.Id from Reserva r where" +
                    " r.StatusRes = 'INICIADA'";
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    saida.Add(leitor["Id"].ToString());
                }
            }
            return saida;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        //ocupacao

        //receita
    }
}
