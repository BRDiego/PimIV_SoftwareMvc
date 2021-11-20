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
    public class FuncionarioDAO
    {
        ConexaoSQLServer conn = new ConexaoSQLServer();
        HospedeDAO hDAO = new HospedeDAO();
        ContaDAO cDAO = new ContaDAO();

        public string Inserir_Att(Funcionario func)
        {
            try
            {
                int id = 0;
                using(SqlConnection conex = conn.AbrirConexao())
                {
                    Hospede hosp = hDAO.Carregar(func.CPF);
                    if (hosp.Id == 0)
                    {
                        hDAO.Inserir_Att(func);
                        id = hosp.Id;
                    }
                    else
                    {
                        id = hosp.Id;
                    }
                    if(id != 0)
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
                            .Value = id;
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

        
        
    }
}
