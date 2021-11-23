using System;
namespace Model
{
    public class Funcionario : Hospede
    {
        private int _IdFunc;
        private string _Cargo;
        private double _Salario;
        private string _StatusFunc;
        private DateTime _DataAtualizacaoFunc;
        private Conta _ContaFuncionario;

        public int IdFunc { get => _IdFunc; set => _IdFunc = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public double Salario { get => _Salario; set => _Salario = value; }
        public string StatusFunc { get => _StatusFunc; set => _StatusFunc = value; }
        public DateTime DataAtualizacaoFunc { get => _DataAtualizacaoFunc; set => _DataAtualizacaoFunc = value; }
        public Conta ContaFuncionario { get => _ContaFuncionario; set => _ContaFuncionario = value; }

        public Funcionario():base()
        {
        }
    }
}
