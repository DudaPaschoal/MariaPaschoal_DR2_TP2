using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q6
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Exercício 6: Cálculo de IMC");

    
            Console.Write("Digite seu peso (em kg): ");

            if (float.TryParse(Console.ReadLine(), out float peso) && peso > 0)
            {
                Console.Write("Digite sua altura (em metros): ");

                if (float.TryParse(Console.ReadLine(), out float altura) && altura > 0)
                {
                    
                   float imc = peso / (altura * altura);
                   
                    string classificacao;
                    if (imc < 18.5)
                        classificacao = "Abaixo do peso";
                    else if (imc < 24.9)
                        classificacao = "Peso normal";
                    else if (imc < 29.9)
                        classificacao = "Sobrepeso";
                    else if (imc < 34.9)
                        classificacao = "Obesidade Grau I";
                    else if (imc < 39.9)
                        classificacao = "Obesidade Grau II";
                    else
                        classificacao = "Obesidade Grau III";

                 
                    Console.WriteLine($"Seu IMC é {imc:F2}");
                    Console.WriteLine($"Classificação: {classificacao}");
                }
                else
                {
                    Console.WriteLine("Altura inválida! Certifique-se de digitar um número maior que zero.");
                }
            }
            else
            {
                Console.WriteLine("Peso inválido! Certifique-se de digitar um número maior que zero.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
