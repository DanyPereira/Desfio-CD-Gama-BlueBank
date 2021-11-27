using System;
using System.Collections.Generic;

namespace BancoBlueBank
{
    class Agencia
    {
      public Guid codAgencia {get;set;}
      public string nomeAgencia {get;set;}
      public List <Conta> contas {get;set;}
      public string Endereco { get; set; }
    }
}
