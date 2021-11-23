using System;
namespace Model
{
    public class TipoCusto
    {
        private int _Id;
        private string _NomeTipo;
        private double _Preco;
        private DateTime _DataAtualizacao;

        public int Id { get => _Id; set => _Id = value; }
        public string NomeTipo { get => _NomeTipo; set => _NomeTipo = value; }
        public double Preco { get => _Preco; set => _Preco = value; }
        public DateTime DataAtualizacao { get => _DataAtualizacao; set => _DataAtualizacao = value; }

        public TipoCusto()
        {
        }

    }
}
