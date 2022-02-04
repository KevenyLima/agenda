namespace agenda
{
    partial class pesquisarcontato
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.campo_de_pesquisa = new System.Windows.Forms.TextBox();
            this.cmd_procurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termo de pesquisa";
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(93, 51);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // campo_de_pesquisa
            // 
            this.campo_de_pesquisa.Location = new System.Drawing.Point(12, 25);
            this.campo_de_pesquisa.MaxLength = 30;
            this.campo_de_pesquisa.Name = "campo_de_pesquisa";
            this.campo_de_pesquisa.Size = new System.Drawing.Size(156, 20);
            this.campo_de_pesquisa.TabIndex = 1;
            this.campo_de_pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campo_de_pesquisa_KeyDown);
            // 
            // cmd_procurar
            // 
            this.cmd_procurar.Location = new System.Drawing.Point(12, 51);
            this.cmd_procurar.Name = "cmd_procurar";
            this.cmd_procurar.Size = new System.Drawing.Size(75, 23);
            this.cmd_procurar.TabIndex = 2;
            this.cmd_procurar.Text = "Pesquisar";
            this.cmd_procurar.UseVisualStyleBackColor = true;
            this.cmd_procurar.Click += new System.EventHandler(this.cmd_procurar_Click);
       
            // 
            // pesquisarcontato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 86);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_procurar);
            this.Controls.Add(this.campo_de_pesquisa);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pesquisarcontato";
            this.Text = "pesquisar_contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.TextBox campo_de_pesquisa;
        private System.Windows.Forms.Button cmd_procurar;
    }
}