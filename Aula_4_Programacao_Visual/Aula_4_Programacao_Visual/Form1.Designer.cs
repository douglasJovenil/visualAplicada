namespace Aula_4_Programacao_Visual
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_close = new System.Windows.Forms.Button();
            this.textbox_result = new System.Windows.Forms.TextBox();
            this.textbox_operator_1 = new System.Windows.Forms.TextBox();
            this.textbox_operator_2 = new System.Windows.Forms.TextBox();
            this.label_plus = new System.Windows.Forms.Label();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.menuStripItem_operations = new System.Windows.Forms.ToolStripMenuItem();
            this.somarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(227, 76);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Fechar";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_result
            // 
            this.textbox_result.Location = new System.Drawing.Point(368, 27);
            this.textbox_result.Name = "textbox_result";
            this.textbox_result.Size = new System.Drawing.Size(100, 20);
            this.textbox_result.TabIndex = 1;
            // 
            // textbox_operator_1
            // 
            this.textbox_operator_1.Location = new System.Drawing.Point(6, 27);
            this.textbox_operator_1.Name = "textbox_operator_1";
            this.textbox_operator_1.Size = new System.Drawing.Size(100, 20);
            this.textbox_operator_1.TabIndex = 2;
            this.textbox_operator_1.TextChanged += new System.EventHandler(this.operator_1_TextChanged);
            // 
            // textbox_operator_2
            // 
            this.textbox_operator_2.Location = new System.Drawing.Point(179, 27);
            this.textbox_operator_2.Name = "textbox_operator_2";
            this.textbox_operator_2.Size = new System.Drawing.Size(100, 20);
            this.textbox_operator_2.TabIndex = 3;
            this.textbox_operator_2.TextChanged += new System.EventHandler(this.textbox_operator_2_TextChanged);
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Location = new System.Drawing.Point(136, 31);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(13, 13);
            this.label_plus.TabIndex = 4;
            this.label_plus.Text = "+";
            this.label_plus.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(309, 26);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(29, 23);
            this.button_equal.TabIndex = 5;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(146, 76);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "limpar";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // menuStripItem_operations
            // 
            this.menuStripItem_operations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somarToolStripMenuItem1,
            this.limparToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStripItem_operations.Name = "menuStripItem_operations";
            this.menuStripItem_operations.Size = new System.Drawing.Size(75, 20);
            this.menuStripItem_operations.Text = "Operações";
            this.menuStripItem_operations.Click += new System.EventHandler(this.somarToolStripMenuItem_Click);
            // 
            // somarToolStripMenuItem1
            // 
            this.somarToolStripMenuItem1.Name = "somarToolStripMenuItem1";
            this.somarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.somarToolStripMenuItem1.Text = "Somar";
            this.somarToolStripMenuItem1.Click += new System.EventHandler(this.somarToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItem_operations});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(485, 24);
            this.menuStrip_main.TabIndex = 7;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 132);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.label_plus);
            this.Controls.Add(this.textbox_operator_2);
            this.Controls.Add(this.textbox_operator_1);
            this.Controls.Add(this.textbox_result);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.menuStrip_main);
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textbox_result;
        private System.Windows.Forms.TextBox textbox_operator_1;
        private System.Windows.Forms.TextBox textbox_operator_2;
        private System.Windows.Forms.Label label_plus;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem_operations;
        private System.Windows.Forms.ToolStripMenuItem somarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
    }
}

