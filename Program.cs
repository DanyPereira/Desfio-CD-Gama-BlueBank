using System;
using System.Collections.Generic;
using System.Threading;

namespace BancoBlueBank
{
    class Program
    {
        private static List<Cliente> clientes = new List<Cliente>();
         static  List <Agencia> agencias = new List<Agencia>();
        static List <Conta> contacliente = new List<Conta>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Banco BlueBank!\n");
                Console.WriteLine("Selecione a opção desejada:\n");
                Console.WriteLine("1 - Desejo ser cliente\n" +
                                  "2 - Já sou cliente\n" +
                                  "3 - Listar clientes\n" +
                                  "4 - Encerrar programa\n");
                int opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastrarCliente();
                        break;

                    case 2:
                    // Pedir confirmação se cliente está cadastrado através do CPF
                        Console.WriteLine("Informe o CPF");
                        var CPF = Console.ReadLine();
                       
                        foreach(var cli in clientes)
                        {
                            if (CPF == cli.Cpf) // se CPF digitado for igual a algume que esteja na lista, continuar
                            {
                                continue;
                            }

                            else
                            {
                                Console.WriteLine("CPF não localizado"); // se for diferente, retornar.
                                return;
                            }
                        }
                        Console.WriteLine("Selecione a operação desejada:\n");
                        Console.WriteLine("1 - Ver saldo\n" +
                                          "2 - Depositar\n" +
                                          "3 - Sacar\n" +
                                          "4 - Transferir\n" +
                                          "5 - Extrato\n" +
                                          "6 - Sair\n");
                        int operacao = Convert.ToInt16(Console.ReadLine());

                        switch (operacao)
                        {
                            case 1:
                                verSaldo();
                                break;

                            case 2:
                                depositar();
                                break;

                            case 3:
                                sacar();
                                break;

                            case 4:
                                transferir();
                                break;

                            case 5:
                                extrato();
                                break;

                            case 6:
                                break;
                        }

                        break;

                    case 3:
                        listarClientes();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static void listarClientes()
        {
            Console.Clear();

            if (clientes.Count == 0)
            {
                Console.WriteLine("Lista de clientes ainda se encontra vazia!\n");
            }

            else
            {
                Console.WriteLine("========== Lista de Clientes ==========");

                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"{cliente.Codigo} - {cliente.Nome}");
                    Console.WriteLine("---------------------------------------");
                }
            }
        }

        private static void extrato()
        {
            throw new NotImplementedException();
        }

        private static void transferir()
        {
            throw new NotImplementedException();
        }

        private static void sacar()
        {
            Console.WriteLine("Você optou por sacar");
            Thread.Sleep(4000);
            Console.WriteLine("Informe a agência");
            var ag = new Agencia();
            // necessário confirmar em arquivo de agencia, se a agencia digitada está correta;
            Console.WriteLine("Informe a conta");
            var contac = new Conta();
            // necessário confirmar se a conta existe;

            Console.WriteLine("Digite a senha de sua conta");
            var s = Console.ReadLine();

            if (s != contac.senha)
            {
                Console.WriteLine("Senha incorreta");
            }
            else
            {
                Console.WriteLine("Informe o valor a ser sacado");
                var valor = Convert.ToDouble(Console.ReadLine());
                if (valor >contac.Saldo) // confirmando se valor informado é maior que o saldo
                {
                   Console.WriteLine($"Saldo insuficiente. Você possui {contac.Saldo}");
                   return;
                }
                else
                {
                contac.Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine($"Saldo atual{contac.Saldo}");
                }
            }
            }

        private static void depositar()
        {
            Console.WriteLine("Você optou por depositar");
            Thread.Sleep(4000);
            Console.WriteLine("Informe a agência");
            var ag = new Agencia();
            // necessário confirmar em arquivo de agencia, se a agencia digitada está correta;
            Console.WriteLine("Informe a conta");
            var contac = new Conta();
            // necessário confirmar se a conta existe;

            Console.WriteLine("Digite a senha de sua conta");
            var s = Console.ReadLine();

            if (s != contac.senha)
            {
                Console.WriteLine("Senha incorreta");
            }
                else
                {
                    Console.WriteLine("Informe o valor a ser depositado");
                    var valor = Convert.ToDouble(Console.ReadLine());
                    contac.Depositar(valor);
                    Console.WriteLine("Depósito realizado com sucesso!");
                }
        }

        private static double verSaldo()
        {
            Console.WriteLine("Você optou por ver Saldo");
            Thread.Sleep(4000);
            Console.WriteLine("Informe a agência");
            var ag = new Agencia();
            // necessário confirmar em arquivo de agencia, se a agencia digitada está correta;
            Console.WriteLine("Informe a conta");
            var contac = new Conta();
            // necessário confirmar se a conta existe;

            Console.WriteLine("Digite a senha de sua conta");
            var s = Console.ReadLine();

            if (s != contac.senha)
            {
                Console.WriteLine("Senha incorreta");
            }
            return contac.Saldo;
         
        }

        private static void cadastrarCliente()
        {
        Console.WriteLine("Informe o número do seu CPF");
        var CPF = Console.ReadLine();
        var c = new Cliente();
         
        /// consultar se CPF já está cadastrado;
        foreach( var cli in clientes) // fazer a varredura em lista de clientes cadastrados
        {
            if (CPF == cli.Cpf) // verificar se CPF digitado se parece com algum CPF cadastrado
            {
                Console.WriteLine("Cliente já cadastrado"); 
                return;
            }
            else
            {
                c.Codigo = Guid.NewGuid(); // tentativa de fazer o código ser automático
                c.Cpf=CPF;
                Console.WriteLine("Informe o seu nome");
                var nome = Console.ReadLine();
                c.Nome=nome;
                Console.WriteLine("Informe o seu endereço");
                var endereço = Console.ReadLine();
                c.Endereco=endereço;
                
                clientes.Add(c); // adicionando cliente.

                // a ideia é ter um arquivo de agências pré-definida, pra podermos selecionar a agência 
                // aí a conta é gerada no momento do cadastro
                // pedimos para o beneficiário criar uma senha que será utilizada para validar transações

                Console.WriteLine("Cliente cadastrado com sucesso");

            }
        }
            
        }
        
    }
}