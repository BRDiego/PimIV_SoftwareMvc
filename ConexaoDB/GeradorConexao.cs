using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexaoDB
{
    public static class GeradorConexao
    {
        public static SqlConnection AbrirConexao()
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
