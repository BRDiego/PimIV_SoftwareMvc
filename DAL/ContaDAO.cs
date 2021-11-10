using System;
using ConexaoDB;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class ContaDAO
    {
        private ConexaoSQLServer _conexao = new ConexaoSQLServer();
        
        public bool LoginCorreto(string nome, string senha,
            out string func, out string cargo)
        {
            bool correto = false;
            func = "";
            cargo = "";
            using (SqlConnection conn = _conexao.AbrirConexao())
            {
                SqlCommand procedure = new SqlCommand("ValidarLoginFunc", conn);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("NomeUsuario", SqlDbType.VarChar).Value = nome;
                procedure.Parameters.Add("Senha", SqlDbType.VarChar).Value = senha;

                SqlDataReader leitor = procedure.ExecuteReader();
                leitor.Read();
                if (leitor.HasRows)
                {
                    if (nome.Equals(leitor[0].ToString()) &&
                        senha.Equals(leitor[1].ToString()))
                    {
                        correto = true;
                        func = leitor[2].ToString();
                        cargo = leitor[3].ToString();
                    }
                }
            }
            return correto;
        }

        public string Inserir_Att(Conta conta)
        {
            using (SqlConnection conn = _conexao.AbrirConexao())
            {
                SqlCommand procedure = new SqlCommand("Con_Inserir", conn);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@NomeUsuario", SqlDbType.VarChar)
                    .Value = conta.NomeUsuario;
                procedure.Parameters.Add("@Senha", SqlDbType.VarChar)
                    .Value = conta.Senha;
                procedure.Parameters.Add("@IdHospede", SqlDbType.Int)
                    .Value = conta.HospAssociado.Id;
                procedure.Parameters.Add("@IdFunc", SqlDbType.Int)
                    .Value = conta.FuncAssociado.Id;
                procedure.Parameters.Add("@Retorno", SqlDbType.VarChar, 100)
                    .Direction = ParameterDirection.Output;

                procedure.ExecuteNonQuery();
                string saida = procedure.Parameters["@Retorno"].Value.ToString();
                return saida;
            }
        }
    }
}
