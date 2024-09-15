using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_heranca
{
    internal class ContaCorrente
    {
        // Atributos
        private string numeroConta;
        private string titularConta;
        public double saldo;
        
        public string NumeroConta { get => numeroConta; set => numeroConta = value; }
        public string TitularConta { get => titularConta; set => titularConta = value;}
        public double Saldo { get => saldo; set => saldo = value; }


        // Methods
        public void VerSaldo()
        {
            Console.WriteLine($"Sr. {titularConta}, o saldo da sua conta corrente com numero '{numeroConta}' é {saldo}");
        }

        public Double Depositar()
        {
            Console.Write($"Quanto você deseja Depositar a sua conta corrente com o numero '{numeroConta}': ");
            String valorObtido = Console.ReadLine();
            Double valor = Double.Parse(valorObtido);
            Console.WriteLine($"Foi depositado {valor} a sua ContaCorrente");
            double novoSaldo = saldo += valor;
            return novoSaldo;
        }

        public Double Sacar()
        {
            Console.Write($"Quanto você deseja Sacar da sua conta corrente com o numero '{numeroConta}': ");
            String valorObtido = Console.ReadLine();
            Double valor = Double.Parse(valorObtido);
            Console.WriteLine($"Foi depositado {valor} a sua ContaCorrente");
            double novoSaldo = saldo += valor;
            return novoSaldo;
        }

    }
}
