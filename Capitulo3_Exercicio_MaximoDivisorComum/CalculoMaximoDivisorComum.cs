using System;

namespace Capitulo3_Exercicio_MaximoDivisorComum
{
    public class CalculoMaximoDivisorComum
    {
        public static void Main(string[] args)
        {
            AlgoritmoDeEuclides algoritmoMDC = new AlgoritmoDeEuclides();
            var valorA = 36; //12; // 36
            var valorB = 90; //18; // 90
            Console.WriteLine("M.D.C("+valorA+","+valorB+") = " + 
                algoritmoMDC.CalculaMaximoDivisorComumRecursivamente(valorA, valorB));
            Console.ReadKey();
        }
    }
}
