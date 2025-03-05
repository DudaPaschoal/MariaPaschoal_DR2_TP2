using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q10
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 10: Contagem Regressiva");

       
            Console.Write("Digite um número inteiro para iniciar a contagem regressiva: ");

            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
            {
     
                for (int i = numero; i >= 0; i--)
                {
                    if (i == 0)
                        Console.Write($"{i}\n"); 
                    else
                        Console.Write($"{i}, ");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Certifique-se de digitar um número inteiro positivo.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
