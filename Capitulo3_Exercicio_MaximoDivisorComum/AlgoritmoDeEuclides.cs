using System.Collections.Generic;
using System.Linq;

namespace Capitulo3_Exercicio_MaximoDivisorComum
{
    internal class AlgoritmoDeEuclides
    {
        public int CalculaMaximoDivisorComumRecursivamente(int m, int n)
        {
            if (n == 0)
                return m;
            else
                return CalculaMaximoDivisorComumRecursivamente(n, (m % n));
        }

        public int CalculaMaximoDivisorComumIterativamente(int n, int m)
        {
            IList<int> divisor = new List<int>();
            for(int i=2; i<=n; i++)
            {
                if((n % i) == 0 && (m%i)==0)
                {
                    divisor.Add(i);
                }
            }
            return divisor.Max();
        }
    }
}