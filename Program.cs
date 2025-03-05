using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha a questão para executar:");
                Console.WriteLine("1 - Questão 1");
                Console.WriteLine("2 - Questão 2");
                Console.WriteLine("3 - Questão 3");
                Console.WriteLine("4 - Questão 4");
                Console.WriteLine("5 - Questão 5");
                Console.WriteLine("6 - Questão 6");
                Console.WriteLine("7 - Questão 7");
                Console.WriteLine("8 - Questão 8");
                Console.WriteLine("9 - Questão 9");
                Console.WriteLine("10 - Questão 10");
                Console.WriteLine("11 - Questão 11");
                Console.WriteLine("12 - Questão 12");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite sua escolha: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Q1.Executar();
                        break;
                    case "2":
                        Q2.Executar();
                        break;
                    case "3":
                        Q3.Executar();
                        break;;
                     case "4":     
                         Q4.Executar();
                        break;
                    case "5":
                        Q5.Executar();
                        break;
                    case "6":
                        Q6.Executar();
                        break;
                    case "7":
                        Q7.Executar();
                        break;
                    case "8":
                        Q8.Executar();
                        break;
                    case "9":
                        Q9.Executar();
                        break;
                    case "10":
                        Q10.Executar();
                        break;
                    case "11":
                        Q11.Executar(); 
                        break;
                    case "12":
                        Q12.Executar();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
