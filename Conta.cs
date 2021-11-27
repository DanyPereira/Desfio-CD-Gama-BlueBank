using System;

namespace BancoBlueBank
{
    class Conta
    {
        public int senha {get;set;}
        public double saldo {get;set;}
        public string numConta {get;set;}
        public Agencia agencia {get;set;}
        public Cliente cliente {get;set;}
    }
}
