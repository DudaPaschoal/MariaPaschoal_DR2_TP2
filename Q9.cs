using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q9
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 9: Calculadora de Salário Líquido");

           
            Console.Write("Digite seu salário bruto: R$ ");

            if (double.TryParse(Console.ReadLine(), out double salarioBruto) && salarioBruto > 0)
            {
                double desconto;

        
                if (salarioBruto <= 2000)
                    desconto = salarioBruto * 0.05; // 5%
                else if (salarioBruto <= 4000)
                    desconto = salarioBruto * 0.10; // 10%
                else if (salarioBruto <= 6000)
                    desconto = salarioBruto * 0.15; // 15%
                else
                    desconto = salarioBruto * 0.20; // 20%

                double salarioLiquido = salarioBruto - desconto;

                // Exibe os resultados formatados
                Console.WriteLine($"Salário Bruto: R$ {salarioBruto:F2}");
                Console.WriteLine($"Desconto: R$ {desconto:F2}");
                Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido! Certifique-se de digitar um número positivo.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
