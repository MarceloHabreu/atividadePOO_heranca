using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_heranca
{
    internal class ContaEspecial: ContaCorrente
    {
        

        // Atributos
        public double Limite = 900;
        private double novoLimite;

        // metodos
        public Double AumentarLimite()
        {
            Console.WriteLine($"Em quanto deseja aumentar o limite Sr{TitularConta}: ");
            String valorObtido = Console.ReadLine();
            double valor = double.Parse(valorObtido);
            novoLimite = Limite += valor;
            return novoLimite;
        }
        public Double DiminuirLimite()
        {
            Console.WriteLine($"Em quanto deseja diminuir o limite Sr{TitularConta}: ");
            String valorObtido = Console.ReadLine();
            double valor = Double.Parse(valorObtido);
            novoLimite = Limite -= valor;
            return novoLimite;

        }

        public void ConsultarLimite()
        {
            Console.WriteLine($"O limite atual é da sua conta com o número {NumeroConta}: " + Limite);
        }
    }
}
