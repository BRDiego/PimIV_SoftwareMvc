using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
        private string _Nome;
        private int _Quantidade;
        private double _Preco;
        private DateTime _Validade;

        public string Nome { get => _Nome; set => _Nome = value; }
        public int Quantidade { get => _Quantidade; set => _Quantidade = value; }
        public double Preco { get => _Preco; set => _Preco = value; }
        public DateTime Validade { get => _Validade; set => _Validade = value; }

        public Produto()
        {
        }

        //METODOS

        public void DiminuirQuantidade(int qtde)
        {

        }

        public bool EstaVencido()
        {
            return true;
        }
    }
}
