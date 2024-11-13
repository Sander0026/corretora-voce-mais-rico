namespace Corretora_Voce_Mais_Rico
{
    partial class AreaCorretora
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.investimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoInvestimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.investimentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Clientes";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            // 
            // investimentosToolStripMenuItem
            // 
            this.investimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoInvestimentoToolStripMenuItem,
            this.listarProdutosToolStripMenuItem});
            this.investimentosToolStripMenuItem.Name = "investimentosToolStripMenuItem";
            this.investimentosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.investimentosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarNovoInvestimentoToolStripMenuItem
            // 
            this.cadastrarNovoInvestimentoToolStripMenuItem.Name = "cadastrarNovoInvestimentoToolStripMenuItem";
            this.cadastrarNovoInvestimentoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastrarNovoInvestimentoToolStripMenuItem.Text = "Cadastrar Novo Produto";
            // 
            // listarProdutosToolStripMenuItem
            // 
            this.listarProdutosToolStripMenuItem.Name = "listarProdutosToolStripMenuItem";
            this.listarProdutosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listarProdutosToolStripMenuItem.Text = "Listar Produtos";
            // 
            // AreaCorretora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AreaCorretora";
            this.Text = "Área da Corretora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem investimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoInvestimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
    }
}

