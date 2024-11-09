namespace Trabalho_AED2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip barraDeMenu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dicionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirDicionarioToolStripMenuItem; 
        private System.Windows.Forms.ToolStripMenuItem verificarPalavraToolStripMenuItem; 

        private System.Windows.Forms.TextBox caixaDeTexto;
        

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se recursos gerenciados devem ser descartados; caso contrário, false.</param>
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
            this.barraDeMenu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dicionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirDicionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarPalavraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaDeTexto = new System.Windows.Forms.TextBox();
            this.barraDeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraDeMenu
            // 
            this.barraDeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.dicionarioToolStripMenuItem});
            this.barraDeMenu.Location = new System.Drawing.Point(0, 0);
            this.barraDeMenu.Name = "barraDeMenu";
            this.barraDeMenu.Size = new System.Drawing.Size(800, 24);
            this.barraDeMenu.TabIndex = 0;
            this.barraDeMenu.Text = "barraDeMenu";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            //
            // dicionario
            //
            this.dicionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            abrirDicionarioToolStripMenuItem, verificarPalavraToolStripMenuItem});

            this.dicionarioToolStripMenuItem.Name = "dicionarioToolStripMenuItem";
            this.dicionarioToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.dicionarioToolStripMenuItem.Text = "Dicionário";
            //
            // abrirDicionario
            // 
            this.abrirDicionarioToolStripMenuItem.Name = " abrirDicionarioToolStripMenuItem";
            this.abrirDicionarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirDicionarioToolStripMenuItem.Text = "Abrir Dicionário";
            this.abrirDicionarioToolStripMenuItem.Click += new System.EventHandler(this.abrirDicionarioToolStripMenuItem_Click);
            //
            // verificarPalavra
            //
            this.verificarPalavraToolStripMenuItem.Name = " abrirDicionarioToolStripMenuItem";
            this.verificarPalavraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verificarPalavraToolStripMenuItem.Text = "Verificar Palavra";
            this.verificarPalavraToolStripMenuItem.Click += new System.EventHandler(this.verificarPalavraToolStripMenuItem_Click);
            // 
            // caixaDeTexto
            // 
            this.caixaDeTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caixaDeTexto.Location = new System.Drawing.Point(0, 24);
            this.caixaDeTexto.Multiline = true;
            this.caixaDeTexto.Name = "caixaDeTexto";
            this.caixaDeTexto.Size = new System.Drawing.Size(800, 426);
            this.caixaDeTexto.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caixaDeTexto);
            this.Controls.Add(this.barraDeMenu);
            this.MainMenuStrip = this.barraDeMenu;
            this.Name = "Form1";
            this.Text = "Editor de Texto";
            this.barraDeMenu.ResumeLayout(false);
            this.barraDeMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}