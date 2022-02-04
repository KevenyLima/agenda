using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;

namespace agenda
{
    public partial class Gravador_Editor : Form
    {
        int indice;
        //=================================================
        public Gravador_Editor()
        {
            InitializeComponent();
            constroiLista();
        }
        //=================================================
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //=================================================
        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Os campos não foram preenchidos corretamente");
                return;
            }
            foreach (cl_contactos contato in classgeral.LISTA_DE_CONTACTOS)
                if (contato.nome == text_nome.Text && contato.numero == text_numero.Text)
                { 
                    MessageBox.Show("este contato já esta registrado");
                    return;
                }

            classgeral.gravador_de_contatos(text_nome.Text, text_numero.Text);
            constroiLista();
            text_nome.Text = "";
            text_numero.Text ="";
            text_nome.Focus();

        }
        //=================================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=================================================
        private void constroiLista()
        {
            lista_de_registros.Items.Clear();
            foreach(cl_contactos Contactos in classgeral.LISTA_DE_CONTACTOS)
            {
                lista_de_registros.Items.Add(Contactos.nome + "(" + Contactos.numero + ")");
            }
            numero_de_registros.Text = "Registros:"+lista_de_registros.Items.Count;
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }
        //=================================================
        private void lista_de_registros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista_de_registros.SelectedIndex == -1) return;
            indice = lista_de_registros.SelectedIndex;
            cmd_editar.Enabled = true; 
            cmd_apagar.Enabled = true;
        }
        //=================================================
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("tem certeza de que quer apagar este contato?", "confirmar ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classgeral.LISTA_DE_CONTACTOS.RemoveAt(indice);
                classgeral.atualizar_ficheiro();
                constroiLista();
            }
            else
                return;
        
        }
        //=================================================
        private void cmd_editar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection ligacao = new SqlCeConnection();
                ligacao.ConnectionString = @"Data Source= C:\C#\banco_de_dados.sdf";
                ligacao.Open();
                SqlCeCommand operario = new SqlCeCommand("UPDATE contacto SET nome= 'diego' WHERE nome ='rodrigo'", ligacao);
                operario.ExecuteNonQuery();
                ligacao.Close();
            }
            catch
            {
                MessageBox.Show("erro");
            }
        }

    }
}
