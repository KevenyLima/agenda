using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent( );
            label2.Text = classgeral.versao;
            classgeral.costrutor_DE_lista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja mesmo sair?","SAIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gravador_Editor formulario = new Gravador_Editor();
            formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisarcontato f = new pesquisarcontato();
            f.ShowDialog();
            if (f.cancelar == true) return;
            quadro_de_resultados ff = new quadro_de_resultados(f.texto);
            ff.ShowDialog();
        }
    }
}
