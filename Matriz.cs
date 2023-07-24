using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRepaso
{
    class Matriz
    {
        //Atributos
        const int MAXF = 50;
        const int MAXC = 50;
        private int[,] m;
        private int f, c;
        //Constructor
        public Matriz()
        {
            m = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }
        //Cargar Descargar
        public void CargarM(int nf, int nc, int a, int b)
        {
            Random r = new Random();
            f = nf;
            c = nc;
            for (int f1 = 1; f1 <= f; f1++)
                for (int c1 = 1; c1 <= c; c1++)
                    m[f1, c1] = r.Next(a, b);
        }
        public string DescargarM()
        {
            string s = "";
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    s = s + m[f1, c1] + "\x0009";
                }
                s = s + "\x000d" + "\x000a";
            }
            return s;
        }
        //Métodos 
        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux;
            aux = m[f1, c1];
            m[f1, c1] = m[f2, c2];
            m[f2, c2] = aux;
        }
        public void InterCol(int c1, int c2)
        {
            for (int i = 1; i <= f; i++)
            {
                this.Intercambiar(i, c1, i, c2);
            }
        }
        public void InterFila(int f1, int f2)
        {
            for (int i = 1; i <= c; i++)
            {
                this.Intercambiar(f1, i, f2, i);
            }
        }
        public int GetCantEleDif(int Fila)
        {
            int cant = 0;
            int ele;
            for (int c1 = 1; c1 <= this.c; c1++)
            {
                ele = m[Fila, c1];
                if (ele == m[Fila, c1 + 1])
                {
                    cant++;
                }
            }
            return cant;
        }
        public void OrdenamientoDeMatriz()
        {
            int i;
            for (int fp = 1; fp <= f; fp++)
            {
                for (int cp = 1; cp <= c; cp++)
                {
                    for (int fd = fp; fd <= f; fd++)
                    {
                        if (fd == fp)
                        {
                            i = cp;
                        }
                        else
                        {
                            i = 1;
                        }
                        for (int cd = i; cd <= c; cd++)
                        {
                            if (m[fd, cd] < m[fp, cp])
                            {
                                this.Intercambiar(fd, cd, fp, cp);
                            }
                        }
                    }
                }
            }
        }
        public void OrdenSen()
        {
            this.OrdenamientoColumna();
            for (int c1 = 1; c1 <= c; c1++)
            {
                if (c1 % 2 == 1)
                {
                    this.OrdenarCol(c1);
                }
            }
        }
        public void OrdenamientoColumna()
        {
            int i;
            for (int cp = 1; cp <= c; cp++)
            {
                for (int fp = 1; fp <= f; fp++)
                {
                    for (int cd = cp; cd <= c; cd++)
                    {
                        if (cp == cd)
                        {
                            i = fp;
                        }
                        else
                        {
                            i = 1;
                        }
                        for (int fd = i; fd <= f; fd++)
                        {
                            if (m[fd, cd] < m[fp, cp])
                            {
                                this.Intercambiar(fd, cd, fp, cp);
                            }

                        }
                    }
                }
            }
        }
        public void OrdenarCol(int columna)
        {
            for (int f1 = 1; f1 <= f - 1; f1++)
            {
                for (int f2 = f; f2 >= f1 + 1; f2--)
                {
                    if (m[f2, columna] > m[f2 - 1, columna])
                    {
                        this.Intercambiar(f2, columna, f2 - 1, columna);
                    }
                }
            }
        }
        public void OrdenSen2()
        {
            this.OrdenamientoFila();
            for (int f1 = 1; f1 <= f; f1++)
            {
                if (f1 % 2 == 1)
                {
                    this.OrdenarFila(f1);
                }
            }
        }
        public void OrdenamientoFila()
        {
            int i;
            for (int fp = 1; fp <= f; fp++)
            {
                for (int cp = 1; cp <= c; cp++)
                {
                    for (int fd = fp; fd <= f; fd++)
                    {
                        if (fd == fp)
                        {
                            i = cp;
                        }
                        else
                        {
                            i = 1;
                        }
                        for (int cd = i; cd <= c; cd++)
                        {
                            if (m[fd, cd] > m[fp, cp])
                            {
                                this.Intercambiar(fd, cd, fp, cp);
                            }
                        }
                    }
                }
            }
        }
        public void OrdenarFila(int f1)
        {
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (m[f1, i] < m[f1, j])
                    {
                        this.Intercambiar(f1, i, f1, j);
                    }
                }
            }
        }
        public void OrdTri1()
        {
            int i;
            for (int fp = 1; fp <= f - 1; fp++)           
                for (int cp = fp + 1; cp <= c; cp++)               
                    for (int fd = fp; fd <= f; fd++)
                    {
                        if (fd == fp)                        
                            i = cp;                        
                        else                   
                            i = fd + 1;                       
                        for (int cd = i; cd <= c; cd++)
                        {
                            if (m[fd,cd] < m[fp,cp])
                            {
                                this.Intercambiar(fp, cp, fd, cd);
                            }
                        }
                    }                            
        }
        public void OrdTri2()
        {
            int i;
            for (int cp = 2; cp <= c; cp++)            
                for (int fp = cp - 1; fp >= 1; fp--)
                    for (int cd = cp; cd <= c; cd++)
                    {
                        if (cd == cp)                        
                            i = fp;                      
                        else
                            i = cd - 1;
                        for (int fd = i; fd >= 1; fd--)
                        {
                            if (m[fd,cd] < m[fp,cp])
                                this.Intercambiar(fp, cp, fd, cd);
                        }
                    }
        }
        public void OrdTri3()
        {
            int i;
            for (int cp = 2; cp <= c; cp++)           
                for (int fp = 1; fp <= cp - 1; fp++)                
                    for (int cd = cp; cd <= c; cd++)
                    {
                        if (cd == cp)
                            i = fp;
                        else
                            i = 1;
                        for (int fd = i; fd <= cd - 1; fd++)
                        {
                            if (m[fd, cd] < m[fp, cp])
                                this.Intercambiar(fp, cp, fd, cd);
                        }
                    }                           
        }
        public void OrdTri4()
        {
            int i;
            for (int cp = c; cp >= 2; cp--)           
                for (int fp = cp - 1; fp >= 1; fp--)               
                    for (int cd = cp; cd >= 2; cd--)
                    {
                        if (cd == cp)
                            i = fp;
                        else
                            i = cd - 1;
                        for (int fd = i; fd >= 1; fd--)
                        {
                            if (m[fd, cd] < m[fp, cp])
                                this.Intercambiar(fd, cd, fp, cp);
                        }
                    }            
        }
        public void OrdTri5()
        {
            int i;
            for (int cp = c; cp >= 2; cp--)
            {
                for (int fp = 1; fp <= cp - 1; fp++)
                {
                    for (int cd = cp; cd >= 2; cd--)
                    {
                        if (cd == cp)
                            i = fp;
                        else
                            i = 1;
                        for (int fd = i; fd <= cd - 1; fd++)
                            if (m[fd, cd] < m[fp, cp])
                                this.Intercambiar(fd, cd, fp, cp);
                    }
                }
            }
        }
        public void OrdTri6()
        {
            int i;
            for (int fp = 1; fp <= f - 1; fp++)            
                for (int cp = c; cp >= fp + 1; cp--)               
                    for (int fd = fp; fd <= f - 1; fd++)
                    {
                        if (fd == fp)
                        {
                            i = cp;
                        }
                        else
                            i = c;
                        for (int cd = i; cd >= fd + 1; cd--)
                        {
                            if (m[fd, cd] < m[fp, cp])
                                this.Intercambiar(fd, cd, fp, cp);
                        }
                    }                         
        }
        public void OrdTri7()
        {
            int i;
            for (int fp = f - 1; fp >= 1; fp--)           
                for (int cp = c; cp >= fp + 1; cp--)               
                    for (int fd = fp; fd >= 1; fd--)
                    {
                        if (fd == fp)
                            i = cp;
                        else
                            i = c;
                        for (int cd = i; cd >= fd + 1; cd--)
                            if (m[fd, cd] < m[fp, cp])
                                this.Intercambiar(fd, cd, fp, cp);
                    }                           
        }


        public void examen2023()
        {
            int co;
            for (int i = 2; i <= this.f; i++)
            {
                for (int j = this.c - i + 2; j <= this.c; j++)
                {
                    for (int ii = i; ii <= this.f; ii++)
                    {
                        co = (ii == i) ? (j) : (this.c - ii + 2);
                        for (int jj = co; jj <= this.c; jj++)
                        {
                            if (this.m[i, j] > this.m[ii, jj])
                                this.Intercambiar(i, j, ii, jj);
                        }
                    }
                }
            }
        }

        public void Examen20232()
        {
            int i;
            for (int c1 = 2; c1 <= c; c1++)
            {                         
                for (int f1 = f - c1 + 2; f1 <= f; f1++)
                {
                    for (int c2 = c1; c2 <= c; c2++)
                    {
                        i = (c1 == c2) ? (f1) : (this.f - c2 + 2);
                        for (int f2 = i; f2 <= f; f2++)
                        {                         
                                if (m[f1, c1] < m[f2, c2])
                                {
                                    this.Intercambiar(f1, c1, f2, c2);
                                }                           
                            }

                        }

                  }

              }
         }
    }
}
