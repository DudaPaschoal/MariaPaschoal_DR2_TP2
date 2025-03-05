using System;

namespace MariaPaschoal_DR2_TP2
{
    internal class Q3
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Questão 3: Diferença Entre Duas Datas");

         
            Console.WriteLine("Digite a primeira data (formato: dd/MM/yyyy):");
            string input1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda data (formato: dd/MM/yyyy):");
            string input2 = Console.ReadLine();

            if (DateTime.TryParse(input1, out DateTime data1) && DateTime.TryParse(input2, out DateTime data2))
            {
                if (data1 > data2)
                {
                    var temp = data1;
                    data1 = data2;
                    data2 = temp;
                }

                int anos = data2.Year - data1.Year;
                int meses = data2.Month - data1.Month;
                int dias = data2.Day - data1.Day;

                if (dias < 0)
                {
                    meses--;
                    dias += DateTime.DaysInMonth(data2.Year, data2.AddMonths(-1).Month);
                }

                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                Console.WriteLine($"Diferença entre as datas: {anos} ano(s), {meses} mês(es), {dias} dia(s).");
            }
            else
            {
                Console.WriteLine("Uma ou ambas as datas são inválidas! Por favor, insira as datas no formato correto.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
