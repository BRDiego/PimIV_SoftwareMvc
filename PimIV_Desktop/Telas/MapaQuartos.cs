using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace PimIV_Desktop.Telas
{
    public partial class MapaQuartos : UserControl
    {
        private QuartoDAO qDAO = new QuartoDAO();
        int numero;
        string status;
        public MapaQuartos()
        {
            InitializeComponent();
        }

        private void dgviewQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Para carregar um consumo, dê um duplo clique na linha correspondente");
                return;
            }
            numero = int.Parse(dgviewQuartos[0, e.RowIndex].Value.ToString());
            status = dgviewQuartos[2, e.RowIndex].Value.ToString();
            panelAcoesQuarto.Enabled = true;
        }

        private void btnAlterarStatus_Click(object sender, EventArgs e)
        {
            if(comboAlterar.Text != "")
            {
                Quarto quarto = new Quarto();
                quarto.Numero = numero;
                quarto.Status = comboAlterar.Text;
                qDAO.Alterar(quarto);
                dgviewQuartos.DataSource = qDAO.Listar();
                comboAlterar.SelectedItem = null;
            }
            panelAcoesQuarto.Enabled = false;
        }

        private void panelAcoesQuarto_EnabledChanged(object sender, EventArgs e)
        {
            if(panelAcoesQuarto.Enabled)
            {
                switch (status)
                {
                    case "DISPONIVEL":
                        comboAlterar.Items.Clear();
                        comboAlterar.Items.Add("LIMPEZA");
                        comboAlterar.Items.Add("REPARO");
                        break;
                    case "OCUPADO":
                        comboAlterar.Items.Clear();
                        break;
                    case "LIMPEZA":
                        comboAlterar.Items.Clear();
                        comboAlterar.Items.Add("DISPONIVEL");
                        comboAlterar.Items.Add("REPARO");
                        break;
                    case "REPARO":
                        comboAlterar.Items.Clear();
                        comboAlterar.Items.Add("DISPONIVEL");
                        comboAlterar.Items.Add("LIMPEZA");
                        break;
                }
            }
        }

        private void MapaQuartos_Enter(object sender, EventArgs e)
        {
            dgviewQuartos.DataSource = qDAO.Listar();
        }
    }
}
