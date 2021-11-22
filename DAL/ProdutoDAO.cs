using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ConexaoDB;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProdutoDAO : IListaPorStatus
    {
        ConexaoSQLServer _conexao = new ConexaoSQLServer();

        public string Inserir_Att(Produto prod)
        {
            try
            {
                using (SqlConnection conexao = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("PROD_Inserir", conexao);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Id", SqlDbType.Int)
                        .Value = prod.Id;
                    procedure.Parameters.Add("@Nome", SqlDbType.VarChar)
                        .Value = prod.Nome;
                    procedure.Parameters.Add("@Qtde", SqlDbType.Int)
                        .Value = prod.Quantidade;
                    procedure.Parameters.Add("@Valor", SqlDbType.Decimal)
                        .Value = prod.Preco;
                    procedure.Parameters.Add("@Validade", SqlDbType.Date)
                        .Value = prod.Validade;
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

        public Produto Carregar(string nome)
        {
            Produto Novo = new Produto();
            try
            {
                using (SqlConnection conexao = _conexao.AbrirConexao())
                {
                    string query = "SELECT * FROM PRODUTO WHERE NOME = '" + nome + "'";
                    SqlCommand Comando = new SqlCommand(query, conexao);
                    SqlDataReader Leitor = Comando.ExecuteReader();
                    Leitor.Read();

                    Novo.Id = int.Parse(Leitor[0].ToString());
                    Novo.Nome = Leitor[1].ToString();
                    Novo.Quantidade = int.Parse(Leitor[2].ToString());
                    Novo.Preco = double.Parse(Leitor[3].ToString());
                    Novo.Status = Leitor[5].ToString();
                    Novo.Validade = DateTime.Parse(Leitor[4].ToString());

                    return Novo;
                }


            }

            catch (FormatException)
            {
                Novo.Validade = DateTime.Now.Date;
                return Novo;
            }

            catch (Exception err)
            {
                string name = err.GetType().ToString();
                throw new Exception();
            }


        }

        public DataTable ListarStatus(string Status)
        {
            try
            {
                using (SqlConnection conexao = _conexao.AbrirConexao())
                {
                    string query = "Select Id, Nome, EstoqueQtde as [Estoque], " +
                        " Valor, Validade, StatusProd as [Status] from produto " +
                        " where STATUSPROD = '" + Status + "'";
                    SqlCommand Comando = new SqlCommand(query, conexao);

                    SqlDataAdapter DA = new SqlDataAdapter(Comando);
                    DataTable Tabela = new DataTable();
                    DA.Fill(Tabela);
                    return Tabela;
                }
            }


            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }

        public string Deletar(Produto deletar)
        {
            try
            {
                using (SqlConnection conexao = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("PROD_Deletar", conexao);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Id", SqlDbType.Int)
                        .Value = deletar.Id;


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

        public List<string> CarregarProdutosAtivos()
        {
            try
            {

                List<string> saida = new List<string>();
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    string query = "SELECT p.Nome from Produto p where" +
                        " p.StatusProd = 'ATIVO' and p.EstoqueQtde > 0";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader leitor = comando.ExecuteReader();
                    while (leitor.Read())
                    {
                        saida.Add(leitor["Nome"].ToString());
                    }
                }
                return saida;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

    }
}
