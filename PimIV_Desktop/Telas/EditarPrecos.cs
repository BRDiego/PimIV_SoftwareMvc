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
    public partial class EditarPrecos : UserControl
    {
        public EditarPrecos()
        {
            InitializeComponent();
        }

        private void LimparEditarPrecos()
        {
            mtxtQuarto1.Clear();
            mtxtQuarto2.Clear();
            mtxtQuarto3.Clear();
            mtxtQuarto4.Clear();
            mtxtQuarto5.Clear();
            mtxtAdulto.Clear();
            mtxtCrianca.Clear();
        }

        private void btnSolt1_Click(object sender, EventArgs e)
        {
            double.Parse(mtxtQuarto1.Text);
            MessageBox.Show(mtxtQuarto1.Text);
            MessageBox.Show(this.ParentForm.Name);
        }

        private void EditarPrecos_Leave(object sender, EventArgs e)
        {
            LimparEditarPrecos();
        }
    }
}
