using System;
using Fibonacci;
using Faturamento;
using FaturamentoEstados;
using InverterString;
public class Program{
    public static void Main(String[] args){
        Console.WriteLine("SEQUÊNCIA DE FIBONACCI");
        FibonacciClass.NumeroFibonacci();
        Console.WriteLine("\n\nRELATORIO DE FATURAMENTO");
        FaturamentoClass.Relatorio();
        Console.WriteLine("\n\nPORCENTAGEM DE FATURAMENTO POR ESTADO");
        FaturamentoEstadosClass.PorcentagemPorEstado();
        Console.WriteLine("\n\nINVERTENDO UMA STRING");
        InverterStringClass.Inverter();
    } 
}