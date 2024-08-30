using System;
namespace FaturamentoEstados
{
    public class FaturamentoEstadosClass{
        public static void PorcentagemPorEstado(){
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;
            double Total = SP + RJ + MG + ES + Outros;
            double porcentagemSP = CalcularPorcentagem(SP, Total);
            double porcentagemRJ = CalcularPorcentagem(RJ, Total);
            double porcentagemMG = CalcularPorcentagem(MG, Total);
            double porcentagemES = CalcularPorcentagem(ES, Total);
            double porcentagemOutros = CalcularPorcentagem(Outros, Total);

            Console.WriteLine($"Total de faturamento: R${Total}");
            Console.WriteLine($"Percentual de faturamento de SP: {porcentagemSP:F2}%");
            Console.WriteLine($"Percentual de faturamento do RJ: {porcentagemRJ:F2}%");
            Console.WriteLine($"Percentual de faturamento de MG: {porcentagemMG:F2}%");
            Console.WriteLine($"Percentual de faturamento do ES: {porcentagemES:F2}%");
            Console.WriteLine($"Percentual de faturamento de Outros: {porcentagemOutros:F2}%");
        }

        private static double CalcularPorcentagem(double estado, double total){
            double porcentagem = estado / total * 100;
            return porcentagem;
        }
    }
}