using System;
using ConexaoDB;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ContaDAO
    {
        readonly ConexaoSQLServer _conexao = new ConexaoSQLServer();
        HospedeDAO hDAO = new HospedeDAO();
        public bool LoginCorreto(string nome, string senha,
            out string func, out string cargo)
        {
            bool correto = false;
            func = "";
            cargo = "";
            using (SqlConnection conn = _conexao.AbrirConexao())
            {
                SqlCommand procedure = new SqlCommand("CONT_ValidarFunc", conn);
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
                SqlCommand procedure = new SqlCommand("CONT_Inserir", conn);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@NomeUsuario", SqlDbType.VarChar)
                    .Value = conta.NomeUsuario;
                procedure.Parameters.Add("@Senha", SqlDbType.VarChar)
                    .Value = conta.Senha;
                if(conta.HospAssociado != null)
                {
                    procedure.Parameters.Add("@IdHospede", SqlDbType.Int)
                        .Value = conta.HospAssociado.Id;
                    procedure.Parameters.Add("@IdFunc", SqlDbType.Int)
                        .Value = 0;
                }
                else
                {
                    procedure.Parameters.Add("@IdHospede", SqlDbType.Int)
                        .Value = 0;
                    procedure.Parameters.Add("@IdFunc", SqlDbType.Int)
                        .Value = conta.FuncAssociado.Id;
                }
                procedure.Parameters.Add("@Retorno", SqlDbType.VarChar, 100)
                    .Direction = ParameterDirection.Output;

                procedure.ExecuteNonQuery();
                string saida = procedure.Parameters["@Retorno"].Value.ToString();
                return saida;
            }
        }

        public int PossuiConta(string CPF)
        {
            int resultado = 0;
            try
            {
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    string query = "select C.Id from contaLogin C " +
                    "inner join Hospede h ON h.id = C.IdHospede " +
                    "where h.CPF = '"+CPF+"'";
                    SqlCommand comando = new SqlCommand(query, conn);
                    object id = comando.ExecuteScalar();
                    if ( id != null)
                    {
                        return int.Parse(id.ToString());
                    }
                }
                return resultado;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public Conta Carregar(int id)
        {
            try
            {
                using(SqlConnection conn = _conexao.AbrirConexao())
                {
                    string query = "SELECT * from ContaLogin " +
                        "where Id = " + id;
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader leitor = comando.ExecuteReader();
                    leitor.Read();
                    Conta conta = new Conta();
                    conta.NomeUsuario = leitor[1].ToString();
                    conta.Senha = leitor[2].ToString();
                    conta.DataAtualizacao = DateTime.Parse(leitor[3].ToString());
                    return conta;
                }

            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public Conta ValidarHospede(string email, string senha)
        {
            try
            {
                using(SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("CONT_ValidarHosp", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@Email", SqlDbType.VarChar)
                        .Value = email;
                    procedure.Parameters.Add("@Senha", SqlDbType.VarChar)
                        .Value = senha;
                    SqlDataReader leitor = procedure.ExecuteReader();
                    leitor.Read();
                    if (leitor.HasRows)
                    {
                        if (leitor["Senha"].ToString().Equals(senha))
                        {
                            Conta conta = new Conta();
                            int id = int.Parse(leitor["conid"].ToString());
                            conta = this.Carregar(id);
                            Hospede hosp = new Hospede();
                            hosp = hDAO.Carregar(leitor["cpf"].ToString());
                            conta.HospAssociado = hosp;
                            return conta;
                        }
                    }
                }
                return null;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
