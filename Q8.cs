using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q8
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 8: Classificação de Nota Escolar");

           
            Console.Write("Digite uma nota de 0 a 10: ");

            if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 10)
            {
              
                string classificacao;
                if (nota <= 5)
                    classificacao = "Insuficiente";
                else if (nota <= 7)
                    classificacao = "Regular";
                else if (nota < 9)
                    classificacao = "Bom";
                else
                    classificacao = "Excelente";

                // Exibe a classificação
                Console.WriteLine($"Nota: {nota:F1} - Classificação: {classificacao}");
            }
            else
            {
                Console.WriteLine("Nota inválida! Certifique-se de digitar um valor entre 0 e 10.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
