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
    public class QuartoDAO
    {
        ConexaoSQLServer _conexao = new ConexaoSQLServer();

        public string Alterar(Quarto quarto)
        {
            try
            {
                using (SqlConnection conexao = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("QUAR_Alterar", conexao);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Numero", SqlDbType.Int)
                       .Value = quarto.Numero;
                    procedure.Parameters.Add("@Status", SqlDbType.VarChar)
                       .Value = quarto.Status;
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
                using (SqlConnection conexao = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("QUAR_Listar", conexao);
                    procedure.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter DA = new SqlDataAdapter(procedure);
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

    }
}
