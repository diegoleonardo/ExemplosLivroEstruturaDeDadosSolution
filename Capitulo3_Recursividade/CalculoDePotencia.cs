using System;

namespace Capitulo3_Recursividade
{
    public class CalculoDePotencia
    {
        public static void Main(string[] args)
        {
            var resultadoDeDoisPontencialQuatro = CalculaPotenciaDeDoisRecursivo(4);
            Console.WriteLine(resultadoDeDoisPontencialQuatro);
            Console.ReadKey();
        }

        private static int CalculaPotenciaDeDoisIterativo(int potencia)
        {
            int resultado = 1;
            if (potencia <= 0)
                return resultado;
            else
            {
                for(int i = 1; i <= potencia; i++)
                {
                    resultado = resultado * 2;
                }
            }
            return resultado;
        }

        public static int CalculaPotenciaDeDoisRecursivo(int potencia)
        {
            int resultado = 1;
            if (potencia <= 0)
                return resultado;
            else
                return 2 * CalculaPotenciaDeDoisRecursivo(potencia - 1);
        }
    }
}
