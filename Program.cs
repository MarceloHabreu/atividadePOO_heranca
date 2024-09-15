using aula_heranca;
using System;

namespace CadastroClientesTest
{
    internal static class Program
    {

        public static void Main(string[] args)
        {
            ContaEspecial conta = new ContaEspecial();
            conta.TitularConta = "Marcelo";
            conta.NumeroConta = "13221";

            bool executando = true;

            while (executando)
            {
                Console.WriteLine("Escolha uma opção do menu da ContaEspecial:");
                Console.WriteLine("1. Consultar o limite");
                Console.WriteLine("2. Aumentar o limite");
                Console.WriteLine("3. Diminuir o limite ");
                Console.WriteLine("Ou escolha uma opção do menu da ContaCorrente:");
                Console.WriteLine("4. Consultar saldo ");
                Console.WriteLine("5. Depositar ");
                Console.WriteLine("6. Sacar");
                Console.WriteLine("7. Sair");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                      conta.ConsultarLimite();
                        break;
                    case "2":
                        conta.AumentarLimite();
                        break;
                    case "3":
                        conta.DiminuirLimite();
                        break;
                    case "4":
                        conta.VerSaldo();
                        break;
                    case "5":
                        conta.Depositar();
                        break;
                    case "6":
                        conta.Sacar();
                        break;
                    case "7":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("O número selecionado não contém no menu! \n");
                        break;
                }
            }

        }

    }
}