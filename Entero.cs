using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRepaso
{
    class Entero
    {
        private int n;
        public Entero()
        {
            n = 0;
        }
        public Entero(int x)
        {
            n = x;
        }
        public void Cargar(int x)
        {
            n = x;
        }
        public bool VerificarFibo()
        {
            int a = -1;
            int b = 1;
            int c = a + b;
            while (c < n)
            {
                a = b;
                b = c;
                c = a + b;
            }
            if (c == n)
                return true;
            return false;
        }
        public bool EsPrimo()
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public void Invertir()
        {
            int dig,
                num = 0;
            while (n > 0)
            {
                dig = n % 10;
                n = n / 10;
                num = num * 10 + dig;
            }
            this.n = num;
        }
    }
}
