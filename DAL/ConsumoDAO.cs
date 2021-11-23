using System;
using Model;
using ConexaoDB;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConsumoDAO : IListaPelaReserva
    {
        private ConexaoSQLServer _conexao = new ConexaoSQLServer();
        private ProdutoDAO prDAO = new ProdutoDAO();
        public string Inserir_Att(Consumo consumo)
        {
            try
            {
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("CONS_Inserir", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Id", SqlDbType.Int)
                        .Value = consumo.Id;
                    procedure.Parameters.Add("@Quantidade", SqlDbType.Int)
                        .Value = consumo.Quantidade;
                    procedure.Parameters.Add("@Produto", SqlDbType.Int)
                        .Value = consumo.Produto.Id;
                    procedure.Parameters.Add("@Reserva", SqlDbType.Int)
                        .Value = consumo.Reserva.Id;
                    procedure.Parameters.Add("@Valor", SqlDbType.Decimal)
                        .Value = consumo.Total;
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

        public DataTable Listar()
        {
            try
            {
                DataTable tabela = new DataTable();
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("CONS_Listar", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

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

        public Consumo Carregar(int id)
        {
            try
            {
                Consumo cons = new Consumo();
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    string query = "Select p.Nome, c.* from Consumo c " +
                        " inner join Produto p ON p.id = c.IdProduto " +
                        " where c.Id = "+ id;
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader leitor = comando.ExecuteReader();
                    leitor.Read();
                    cons.Produto.Nome = leitor[0].ToString();
                    cons.Id = int.Parse(leitor[1].ToString());
                    cons.Quantidade = int.Parse(leitor[2].ToString());
                    cons.Total = double.Parse(leitor[4].ToString());
                    cons.Produto.Id = int.Parse(leitor[5].ToString());
                    cons.Reserva = new Reserva();
                    cons.Reserva.Id = int.Parse(leitor[6].ToString());
                }
                cons.Produto = prDAO.Carregar(cons.Produto.Nome);
                return cons;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public string Deletar(Consumo cons)
        {
            try
            {
                int result = 0;
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    string query = "Delete from Consumo where Id = " + cons.Id;
                    SqlCommand comando = new SqlCommand(query, conn);
                    result = comando.ExecuteNonQuery();
                }
                if(result == 1)
                {
                    return "Consumo removido";
                }
                else
                {
                    return "Erro ao remover consumo";
                }
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
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("CONS_ListarRes", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@Id", SqlDbType.Int).Value = reserva;

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
    }
}
