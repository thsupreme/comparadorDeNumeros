using System;

namespace Treinamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero = a 65, maior ou menor");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair");

            var escolhaDoUsuario = int.Parse(Console.ReadLine()!);
            ComparadorDeNumero(escolhaDoUsuario);

            short operacao = short.Parse(Console.ReadLine()!);
            switch (operacao)
            {
                case 0: System.Environment.Exit(0); break;
            }


        }
        static void ComparadorDeNumero(int numero)
        {
            if (numero == 65)
            {
                Console.WriteLine("Igual");
            }

            else if (numero > 65)
            {
                Console.WriteLine("maior");
            }

            else if (numero < 65)
            {
                Console.WriteLine("menor");
            }


        }

    }

}