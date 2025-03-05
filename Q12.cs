using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q12
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 12: Jogo de Adivinhação");

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); 

            int tentativa = 0;

            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");

            while (true)
            {
                tentativa++;
                Console.Write($"Tentativa {tentativa}: ");

                if (int.TryParse(Console.ReadLine(), out int palpite))
                {
                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativa} tentativa(s).");
                        break;
                    }
                    else if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é maior. Tente novamente!");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor. Tente novamente!");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido! Certifique-se de digitar um número inteiro.");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
