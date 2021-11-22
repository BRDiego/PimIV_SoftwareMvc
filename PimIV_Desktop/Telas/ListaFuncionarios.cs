using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimIV_Desktop.Telas
{
    public partial class ListaFuncionarios : UserControl
    {
        private FuncionarioDAO fDAO = new FuncionarioDAO();
        public ListaFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            dadosFuncionario1.Visible = true;
            dadosFuncionario1.BringToFront();
        }

        private void ListaFuncionarios_Leave(object sender, EventArgs e)
        {
            dadosFuncionario1.SendToBack();
            dadosFuncionario1.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscaCPF.Text.Length == 11)
            {
                string cpf = txtBuscaCPF.Text;
                Funcionario func = new Funcionario();
                func = fDAO.Carregar(cpf);
                if (func.Id > 0)
                {
                    dadosFuncionario1.BringToFront();
                    dadosFuncionario1.PreencherCampos(func);
                    dadosFuncionario1.Visible = true;

                }
                else
                {
                    MessageBox.Show("CPF não registrado");
                }
            }
            else
            {
                if (comboStatus.Text != "")
                {
                    dgviewFuncionarios.DataSource = fDAO.ListarStatus(comboStatus.Text);
                }
                else
                {
                    dgviewFuncionarios.DataSource = fDAO.ListarStatus("ATIVO");
                }
            }
            txtBuscaCPF.Text = "";
        }
    }
}
