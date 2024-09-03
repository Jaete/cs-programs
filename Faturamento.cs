using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Faturamento
{
    public class FaturamentoObject{
        public int dia { get; set; }
        public double valor { get; set;}
    }
    public class FaturamentoClass {
        // No enunciado da questão dizia sobre um json ou xml disponível
        // e que deveria ser utilizado. No entanto, não encontrei nenhum disponível no enunciado.
        // Assim sendo, irei inicializar os dados previamente.

        public static void Relatorio(){
            Random random = new();    
            List<FaturamentoObject> faturamentoDiario = new(); 
            double faturamentoMensal = 0;
            int diasFaturados = 0;
            double menorFaturamento = 0;
            double maiorFaturamento = 0;
            double media;
            double diasMaiorQueMedia = 0;

            string caminho_json = "./dados.json";
            if(File.Exists(caminho_json)){
                string jsonString = File.ReadAllText(caminho_json);
                faturamentoDiario = JsonSerializer.Deserialize<List<FaturamentoObject>>(jsonString);
                var ind = 0;
                foreach (var dia in faturamentoDiario)
                {   
                    
                    if(ind == 0){
                        menorFaturamento = dia.valor;
                        maiorFaturamento = dia.valor;
                        faturamentoMensal += dia.valor;
                        ind++;
                        continue;
                    }
                    if(dia.valor != 0){
                        faturamentoMensal += dia.valor;
                        diasFaturados++;
                        if(dia.valor > maiorFaturamento){
                            maiorFaturamento = dia.valor;
                        }
                        if(dia.valor < menorFaturamento){
                            menorFaturamento = dia.valor;
                        }
                    }
                }

            }
            Console.WriteLine($"Dias faturados: {diasFaturados}");
            media = faturamentoMensal / diasFaturados;
            foreach (var dia in faturamentoDiario)
            {
                if(dia.valor > media){
                    diasMaiorQueMedia++;
                }
            }
            
            Console.WriteLine($"Menor valor de faturamento no mês: R${menorFaturamento:F2}");
            Console.WriteLine($"Maior valor de faturamento no mês: R${maiorFaturamento:F2}");
            Console.WriteLine($"Dias de faturamento maiores que a média de R${media:F2}: {diasMaiorQueMedia}");
        }
    }
}