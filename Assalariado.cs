using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArray
{
    internal class Assalariado
    {
        string nome { get; set; }  
        double salario { get; set; }   
        double desconto { get; set; }

        public void cadastrar()
        {
            Console.WriteLine("Insira o Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o Salario:");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Insira a porcentagem de Desconto sobre o Salario: {salario.ToString("C")}");
            desconto = double.Parse(Console.ReadLine());

            salario *= 1 - (desconto / 100);
        }

        public void exibir()
        {
            Console.WriteLine($"Nome do Funcionário: {nome}" +
                $"\nSalário (Com Desconto): {salario.ToString("C")}" +
                $"\n");
        }

    }
}
