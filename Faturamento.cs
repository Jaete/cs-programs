using System;

namespace Faturamento
{
    public class FaturamentoClass {
        // No enunciado da questão dizia sobre um json ou xml disponível
        // e que deveria ser utilizado. No entanto, não encontrei nenhum disponível no enunciado.
        // Assim sendo, irei inicializar os dados previamente.

        public static void Relatorio(){
            Random random = new();    
            int[] faturamentoDiario = new int[30];
            int faturamentoMensal = 0;
            int diasFaturados = 0;
            int menorFaturamento = 0;
            int maiorFaturamento = 0;
            int media;
            int diasMaiorQueMedia = 0;


            for(int i = 0; i < 30; i++){
                if ((i % 7 == 5) || (i % 7 == 6) || i == 14) // 14 representando um feriado
                {
                    faturamentoDiario[i] = 0; // Fim de semana ou feriado
                }else{
                    faturamentoDiario[i] = random.Next(1500, 4500);
                }
                if(faturamentoDiario[i] != 0){
                    if(i == 0){
                        menorFaturamento = faturamentoDiario[i];
                        maiorFaturamento = faturamentoDiario[i];
                    }
                    if(faturamentoDiario[i] < menorFaturamento){
                    menorFaturamento = faturamentoDiario[i];
                    }
                    if(faturamentoDiario[i] > maiorFaturamento){
                        maiorFaturamento = faturamentoDiario[i];
                    }
                    faturamentoMensal += faturamentoDiario[i];
                    diasFaturados++;
                }
            }
            media = faturamentoMensal / diasFaturados;
            for(int i = 0; i < diasFaturados; i++){
                if(faturamentoDiario[i] > media){
                    diasMaiorQueMedia++;
                }
            }
            Console.WriteLine($"Menor valor de faturamento no mês: R${menorFaturamento}");
            Console.WriteLine($"Maior valor de faturamento no mês: R${maiorFaturamento}");
            Console.WriteLine($"Dias de faturamento maiores que a média de R${media}: {diasMaiorQueMedia}");
        }
    }
}