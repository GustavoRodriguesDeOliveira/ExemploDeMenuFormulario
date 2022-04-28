
namespace ExemploDeMenu
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(410, 118);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(151, 57);
            this.consultar.TabIndex = 1;
            this.consultar.Text = "button2";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Location = new System.Drawing.Point(407, 202);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(153, 35);
            this.atualizar.TabIndex = 2;
            this.atualizar.Text = "button3";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(403, 255);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(156, 36);
            this.excluir.TabIndex = 3;
            this.excluir.Text = "button4";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(410, 62);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(150, 36);
            this.cadastrar.TabIndex = 4;
            this.cadastrar.Text = "button1";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button cadastrar;
    }
}

