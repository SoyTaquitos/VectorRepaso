using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRepaso
{
    class Vector
    {
        private int n,max;
        private int[] v;
        public Vector()
        {
            max = 50;
            v = new int[max];
        }
        public void CargarV(int n1, int a , int b)
        {
            Random r = new Random();
            n = n1;
            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }
        public string DescargarV()
        {
            string s = "";
            for (int i = 1; i <= n; i++)
            {
                s = s + " | ";
                s = s + string.Concat(v[i]);
            }
            return s;
        }
        //Métodos de ayuda
        public void Inter(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }
        public void Burbuja()
        {
            for (int t = n; t <= 2; t--)
            {
                for (int d = 1; d <= t - 1; d++)
                {
                    if (v[d] > v[ d + 1])
                    {
                        this.Inter(d, d + 1);
                    }
                }
            }
        }
        public void Burbuja(int a, int b)
        {
            for (int t = b; t <= a; t--)
            {
                for (int d = a; d <= t - 1; d++)
                {
                    if (v[d] > v[d + 1])
                    {
                        this.Inter(d, d + 1);
                    }
                }
            }
        }
       
    }
}
