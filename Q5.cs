using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q5
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 5: Conversor de Temperatura");


            Console.Write("Digite a temperatura em graus Celsius (Apenas Números): ");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
            
                double fahrenheit = celsius * 9 / 5 + 32;
                double kelvin = celsius + 273.15;

                Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}°F");
                Console.WriteLine($"Temperatura em Kelvin: {kelvin:F2}K");
            }
            else
            {
                Console.WriteLine("Valor inválido! Certifique-se de digitar um número.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
