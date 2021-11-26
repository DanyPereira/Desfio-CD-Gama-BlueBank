using System;
using System.Collections.Generic;

namespace BancoBlueBank
{
    class Program
    {
        private static List<Cliente> clientes = new List<Cliente>();
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
            throw new NotImplementedException();
        }

        private static void depositar()
        {
            throw new NotImplementedException();
        }

        private static void verSaldo()
        {
            throw new NotImplementedException();
        }

        private static void cadastrarCliente()
        {
            throw new NotImplementedException();
        }
    }
}