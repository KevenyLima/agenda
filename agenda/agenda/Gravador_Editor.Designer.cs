namespace agenda
{
    partial class Gravador_Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.lista_de_registros = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numero_de_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(346, 318);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(92, 32);
            this.cmd_fechar.TabIndex = 4;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(65, 6);
            this.text_nome.MaxLength = 100;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(264, 20);
            this.text_nome.TabIndex = 0;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(65, 32);
            this.text_numero.MaxLength = 12;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(98, 20);
            this.text_numero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(65, 58);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(75, 23);
            this.cmd_gravar.TabIndex = 2;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // lista_de_registros
            // 
            this.lista_de_registros.FormattingEnabled = true;
            this.lista_de_registros.Location = new System.Drawing.Point(6, 101);
            this.lista_de_registros.Name = "lista_de_registros";
            this.lista_de_registros.Size = new System.Drawing.Size(432, 212);
            this.lista_de_registros.TabIndex = 3;
            this.lista_de_registros.SelectedIndexChanged += new System.EventHandler(this.lista_de_registros_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de contactos registrados";
            // 
            // numero_de_registros
            // 
            this.numero_de_registros.AutoSize = true;
            this.numero_de_registros.Location = new System.Drawing.Point(12, 318);
            this.numero_de_registros.Name = "numero_de_registros";
            this.numero_de_registros.Size = new System.Drawing.Size(63, 13);
            this.numero_de_registros.TabIndex = 10;
            this.numero_de_registros.Text = "Registros: 0";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(248, 319);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(92, 31);
            this.cmd_apagar.TabIndex = 5;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.AutoSize = true;
            this.cmd_editar.Location = new System.Drawing.Point(150, 320);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(92, 30);
            this.cmd_editar.TabIndex = 6;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // Gravador_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(441, 357);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.numero_de_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_de_registros);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_fechar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gravador_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gravador\\Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox lista_de_registros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numero_de_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
    }
}