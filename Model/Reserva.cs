using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reserva
    {
        private int _Id;
        private DateTime _CheckIn;
        private DateTime _CheckOut;
        private int _Adultos;
        private int _Criancas;
        private double _Despesas;
        private string _Status;
        private Hospede _Hospede;
        private Quarto _Quarto;

        public int Id { get => _Id; set => _Id = value; }
        public DateTime CheckIn { get => _CheckIn; set => _CheckIn = value; }
        public DateTime CheckOut { get => _CheckOut; set => _CheckOut = value; }
        public int Adultos { get => _Adultos; set => _Adultos = value; }
        public int Criancas { get => _Criancas; set => _Criancas = value; }
        public double Despesas { get => _Despesas; set => _Despesas = value; }
        public string Status { get => _Status; set => _Status = value; }
        public Hospede Hospede { get => _Hospede; set => _Hospede = value; }
        public Quarto Quarto { get => _Quarto; set => _Quarto = value; }

        public Reserva()
        {
        }

        public Reserva(Hospede hosp, Quarto quarto)
        {
            _Hospede = hosp;
            _Quarto = quarto;
        }

        //METODOS

        public void Iniciar()
        {

        }

        public void Finalizar()
        {

        }

        public void Cancelar()
        {

        }

        public void SetData(out string msg)
        {
            msg = "";
        }

        public bool ReservaValida(out string msg)
        {
            bool valida = true;
            msg = "";
            if (CheckOut < CheckIn)
            {
                valida = false;
                msg = "Data de saída (CheckOut) não pode ser anterior " +
                    "a data de entrada (CheckIn)";
            }
            return valida;
        }
        
        public bool ReservaWebValida()
        {
            bool valida = true;
            if (CheckIn.Date > CheckOut.Date)
            {
                valida = false;
            }

            return valida;
        }
    }
}
