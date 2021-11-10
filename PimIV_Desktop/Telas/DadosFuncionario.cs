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
    public partial class DadosFuncionario : UserControl
    {
        public DadosFuncionario()
        {
            InitializeComponent();
        }

        private void LimparDadosFuncionario()
        {
            txtNome.Clear();
            dtpNasc.ResetText();
            dudSexo.ResetText();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtPassaporte.Clear();
            txtSalario.Clear();
            txtCargo.Clear();
            comboStatusHos.ResetText();
            comboStatusFun.ResetText();
            lblAttFunc.Text = "dataAt";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosFuncionario();
        }

        private void DadosFuncionario_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection sexo = this.dudSexo.Items;
            sexo.Add("M");
            sexo.Add("F");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }

        private void DadosFuncionario_Leave(object sender, EventArgs e)
        {
            LimparDadosFuncionario();
        }

        private void comboStatusHos_KeyUp(object sender, KeyEventArgs e)
        {
            comboStatusHos.Text = "";
        }

        private void comboStatusFun_KeyUp(object sender, KeyEventArgs e)
        {
            comboStatusFun.Text = "";
        }

        private void dudSexo_KeyUp(object sender, KeyEventArgs e)
        {
            dudSexo.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnCadastrar.Parent.Name);
        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {
            ValidacoesForms.ValidarFormulario(groupDadosLogin.Controls
                , out string mensagem);
            if (mensagem != "")
            {

                MessageBox.Show(mensagem);
            }
            MessageBox.Show(btnSalvarLogin.Parent.Name);
        }
    }
}
