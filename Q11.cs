using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q11
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 11: Tabuada Interativa");

      
            Console.Write("Digite um número inteiro para calcular sua tabuada: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
               
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Certifique-se de digitar um número inteiro.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
