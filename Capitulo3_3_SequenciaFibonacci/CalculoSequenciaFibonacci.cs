using System;

namespace Capitulo3_3_SequenciaFibonacci
{
    public class CalculoSequenciaFibonacci
    {
        public static void Main(string[] args)
        {
            var calculoRecursivoSequenciaFibonacci = CalculaSequenciaFibonacciIterativo(30);
            Console.WriteLine(calculoRecursivoSequenciaFibonacci);
            Console.ReadKey();
        }

        public static int CalculaSequenciaFibonacciIterativo(int numeroSequencia)
        {
            var posicaoAnterior = 0;
            var posicaoAtual = 1;
            var resultadoSequencia = 0;
            if (numeroSequencia == 0 || numeroSequencia == 1)
                return numeroSequencia;
            else
            {
                for(int i=2; i<=numeroSequencia; i++)
                {
                    resultadoSequencia = posicaoAnterior + posicaoAtual;
                    posicaoAnterior = posicaoAtual;
                    posicaoAtual = resultadoSequencia;
                }
            }
            return resultadoSequencia;
        }

        public static int CalculaSequenciaFibonacciRecursivo(int numeroSequencia)
        {
            if (numeroSequencia == 0 || numeroSequencia == 1)
                return numeroSequencia;
            else
            {
                return CalculaSequenciaFibonacciRecursivo(numeroSequencia - 1) 
                        + CalculaSequenciaFibonacciRecursivo(numeroSequencia - 2);
            }
        }
    }
}
