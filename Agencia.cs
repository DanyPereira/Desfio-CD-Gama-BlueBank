using System;
using System.Collections.Generic;

namespace BancoBlueBank
{
    class Agencia
    {
      public int codAgencia {get;set;}
      public string nomeAgencia {get;set;}
      public List <Conta> contas {get;set;}
      public string endereco { get; set; }

        public Agencia(int codAgencia, string nomeAgencia, string enderecoAgencia)
        {
            this.codAgencia = codAgencia;
            this.nomeAgencia = nomeAgencia;
            this.endereco = enderecoAgencia;
        }
    }
}