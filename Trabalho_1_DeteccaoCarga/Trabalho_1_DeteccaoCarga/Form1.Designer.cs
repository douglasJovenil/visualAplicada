namespace Trabalho_1_DeteccaoCarga
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
            this.menuStrip_Arquivo = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_pathFile = new System.Windows.Forms.TextBox();
            this.button_changeFileName = new System.Windows.Forms.Button();
            this.menuStrip_Arquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Arquivo
            // 
            this.menuStrip_Arquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.processarToolStripMenuItem});
            this.menuStrip_Arquivo.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Arquivo.Name = "menuStrip_Arquivo";
            this.menuStrip_Arquivo.Size = new System.Drawing.Size(460, 24);
            this.menuStrip_Arquivo.TabIndex = 0;
            this.menuStrip_Arquivo.Text = "Arquivo";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // carregarToolStripMenuItem
            // 
            this.carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            this.carregarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.carregarToolStripMenuItem.Text = "Carregar";
            this.carregarToolStripMenuItem.Click += new System.EventHandler(this.carregarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // processarToolStripMenuItem
            // 
            this.processarToolStripMenuItem.Name = "processarToolStripMenuItem";
            this.processarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.processarToolStripMenuItem.Text = "Processar";
            // 
            // textBox_pathFile
            // 
            this.textBox_pathFile.Location = new System.Drawing.Point(12, 77);
            this.textBox_pathFile.Name = "textBox_pathFile";
            this.textBox_pathFile.Size = new System.Drawing.Size(436, 20);
            this.textBox_pathFile.TabIndex = 1;
            this.textBox_pathFile.TextChanged += new System.EventHandler(this.textBox_pathFile_TextChanged);
            // 
            // button_changeFileName
            // 
            this.button_changeFileName.Location = new System.Drawing.Point(180, 103);
            this.button_changeFileName.Name = "button_changeFileName";
            this.button_changeFileName.Size = new System.Drawing.Size(100, 23);
            this.button_changeFileName.TabIndex = 2;
            this.button_changeFileName.Text = "Trocar caminho";
            this.button_changeFileName.UseVisualStyleBackColor = true;
            this.button_changeFileName.Click += new System.EventHandler(this.button_changeFileName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 179);
            this.Controls.Add(this.button_changeFileName);
            this.Controls.Add(this.textBox_pathFile);
            this.Controls.Add(this.menuStrip_Arquivo);
            this.MainMenuStrip = this.menuStrip_Arquivo;
            this.Name = "Form1";
            this.Text = "Sensor de Carga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip_Arquivo.ResumeLayout(false);
            this.menuStrip_Arquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_pathFile;
        private System.Windows.Forms.Button button_changeFileName;
    }
}

