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
        public List<Pagamento> Pagamentos = new List<Pagamento>();
        public List<Consumo> Consumos = new List<Consumo>();

        public int Id { get => _Id; set => _Id = value; }
        public DateTime CheckIn { get => _CheckIn; set => _CheckIn = value; }
        public DateTime CheckOut { get => _CheckOut; set => _CheckOut = value; }
        public int Adultos { get => _Adultos; set => _Adultos = value; }
        public int Criancas { get => _Criancas; set => _Criancas = value; }
        public double Despesas { get => _Despesas; private set => _Despesas = value; }
        public string Status { get => _Status; private set => _Status = value; }
        public Hospede Hospede { get => _Hospede; set => _Hospede = value; }
        public Quarto Quarto { get => _Quarto; set => _Quarto = value; }

        public Reserva()
        {
            Status = "RESERVADA";
            _Hospede = new Hospede();
            _Quarto = new Quarto();
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

        public string Finalizar()
        {
            if (Despesas == Consumos.Sum(consumo => consumo.Total))
            {
                CheckOut = DateTime.Now;
                Status = "FINALIZADA";
                return "Reserva finalizada";
            }
            else
            {
                return "Pagamento incompleto";
            }
        }

        public double CalcularDespesas(double aduDiaria, double criDiaria)
        {
            int diarias = int.Parse(CheckOut.Subtract(CheckIn).TotalDays.ToString());
            Despesas = (Quarto.Tipo.Preco * diarias) + (aduDiaria * Adultos)
                + (criDiaria * Criancas);
            return Despesas;
         }

        public void Cancelar()
        {
            Status = "CANCELADA";
        }

        public bool ReservaValida(out string msg)
        {
            bool valida = true;
            msg = "";
            if(CheckIn.Date < DateTime.Now.Date)
            {
                valida = false;
                msg = "Data de CheckIn não pode ser anterior ao dia de hoje";
            }
            if (CheckOut <= CheckIn)
            {
                valida = false;
                msg = "Data de saída (CheckOut) não pode ser igual ou anterior " +
                    "a data de entrada (CheckIn)";
            }
            return valida;
        }
    }
}
