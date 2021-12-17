using System;
using System.Collections;

namespace ExercicioArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaAssalariados = new ArrayList();
            ArrayList listaComissionados = new ArrayList();
            ArrayList listaHoristas = new ArrayList();

            int resposta=0;
            string decisao = "S";

            do
            {
                Console.WriteLine($"Cadastro de Funcionarios:" +
                $"\n(1) - Assalariado" +
                $"\n(2) - Comissionado" +
                $"\n(3) - Horista");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Console.Clear();
                        Assalariado assalariado = new Assalariado();

                        Console.WriteLine("Assalariado");

                        assalariado.cadastrar();

                        listaAssalariados.Add(assalariado);

                        Console.WriteLine("Deseja Realizar outro cadastro?" +
                            "\nS - SIM" +
                            "\nN - NÃO");
                        decisao = Console.ReadLine().ToUpper();

                        break;


                    case 2:

                        Console.Clear();
                        Comissionado comissionado = new Comissionado();

                        Console.WriteLine("Comissionado:");

                        comissionado.cadastrar();

                        listaComissionados.Add(comissionado);

                        Console.WriteLine("Deseja Realizar outro cadastro?" +
                            "\nS - SIM" +
                            "\nN - NÃO");
                        decisao = Console.ReadLine().ToUpper();

                        break;

                    case 3:

                        Console.Clear();
                        Horista horista = new Horista();

                        Console.WriteLine("Horista");

                        horista.cadastrar();

                        listaHoristas.Add(horista);

                        Console.WriteLine("Deseja Realizar outro cadastro?" +
                            "\nS - SIM" +
                            "\nN - NÃO");
                        decisao = Console.ReadLine().ToUpper();

                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
                        resposta = int.Parse(Console.ReadLine());
                        break;
                }
            }
            while (decisao == "S");

            Console.WriteLine("Lista de Assalariados:");

            foreach (Assalariado assalariado in listaAssalariados)
            {
                assalariado.exibir();
            }

            Console.WriteLine("Lista de Comissionados");

            foreach (Comissionado comissionado in listaComissionados)
            {
                comissionado.exibir();
            }

            Console.WriteLine("Lista de Horistas");

            foreach (Horista horista in listaHoristas)
            {
                horista.exibir();
            }

            Console.WriteLine("Programa Encerrado.");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}