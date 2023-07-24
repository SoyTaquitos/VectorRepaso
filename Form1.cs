using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorRepaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Entero n1;
        Vector v1;
        Matriz m1;        
        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
            v1 = new Vector();
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m1.CargarM(int.Parse(textBox1.Text), int.Parse(textBox6.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox4.Text = m1.DescargarM();
        }

        private void ordenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdenamientoDeMatriz();
            textBox5.Text = m1.DescargarM();
        }

        private void ordenSenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdenSen();
            textBox5.Text = m1.DescargarM();
        }

        private void ordenSeno2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdenSen2();
            textBox5.Text = m1.DescargarM();
        }

        private void ordTri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdTri1();
            textBox5.Text = m1.DescargarM();
        }

        private void ordTri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdTri2();
            textBox5.Text = m1.DescargarM();
        }

        private void ordTri3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdTri3();
            textBox5.Text = m1.DescargarM();
        }

        private void ordTri4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdTri4();
            textBox5.Text = m1.DescargarM();
        }

        private void ordTri5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdTri5();
            textBox5.Text = m1.DescargarM();
        }

        private void ordTri6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdTri6();
            textBox5.Text = m1.DescargarM();
        }

        private void ordTri7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdTri7();
            textBox5.Text = m1.DescargarM();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarV(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.DescargarV();
        }

        private void interToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Intercalar2men2may (int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.DescargarV();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Burbuja();
            textBox5.Text = v1.DescargarV();
        }

        private void examEj2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Examen20232();
            textBox5.Text = m1.DescargarM();
        }
    }
}
