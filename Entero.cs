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
    }
}
