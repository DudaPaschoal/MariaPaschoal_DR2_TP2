using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q2
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Questão 2: Dias até o Próximo Aniversário");

     
            Console.WriteLine("Digite sua data de nascimento (formato: dd/MM/yyyy):");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dataNascimento))
            {
                DateTime hoje = DateTime.Now;

                DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

                if (proximoAniversario < hoje)
                    proximoAniversario = proximoAniversario.AddYears(1);

                int diasRestantes = (proximoAniversario - hoje).Days;

                Console.WriteLine($"Faltam {diasRestantes} dia(s) para o seu próximo aniversário!");
            }
            else
            {
                Console.WriteLine("Data inválida! Por favor, insira uma data no formato correto.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
