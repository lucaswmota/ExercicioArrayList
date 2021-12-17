using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArray
{
    internal class Comissionado
    {
        string nome { get; set; }
        double salario { get; set; }    
        double vendas { get; set; } 
        double comissao { get; set; }

        public void cadastrar()
        {
            Console.WriteLine("Informe o Nome do Funcionario:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o Valor das Vendas");
            vendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Porcentagem de Comissão sobre as vendas:");
            comissao = double.Parse(Console.ReadLine());

            salario = vendas * (comissao / 100);
        }

        public void exibir()
        {
            Console.WriteLine($"Nome do Funcionario: {nome}" +
                $"\nVendas: {vendas.ToString("C")}" +
                $"\nSalario: {salario.ToString("C")}" +
                $"\n");
        }
    }
}
