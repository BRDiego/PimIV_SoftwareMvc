using System.Windows.Forms;
using System;

namespace PimIV_Desktop.Telas
{
    static class ValidacoesForms
    {
        public static void ExibirMensagem(string mensagem)
        {
            formConteudo form = Application.OpenForms["formConteudo"] as formConteudo;
            form.SetarMensagem(mensagem);
        }

        public static void ValidarFormulario(
            Control.ControlCollection colecao, out string mensagem)
        {
            mensagem =  "";
            bool identificador = false;
            foreach (object item in colecao)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    TextBoxBase aux = item as TextBoxBase;
                    if (aux.Text == "" || aux.Text.Length < 2 &&
                        !aux.Name.Contains("alor"))
                    {
                        if (!aux.Name.Contains("CPF") && !aux.Name.Contains("Passaporte"))
                        {
                            mensagem =  "Há dados inválidos. Verifique-os";
                            break;
                        }
                    }
                    if(aux.Name.Contains("alor") && aux.Text.Contains("."))
                    {
                        mensagem = "Utilize ',' no valor monetário, e não '.'(ponto)";
                        break;
                    }
                    if(aux.Name.Contains("PF") || aux.Name.Contains("Passaporte"))
                    {
                        identificador = true;
                    }
                }

                if (item is DomainUpDown)
                {
                    DomainUpDown aux = item as DomainUpDown;
                    if (aux.Text != "")
                    {
                        if (!aux.Items.Contains(aux.Text))
                        {
                            mensagem =  aux.Text + " não é válido";
                            break;
                        }
                    }
                    else
                    {
                        mensagem = "selecione " + aux.Name;
                        break;
                    }
                }
                
                if (item is DateTimePicker)
                {
                    DateTimePicker aux = item as DateTimePicker;
                    if (aux.Name.Contains("asc"))
                    {
                        if (aux.Value.Date.Year > 
                            (DateTime.Now.Date.Year - 18))
                        {
                            mensagem = "Data de nascimento inválida";
                            break;
                        }
                    }
                }

                if (item is ComboBox)
                {
                    ComboBox aux = item as ComboBox;
                    if (aux.Text == "")
                    {
                        mensagem = "Há campos vazios";
                        break;
                    }
                }
            }
            if(identificador == false)
            {
                mensagem = "Informe CPF ou Passaporte ou verifique dados ausentes";
            }
        }
    }
}
