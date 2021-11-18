using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConexaoDB;

namespace DAL
{
    public class TipoCustoDAO
    {
        readonly ConexaoSQLServer _conn = new ConexaoSQLServer();

        public List<string> ListaTiposQuarto()
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

    }
}
