using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoCusto
    {
        private string _NomeTipo;
        private double _Preco;
        private DateTime _DataAtualizacao;

        public string NomeTipo { get => _NomeTipo; set => _NomeTipo = value; }
        public double Preco { get => _Preco; set => _Preco = value; }
        public DateTime DataAtualizacao { get => _DataAtualizacao; set => _DataAtualizacao = value; }

        public TipoCusto()
        {
        }

        //METODOS

        public bool NovoPrecoValido()
        {
            return true;
        }

    }
}
