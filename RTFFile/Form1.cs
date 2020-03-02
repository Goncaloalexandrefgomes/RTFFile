using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RTFFile texto = new RTFFile();

        private void Abrir_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Abrir;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Eliminar();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            texto.Guardar(richTextBox1.Text);
        }

        private void Minusculas_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Minusculas(richTextBox1.Text);
        }

        private void Maiusculas_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Maiusculas(richTextBox1.Text);
        }

        private void Iniciais_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Iniciais(richTextBox1.Text);
        }
    }
}
