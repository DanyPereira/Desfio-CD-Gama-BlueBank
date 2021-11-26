using System;
using System.Collections.Generic;

namespace BancoBlueBank
{
    class Agencia
    {
        public int Codigo { get; set; }
        public string Endereco { get; set; }
        public List<Conta> contas { get; set; }

    }
}
