using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using ConexaoDB;

namespace DAL
{
    public class HospedeDAO
    {
        ConexaoSQLServer _conexao = new ConexaoSQLServer();
        
        public void InserirHospede(Hospede hospede, out string mensagem)
        {
            try
            {
                using (SqlConnection conexao = GeradorConexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("InserirHospede", conexao);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Nome",SqlDbType.VarChar)
                        .Value = hospede.Nome;
                    procedure.Parameters.Add("@DataNasc", SqlDbType.Date)
                        .Value = hospede.DataNascimento;
                    procedure.Parameters.Add("@Sexo", SqlDbType.Char)
                        .Value = hospede.Sexo;
                    procedure.Parameters.Add("@Email",SqlDbType.VarChar)
                        .Value = hospede.Email;
                    procedure.Parameters.Add("@Telefone",SqlDbType.VarChar)
                        .Value = hospede.Telefone;
                    procedure.Parameters.Add("@CPF", SqlDbType.VarChar)
                        .Value = hospede.CPF;
                    procedure.Parameters.Add("@Passaporte",SqlDbType.VarChar)
                        .Value = hospede.Passaporte;
                    procedure.Parameters.Add("@StatusHosp",SqlDbType.VarChar)
                        .Value = hospede.Status;
                    procedure.Parameters.Add("@Retorno",SqlDbType.VarChar,100)
                        .Direction = ParameterDirection.Output;

                    procedure.ExecuteNonQuery();
                    mensagem = procedure.Parameters["@Retorno"].Value.ToString();
                }
            }
            catch (Exception err)
            {
                mensagem = err.Message;
            }
        }
        
        public Hospede Carregar(string cpfPass)
        {
            Hospede hospede = new Hospede();
            using (SqlConnection conn = _conexao.AbrirConexao())
            {
                SqlCommand procedure = new SqlCommand("CarregarHospede", conn);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@CPF", SqlDbType.VarChar)
                    .Value = cpfPass;
                procedure.Parameters.Add("@Passaporte", SqlDbType.VarChar)
                    .Value = "";

                SqlDataReader leitor = procedure.ExecuteReader();
                leitor.Read();
                if (leitor.HasRows)
                {
                    hospede.Id = int.Parse(leitor["Id"].ToString());
                    hospede.Nome = leitor["Nome"].ToString();
                    hospede.DataNascimento = DateTime.Parse(leitor[2].ToString());
                    hospede.Sexo = char.Parse(leitor[3].ToString());
                    hospede.Email = leitor["Email"].ToString();
                    hospede.Telefone = leitor["Telefone"].ToString();
                    hospede.CPF = leitor["CPF"].ToString();
                    hospede.Passaporte = leitor["Passaporte"].ToString();
                    hospede.Status = leitor[8].ToString();
                    hospede.DataAtualizacao = 
                        DateTime.Parse(leitor["DataAtualizacao"].ToString());
                }
                leitor.Close();
            }
            return hospede;
        }
    }
}
