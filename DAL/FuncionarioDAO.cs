using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoDB;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FuncionarioDAO : IListaPorStatus
    {
        ConexaoSQLServer conn = new ConexaoSQLServer();
        HospedeDAO hDAO = new HospedeDAO();
        ContaDAO cDAO = new ContaDAO();

        public string Inserir_Att(Funcionario func)
        {
            try
            {
                using(SqlConnection conex = conn.AbrirConexao())
                {
                    string cpfPass = func.CPF;
                    Hospede hosp = hDAO.Carregar(func.CPF);
                    if (hosp.Id == 0)
                    {
                        hosp = hDAO.Carregar(func.Passaporte);
                        if(hosp.Id == 0)
                        {
                            cpfPass = func.CPF.Length == 11 ? func.CPF : func.Passaporte;
                            hDAO.Inserir_Att(func);
                            hosp = hDAO.Carregar(cpfPass);
                            func.Id = hosp.Id;
                        }
                    }
                    else
                    {
                        func.Id = hosp.Id;
                    }
                    if(func.Id != 0)
                    {
                        SqlCommand procedure = new SqlCommand("FUNC_Inserir", conex);
                        procedure.CommandType = CommandType.StoredProcedure;
                        procedure.Parameters.Add("Cargo", SqlDbType.VarChar)
                            .Value = func.Cargo;
                        procedure.Parameters.Add("Salario", SqlDbType.Decimal)
                            .Value = func.Salario;
                        procedure.Parameters.Add("StatusFunc", SqlDbType.VarChar)
                            .Value = func.Status;
                        procedure.Parameters.Add("IdHospede", SqlDbType.Int)
                            .Value = func.Id;
                        procedure.Parameters.Add("@Retorno", SqlDbType.VarChar, 100)
                            .Direction = ParameterDirection.Output;

                        procedure.ExecuteNonQuery();
                        return procedure.Parameters["@Retorno"].Value.ToString();
                    }
                    return "Erro. Funcionário não cadastrado";
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public Funcionario Carregar(string cpfPass)
        {
            try
            {
                using(SqlConnection conex = conn.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("FUNC_Carregar", conex);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@cpfPass", SqlDbType.VarChar)
                        .Value = cpfPass;
                    SqlDataReader leitor = procedure.ExecuteReader();
                    leitor.Read();
                    if (leitor.HasRows)
                    {
                        Funcionario func = new Funcionario();
                        func.Id = int.Parse(leitor[0].ToString());
                        func.Nome = leitor[1].ToString();
                        func.DataNascimento = DateTime.Parse(leitor[2].ToString());
                        func.Sexo = char.Parse(leitor[3].ToString());
                        func.Email = leitor[4].ToString();
                        func.Telefone = leitor[5].ToString();
                        func.setarCPF(leitor[6].ToString());
                        func.Passaporte = leitor[7].ToString();
                        func.Status = leitor[8].ToString();
                        func.DataAtualizacao = DateTime.Parse(leitor[9].ToString());
                        func.IdFunc = int.Parse(leitor[10].ToString());
                        func.Cargo = leitor[11].ToString();
                        func.Salario = double.Parse(leitor[12].ToString());
                        func.StatusFunc = leitor[13].ToString();
                        func.DataAtualizacaoFunc = DateTime.Parse(leitor[14].ToString());
                        return func;    
                    }
                    return null;
                }
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
                using (SqlConnection conex = conn.AbrirConexao())
                {
                    SqlCommand procedure = new SqlCommand("FUNC_ListarStatus", conex);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;

                    SqlDataAdapter da = new SqlDataAdapter(procedure);
                    da.Fill(tabela);
                }
                return tabela;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
