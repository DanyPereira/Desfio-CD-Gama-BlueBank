using System;

namespace BancoBlueBank
{
    class Conta
    {
        public string senha {get;set;}
        public double saldo {get;set;}
        public double Saldo { get; internal set; }
        public string numConta {get;set;}
        public Agencia agencia {get;set;}
        public Cliente cliente {get;set;}

        internal void Depositar(double valor)
        {
            throw new NotImplementedException();
        }
    }
}
