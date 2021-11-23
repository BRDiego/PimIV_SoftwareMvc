using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DAL;
using Model;

namespace PimIV_Desktop.Telas
{
    public partial class Relatorios : UserControl
    {
        private ReservaDAO rDAO = new ReservaDAO();
        private FuncionarioDAO fDAO = new FuncionarioDAO();
        public Relatorios()
        {
            InitializeComponent();
        }

        private void Relatorios_Layout(object sender, LayoutEventArgs e)
        {
            AtualizarRelatorios();
        }

        private void AtualizarRelatorios()
        {
            double[] ocupacao = rDAO.Ocupacao();
            double[] receita = rDAO.Receita();
            double[] financas = fDAO.Financas();

            ocupPorc.Text = ocupacao[0].ToString() + "%";
            string entradas = ocupacao[1].ToString();
            entradas += "/" + ocupacao[2].ToString();
            ocupChin.Text = entradas;
            string saidas = ocupacao[3].ToString();
            saidas += "/" + ocupacao[4].ToString();
            ocupChout.Text = saidas;
            rec0.Text = receita[0].ToString();
            rec1.Text = receita[1].ToString();
            rec2.Text = receita[2].ToString();

            fin0.Text = financas[0].ToString();
            fin1.Text = financas[1].ToString();
            fin2.Text = financas[2].ToString();
            fin3.Text = financas[3].ToString();
            fin4.Text = financas[4].ToString();


        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            AtualizarRelatorios();
        }
    }
}
