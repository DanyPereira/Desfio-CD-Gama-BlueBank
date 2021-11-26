using System;

namespace BancoBlueBank
{
    class Program
    {
        static void Main(string[] args)
        {
           
                  while (true)
            {
                Console.Clear();
                 Console.WriteLine("Bem vindo ao Banco BlueBank");
                 Console.WriteLine( " Informe o que você deseja fazer");

                Console.WriteLine("1 - Criar nova conta");
                Console.WriteLine("2 - Ver Saldo");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("4 - Sacar");
                Console.WriteLine("5 - Transferir");
                Console.WriteLine("6 - Extrato");
             
                Console.WriteLine("0 - Sair");

                int opcao = Convert.ToInt16(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;
                   
                    case 0:
                        return;
                }
            }
        }
     public void CriarConta()
     {
         
     }




        }
    }

