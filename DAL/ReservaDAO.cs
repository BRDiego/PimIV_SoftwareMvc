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
        readonly ConexaoSQLServer  _conexao = new ConexaoSQLServer();

        public List<string> CarregarProdutosAtivos()
        {
            //SqlCommand comando = new SqlCommand();
            //string query = "SELECT p.Nome from Produto p where" +
            //    " p.StatusProd = 'ATIVO'";
            List<string> saida = new List<string>();
            List<Produto> produtos = new List<Produto>();
            Produto prod = new Produto();
            Produto prod2 = new Produto();
            produtos.Add(prod);
            produtos.Add(prod2);
            prod.Nome = "Agua";
            prod.Preco = 22.2;
            prod.Quantidade = 10;
            prod.Validade = DateTime.Parse("22-10-22");
            prod2.Nome = "Laranja";
            prod2.Preco = 10.2;
            prod2.Quantidade = 4;
            prod2.Validade = DateTime.Parse("01-01-22");
            
            foreach(Produto p in produtos)
            {
                saida.Add(p.Nome);
            }
            return saida;
        }

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

        //carregar

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

        //ocupacao

        //receita
    }
}
