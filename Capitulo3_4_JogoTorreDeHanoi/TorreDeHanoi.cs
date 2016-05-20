using System;

namespace Capitulo3_4_JogoTorreDeHanoi
{
    public class TorreDeHanoi
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao jogo Torre de Hanoi.");
            Console.WriteLine("Digite o número de discos para a nossa Torre de Hanoi: \n");
            var numeroDeDiscos = int.Parse(Console.ReadLine());
            MoveTorre(numeroDeDiscos, "Torre A", "Torre B", "Torre C");
            var numeroMinimoDeJogadas = GetNumeroMinimoDeJogadas(numeroDeDiscos);
            Console.WriteLine("Número minímo de jogadas: " + numeroMinimoDeJogadas);
            Console.WriteLine("Chegamos ao fim! Parabéns!");
            Console.ReadKey();
        }

        public static int GetNumeroMinimoDeJogadas(int numeroDeDiscos)
        {
            var resultado = 1;
            for(int i=1; i<=numeroDeDiscos; i++)
            {
                resultado = resultado * 2;
            }
            return resultado-1;
        }

        public static void MoveTorre(int numeroDeDiscos, string torreOrigem, string torreAuxiliar,
            string torreDestino)
        {
            if (numeroDeDiscos == 1)
                MoveDisco(numeroDeDiscos, torreOrigem, torreDestino);
            else
            {
                MoveTorre(numeroDeDiscos - 1, torreOrigem, torreAuxiliar, torreDestino);
                MoveDisco(numeroDeDiscos, torreOrigem, torreDestino);
                MoveTorre(numeroDeDiscos - 1, torreAuxiliar, torreDestino, torreOrigem);
            }
        }

        public static void MoveDisco(int disco, string torreOrigem, string torreDestino)
        {
            Console.WriteLine(string.Format("\n Movimento: Disco {0} de {1} --> {2}", disco, 
                torreOrigem, torreDestino));
        }
    }
}
