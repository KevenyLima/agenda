namespace agenda
{
    partial class quadro_de_resultados
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
            this.lista_final = new System.Windows.Forms.ListBox();
            this.registros = new System.Windows.Forms.Label();
            this.fechamento = new System.Windows.Forms.Button();
            this.novapesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.Location = new System.Drawing.Point(12, 16);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(422, 199);
            this.lista_final.TabIndex = 0;
            // 
            // registros
            // 
            this.registros.AutoSize = true;
            this.registros.Location = new System.Drawing.Point(12, 218);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(54, 13);
            this.registros.TabIndex = 1;
            this.registros.Text = "Registros:";
            // 
            // fechamento
            // 
            this.fechamento.Location = new System.Drawing.Point(345, 221);
            this.fechamento.Name = "fechamento";
            this.fechamento.Size = new System.Drawing.Size(89, 36);
            this.fechamento.TabIndex = 2;
            this.fechamento.Text = "Fechar";
            this.fechamento.UseVisualStyleBackColor = true;
            this.fechamento.Click += new System.EventHandler(this.fechamento_Click);
            // 
            // novapesquisa
            // 
            this.novapesquisa.Location = new System.Drawing.Point(221, 221);
            this.novapesquisa.Name = "novapesquisa";
            this.novapesquisa.Size = new System.Drawing.Size(118, 36);
            this.novapesquisa.TabIndex = 3;
            this.novapesquisa.Text = "Nova Pesquisa...";
            this.novapesquisa.UseVisualStyleBackColor = true;
            this.novapesquisa.Click += new System.EventHandler(this.novapesquisa_Click);
            // 
            // quadro_de_resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(446, 260);
            this.ControlBox = false;
            this.Controls.Add(this.novapesquisa);
            this.Controls.Add(this.fechamento);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.lista_final);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "quadro_de_resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "quadro_de_resultados";
            this.Load += new System.EventHandler(this.quadro_de_resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista_final;
        private System.Windows.Forms.Label registros;
        private System.Windows.Forms.Button fechamento;
        private System.Windows.Forms.Button novapesquisa;
    }
}