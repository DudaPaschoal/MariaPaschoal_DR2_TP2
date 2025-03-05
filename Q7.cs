using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q7
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 7: Verificador de Número Par ou Ímpar");

          
            Console.Write("Digite um número inteiro: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
              
                if (numero % 2 == 0)
                    Console.WriteLine($"O número {numero} é Par.");
                else
                    Console.WriteLine($"O número {numero} é Ímpar.");
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
