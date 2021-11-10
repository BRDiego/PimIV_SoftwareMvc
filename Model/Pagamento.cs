using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pagamento
    {
        private double _Valor;
        private string _Forma;
        private DateTime _Momento;
        private Reserva _Reserva;

        public double Valor { get => _Valor; set => _Valor = value; }
        public string Forma { get => _Forma; set => _Forma = value; }
        public DateTime Momento { get => _Momento; set => _Momento = value; }
        public Reserva Reserva { get => _Reserva; set => _Reserva = value; }

        public Pagamento()
        {
        }

        //METODOS

        public bool ValorValido(double valor)
        {
            return true;
        }

        public void SetValor(double valor)
        {

        }
    }
}
