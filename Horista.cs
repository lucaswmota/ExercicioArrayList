using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArray
{
    internal class Horista
    {
        string nome { get; set; }
        double salario { get; set; }
        double valorHora { get; set; }  
        int horas { get; set; }

        public void cadastrar()
        {
            Console.WriteLine("Insira o Nome do Funcionario:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o Valor da Hora:");
            valorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantas horas o Funcionario fez:");
            horas = int.Parse(Console.ReadLine());

            salario = horas * valorHora;
        }

        public void exibir()
        {
            Console.WriteLine($"Nome do Funcionario: {nome}" +
                $"\nQuantidade de Horas: {horas}" +
                $"\nSalario com Horas valendo {valorHora.ToString("C")}: {salario.ToString("C")}" +
                $"\n");
        }

    }
}
