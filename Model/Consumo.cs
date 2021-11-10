using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Consumo
    {
        private DateTime _Momento;
        private int _Quantidade;
        private Produto _Produto;
        private Reserva _Reserva;

        public DateTime Momento { get => _Momento; set => _Momento = value; }
        public int Quantidade { get => _Quantidade; set => _Quantidade = value; }
        public Produto Produto { get => _Produto; set => _Produto = value; }
        public Reserva Reserva { get => _Reserva; set => _Reserva = value; }

        public Consumo()
        {
        }
    }
}
