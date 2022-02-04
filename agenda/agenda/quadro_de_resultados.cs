using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace agenda
{
    public partial class quadro_de_resultados : Form
    {
        string texto;
        public quadro_de_resultados(string texto)
        {
            InitializeComponent();
            this.texto = texto.ToUpper();
        }

        private void fechamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quadro_de_resultados_Load(object sender, EventArgs e)
        {
            Executa_pesquisa();
        }

        private void Executa_pesquisa()
        {
            List<cl_contactos> lista_Contactos = new List<cl_contactos>();

            foreach (cl_contactos Contactos in classgeral.LISTA_DE_CONTACTOS)
            {
                if (Contactos.nome.ToUpper().Contains(texto) || Contactos.numero.ToUpper().Contains(texto))
                {
                    lista_Contactos.Add(Contactos);
                }

            }
            lista_final.Items.Clear();
            foreach (cl_contactos resultado in lista_Contactos)
            {
                lista_final.Items.Add(resultado.nome + "(" + resultado.numero + ")");
            }
            registros.Text = "Registros:" + lista_final.Items.Count;
        }

        private void novapesquisa_Click(object sender, EventArgs e)
        {
            pesquisarcontato pesquisarcontato = new pesquisarcontato();
            pesquisarcontato.ShowDialog();
            if (pesquisarcontato.cancelar) return;
            texto = pesquisarcontato.texto.ToUpper();
            Executa_pesquisa();
        }
    }
}
