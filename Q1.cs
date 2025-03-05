using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MariaPaschoal_DR2_TP2
{
    internal class Q1
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Questão 1: Cálculo de Idade Precisa");
            Console.WriteLine("Digite sua data de nascimento (formato: dd/MM/yyyy):");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dataNascimento))
            {
                DateTime hoje = DateTime.Now;

                int anos = hoje.Year - dataNascimento.Year;
                int meses = hoje.Month - dataNascimento.Month;
                int dias = hoje.Day - dataNascimento.Day;

                if (dias < 0)
                {
                    meses--;
                    dias += DateTime.DaysInMonth(hoje.Year, hoje.AddMonths(-1).Month);
                }

                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                Console.WriteLine($"Idade: {anos} ano(s), {meses} mês(es), {dias} dia(s).");
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
