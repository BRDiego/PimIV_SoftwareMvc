using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConexaoDB;
using Model;

namespace DAL
{
    public class TipoCustoDAO
    {
        readonly ConexaoSQLServer _conn = new ConexaoSQLServer();

        public string Alterar(TipoCusto tipo)
        {
            try
            {
                using (SqlConnection conn = _conn.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("TIPO_Alterar", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Id", SqlDbType.Int).Value = tipo.Id;
                    procedure.Parameters.Add("@Preco", SqlDbType.Decimal).Value = tipo.Preco;

                    int result = procedure.ExecuteNonQuery();
                    if(result == 1)
                    {
                        return "Preço atualizado com sucesso.";
                    }
                    else
                    {
                        return "Ocorreu um erro durante atualização";
                    }
                }
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        
        public TipoCusto Carregar(int id)
        {
            try
            {
                TipoCusto tipo = new TipoCusto();
                using (SqlConnection conn = _conn.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("TIPO_Carregar", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Id", SqlDbType.Int)
                        .Value = id;

                    SqlDataReader leitor = procedure.ExecuteReader();
                    leitor.Read();
                    tipo.NomeTipo = leitor["NomeTipo"].ToString();
                    tipo.Preco = double.Parse(leitor["Preco"].ToString());
                    return tipo;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public List<string> ListarTiposQuarto()
        {
            List<string> saida = new List<string>();
            using (SqlConnection conexao = _conn.AbrirConexao())
            {
                string query = "SELECT NomeTipo FROM TipoCusto";
                SqlCommand comando = new SqlCommand(query, conexao);
                SqlDataReader leitor = comando.ExecuteReader();
                leitor.Read();
                if (leitor.HasRows)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        saida.Add(leitor[0].ToString());
                        leitor.Read();
                    }
                }
            }
            return saida;
        }

        public double[] DiariasAdueCri()
        {
            double[] diarias = new double[2];
            try
            {
                using (SqlConnection conn = _conn.AbrirConexao())
                {
                    string query = "Select Preco from TipoCusto where Id > 5";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader leitor = comando.ExecuteReader();

                    leitor.Read();
                    double diaria = double.Parse(leitor[0].ToString());
                    diarias[0] = diaria;
                    leitor.Read();
                    diaria = double.Parse(leitor[0].ToString());
                    diarias[1] = diaria;
                }
                return diarias;

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public List<TipoCusto> CarregarTipos()
        {
            try
            {
                List<TipoCusto> saida = new List<TipoCusto>();
                using(SqlConnection conn = _conn.AbrirConexao())
                {
                    string query = "SELECT * FROM TIPOCUSTO";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader leitor = comando.ExecuteReader();
                    while (leitor.Read())
                    {
                        TipoCusto tipo = new TipoCusto();
                        tipo.Id = int.Parse(leitor[0].ToString());
                        tipo.NomeTipo = leitor[1].ToString();
                        tipo.Preco = double.Parse(leitor[2].ToString());
                        tipo.DataAtualizacao = DateTime.Parse(leitor[3].ToString());
                        saida.Add(tipo);
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
