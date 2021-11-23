namespace Model
{
    public class Quarto
    {
        private int _Numero;
        private string _Status;
        private TipoCusto _Tipo;
        private Reserva _Reserva;

        public int Numero { get => _Numero; set => _Numero = value; }
        public string Status { get => _Status; set => _Status = value; }
        public TipoCusto Tipo { get => _Tipo; set => _Tipo = value; }
        public Reserva Reserva { get => _Reserva; set => _Reserva = value; }

        public Quarto()
        {
            _Tipo = new TipoCusto();
        }

        public Quarto(TipoCusto tipo)
        {
            _Tipo = tipo;
        }
    }
}
