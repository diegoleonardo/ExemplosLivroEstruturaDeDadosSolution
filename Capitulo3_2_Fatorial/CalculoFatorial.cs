using System;

namespace Capitulo3_2_Fatorial
{
    public class CalculoFatorial
    {
        public static void Main(string[] args)
        {
            var fatorialDeQuatro = CalculaFatorialRecursivo(4);
            Console.WriteLine(fatorialDeQuatro);
            Console.ReadKey();
        }

        public static int CalculaFatoriaIterativo(int NFatorial)
        {
            int resultadoFatorial = 1;
            if (NFatorial == 0)
                return resultadoFatorial;
            else
            {
                while(NFatorial > 0)
                {
                    resultadoFatorial = resultadoFatorial * NFatorial;
                    NFatorial--;
                }
            }
            return resultadoFatorial;
        }

        public static int CalculaFatorialRecursivo(int NFatorial)
        {
            int resultadoFatorial = 1;
            if (NFatorial == 0)
                return resultadoFatorial;
            else
            {
                return NFatorial * CalculaFatorialRecursivo(NFatorial - 1);
            }
        }
    }
}
