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
        public void Intercambiar(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }
        public void Burbuja()
        {
            int d;
            for (int t = n; t >= 2; t--)
                for (d = 1; d <= t - 1; d++)
                    if (v[d] > v[d + 1])
                        this.Intercambiar(d, d + 1);
        }
        public void Burbuja(int a, int b)
        {
            for (int t = b; t <= a; t--)
            {
                for (int d = a; d <= t - 1; d++)
                {
                    if (v[d] < v[d + 1])
                    {
                        this.Intercambiar(d, d + 1);
                    }
                }
            }
        }
        public void Burbuja2(int a, int b)
        {
            for (int t = b; t <= a; t--)
            {
                for (int d = a; d <= t - 1; d++)
                {
                    if (v[d] > v[d + 1])
                    {
                        this.Intercambiar(d, d + 1);
                    }
                }
            }
        }
        public void Intercalar2men2may(int a,int b)
        {
            int recorrido = 2;
            for (int i = a; i <= b -1; i++)
            {
                for (int j = i + 1; i <= b; i++)
                {
                    if (recorrido <= 2 && recorrido > 0)
                    {
                        this.Burbuja(i, j);
                        recorrido--;
                    }
                    else
                    {
                        recorrido = 4;
                        this.Burbuja2(i, j);
                        recorrido--;
                    }
                }
                
            }
        }
       
        public void IntercalarPrimoNoPrimo(int a, int b) //N11
        {
            int p, d;
            bool swich = false;
            Entero e1, e2;
            e1 = new Entero(); e2 = new Entero();
            for (p = a; p <= b - 1; p++)
            {
                swich = !swich;
                for (d = p + 1; d <= b; d++)
                {
                    e1.CargarN(v[p]); e2.CargarN(v[d]);
                    if (swich)
                    {
                        if (!e1.EsPrimo() && e2.EsPrimo() ||
                            e1.EsPrimo() && e2.EsPrimo() && (v[d] < v[p]) ||
                            !e1.EsPrimo() && !e2.EsPrimo() && (v[d] < v[p]))
                        {
                            Intercambiar(p, d);
                        }
                    }
                    else
                    {
                        if (e1.EsPrimo() && !e2.EsPrimo() ||
                            e1.EsPrimo() && e2.EsPrimo() && (v[d] < v[p]) ||
                            !e1.EsPrimo() && !e2.EsPrimo() && (v[d] < v[p]))
                        {
                            Intercambiar(p, d);
                        }
                    }

                }
            }
        }


    }
}
