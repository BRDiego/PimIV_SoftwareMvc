using System;
using System.Data.SqlClient;

namespace ConexaoDB
{
    public class ConexaoSQLServer
    {
        public SqlConnection AbrirConexao()
        {
            try
            {
                string connString = "Data Source=DESKTOP-6FNB3PC\\SQLEXPRESS;Initial Catalog=PimIVDev;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(connString);
                conexao.Open();
                return conexao;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
