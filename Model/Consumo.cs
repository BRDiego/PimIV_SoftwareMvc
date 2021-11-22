using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Consumo
    {
        private int _Id;
        private DateTime _Momento;
        private int _Quantidade;
        private Produto _Produto;
        private double _Total;
        private Reserva _Reserva;

        public int Id { get => _Id; set => _Id = value; }
        public DateTime Momento { get => _Momento; set => _Momento = value; }
        public int Quantidade { get => _Quantidade; set => _Quantidade = value; }
        public Produto Produto { get => _Produto; set => _Produto = value; }
        public double Total { get => _Total; set => _Total = value; }
        public Reserva Reserva { get => _Reserva; set => _Reserva = value; }

        public Consumo()
        {
            Reserva = new Reserva();
            Produto = new Produto();
        }
    }
}
