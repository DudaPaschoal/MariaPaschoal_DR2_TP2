using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q4
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 4: Formulário de Cadastro Simples");

          
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            string idade = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine();

          
            Console.Clear();
            Console.WriteLine("Dados cadastrados:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"E-mail: {email}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
