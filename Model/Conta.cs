using System;

namespace Model
{
    public class Conta
    {
        private string _NomeUsuario;
        private string _Senha;
        private DateTime _DataAtualizacao;
        private Hospede _HospAssociado;
        private Funcionario _FuncAssociado;

        public string NomeUsuario { get => _NomeUsuario; set => _NomeUsuario = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
        public DateTime DataAtualizacao { get => _DataAtualizacao; set => _DataAtualizacao = value; }
        public Hospede HospAssociado { get => _HospAssociado; set => _HospAssociado = value; }
        public Funcionario FuncAssociado { get => _FuncAssociado; set => _FuncAssociado = value; }

        public Conta()
        {
        }
    }
}
