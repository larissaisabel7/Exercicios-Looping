
namespace Exercícios_Looping
{
    partial class frmprincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProgramasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício11ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exercício11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.exercício13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramasToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProgramasToolStripMenuItem1
            // 
            this.ProgramasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício11ToolStripMenuItem1,
            this.exercício12ToolStripMenuItem,
            this.exercício13ToolStripMenuItem});
            this.ProgramasToolStripMenuItem1.Name = "ProgramasToolStripMenuItem1";
            this.ProgramasToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.ProgramasToolStripMenuItem1.Text = "Programas";
            this.ProgramasToolStripMenuItem1.Click += new System.EventHandler(this.exercício11ToolStripMenuItem1_Click);
            // 
            // exercício11ToolStripMenuItem1
            // 
            this.exercício11ToolStripMenuItem1.Name = "exercício11ToolStripMenuItem1";
            this.exercício11ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exercício11ToolStripMenuItem1.Text = "Exercício 11";
            this.exercício11ToolStripMenuItem1.Click += new System.EventHandler(this.exercício11ToolStripMenuItem1_Click_1);
            // 
            // exercício12ToolStripMenuItem
            // 
            this.exercício12ToolStripMenuItem.Name = "exercício12ToolStripMenuItem";
            this.exercício12ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício12ToolStripMenuItem.Text = "Exercício 12";
            this.exercício12ToolStripMenuItem.Click += new System.EventHandler(this.exercício12ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício11ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // exercício11ToolStripMenuItem
            // 
            this.exercício11ToolStripMenuItem.Name = "exercício11ToolStripMenuItem";
            this.exercício11ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exercício11ToolStripMenuItem.Text = "Exercício 11";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // exercício13ToolStripMenuItem
            // 
            this.exercício13ToolStripMenuItem.Name = "exercício13ToolStripMenuItem";
            this.exercício13ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício13ToolStripMenuItem.Text = "Exercício 13";
            this.exercício13ToolStripMenuItem.Click += new System.EventHandler(this.exercício13ToolStripMenuItem_Click_1);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exercícios_Looping.Properties.Resources.corinthians;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercícios Looping";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProgramasToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercício11ToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem exercício11ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exercício12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício13ToolStripMenuItem;
    }
}

