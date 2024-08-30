using System;

namespace Fibonacci {
    public class FibonacciClass {
        public static void NumeroFibonacci(){
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }

        private static bool PertenceFibonacci(int numero){
            int fibOpcao1 = (int)(5 * Math.Pow(numero, 2) + 4);
            int fibOpcao2 = (int)(5 * Math.Pow(numero, 2) - 4);
            int fibRaiz1 = (int)Math.Sqrt(fibOpcao1);
            int fibRaiz2 = (int)Math.Sqrt(fibOpcao2);

            if(fibRaiz1 * fibRaiz1 == fibOpcao1 ||
               fibRaiz2 * fibRaiz2 == fibOpcao2){
                return true;
            }
            return false;
        }
    }
}
