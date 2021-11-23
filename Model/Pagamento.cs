using System;

namespace Model
{
    public class Pagamento
    {
        private int _Id;
        private double _Valor;
        private string _Forma;
        private DateTime _Momento;
        private Reserva _Reserva;

        public int Id { get => _Id; set => _Id = value; }
        public double Valor { get => _Valor; set => _Valor = value; }
        public string Forma { get => _Forma; set => _Forma = value; }
        public DateTime Momento { get => _Momento; set => _Momento = value; }
        public Reserva Reserva { get => _Reserva; set => _Reserva = value; }

        public Pagamento()
        {
        }
    }
}
