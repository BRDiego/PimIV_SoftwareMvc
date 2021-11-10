﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hospede
    {
        private int _Id;
        private string _Nome;
        private DateTime _DataNascimento;
        private char _Sexo;
        private string _Email;
        private string _Telefone;
        private string _CPF;
        private string _Passaporte;
        private string _Status;
        private DateTime _DataAtualizacao;
        private Conta _ContaHospede;

        public int Id { get => _Id; set => _Id = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public DateTime DataNascimento { get => _DataNascimento; set => _DataNascimento = value; }
        public char Sexo { get => _Sexo; set => _Sexo = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }
        public string CPF { get => _CPF; set => _CPF = value; }
        public string Passaporte { get => _Passaporte; set => _Passaporte = value; }
        public string Status { get => _Status; set => _Status = value; }
        public DateTime DataAtualizacao { get => _DataAtualizacao; set => _DataAtualizacao = value; }
        public Conta Conta { get => _ContaHospede; set => _ContaHospede = value; }

        public Hospede()
        {
        }

    }
}
