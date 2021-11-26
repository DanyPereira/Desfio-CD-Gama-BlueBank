using System;

namespace BancoBlueBank
{
    class Conta
    {
        public int Numero { get; set; }
        public Agencia agencia { get; set; }
        public Cliente cliente { get; set; }
        public double Saldo { get; set; }

    }
}
