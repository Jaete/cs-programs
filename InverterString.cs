using System;

namespace InverterString
{
    public class InverterStringClass
    {
        public static void Inverter(){
            Console.WriteLine("Escreva uma palavra");
            string? original = Console.ReadLine();

            char[] invertido = new char[original.Length];
            
            for (int i = 0; i < original.Length; i++)
            {
                invertido[i] = original[original.Length - 1 - i];
            }
            
            string resultado = new string(invertido);
            
            Console.WriteLine("Palavra Original: " + original);
            Console.WriteLine("Palavra Invertida: " + resultado);
        }
    }
}