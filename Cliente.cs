using System;

namespace BancoBlueBank
{
    class Cliente
    {
        public Guid Codigo { get; set; } // pelo que entendi o GUID gera códigos mais complexos;
        public string Nome {get;set;}
        public string Cpf {get;set;}
        public string Endereco { get; set; }
    }
}

