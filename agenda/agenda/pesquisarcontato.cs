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
    public partial class pesquisarcontato : Form
    {
        public bool cancelar { get; set; }
        public string texto { get; set; }
        public pesquisarcontato()
        {
            InitializeComponent();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
            this.Close();
        }

        private void cmd_procurar_Click(object sender, EventArgs e)
        {
            if (campo_de_pesquisa.Text == "") return;
            texto = campo_de_pesquisa.Text;
            cancelar = false;
            this.Close();
        }

        private void campo_de_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                cmd_procurar_Click(cmd_procurar, EventArgs.Empty);
            }
        }
    }
}
