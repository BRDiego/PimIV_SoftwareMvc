﻿using System;
using System.Data;
using System.Data.SqlClient;
using Model;
using ConexaoDB;

namespace DAL
{
    public class HospedeDAO : IListaPorStatus
    {
        readonly ConexaoSQLServer _conexao = new ConexaoSQLServer();
                
        public string Inserir_Att(Hospede hospede)
        {
            try
            {
                using (SqlConnection conexao = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("HOSP_Inserir", conexao);
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
                    return procedure.Parameters["@Retorno"].Value.ToString();
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        
        public Hospede Carregar(string cpfPass)
        {
            try
            {
                Hospede hospede = new Hospede();
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("HOSP_Carregar", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@CpfPass", SqlDbType.VarChar)
                        .Value = cpfPass;

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
                        hospede.setarCPF(leitor["CPF"].ToString());
                        hospede.Passaporte = leitor["Passaporte"].ToString();
                        hospede.Status = leitor[8].ToString();
                        hospede.DataAtualizacao =
                            DateTime.Parse(leitor["DataAtualizacao"].ToString());
                        ContaDAO cDAO = new ContaDAO();
                        int nConta = cDAO.HospPossuiConta(hospede.CPF);
                        if (nConta > 0)
                        {
                            hospede.Conta = cDAO.Carregar(nConta);
                        }
                    }
                    leitor.Close();
                }
                return hospede;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool EmailRegistrado(string email)
        {
            bool registrado = false;
            try
            {
                using (SqlConnection conn = _conexao.AbrirConexao())
                {
                    string query = "SELECT Id from Hospede where Email = '"+email+"'";
                    SqlCommand comando = new SqlCommand(query, conn);
                    object resultado = comando.ExecuteScalar();
                    if(resultado != null)
                    {
                        registrado = true;
                    }
                }
                return registrado;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataTable ListarStatus(string status)
        {
            try
            {
                DataTable tabela = new DataTable();
                using(SqlConnection conn = _conexao.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("HOSP_ListarStatus", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;

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
