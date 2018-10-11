namespace Aula_6_ListasGraficos
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainPanelLeft = new System.Windows.Forms.Panel();
            this.MainButtonNota = new System.Windows.Forms.Button();
            this.MainButtonNome = new System.Windows.Forms.Button();
            this.MainChartAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChartAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelLeft
            // 
            this.MainPanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelLeft.Controls.Add(this.MainButtonNota);
            this.MainPanelLeft.Controls.Add(this.MainButtonNome);
            this.MainPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.MainPanelLeft.Name = "MainPanelLeft";
            this.MainPanelLeft.Size = new System.Drawing.Size(200, 450);
            this.MainPanelLeft.TabIndex = 0;
            // 
            // MainButtonNota
            // 
            this.MainButtonNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonNota.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonNota.ForeColor = System.Drawing.Color.White;
            this.MainButtonNota.Location = new System.Drawing.Point(0, 237);
            this.MainButtonNota.Name = "MainButtonNota";
            this.MainButtonNota.Size = new System.Drawing.Size(200, 43);
            this.MainButtonNota.TabIndex = 1;
            this.MainButtonNota.Text = "Nota";
            this.MainButtonNota.UseVisualStyleBackColor = true;
            this.MainButtonNota.Click += new System.EventHandler(this.MainButtonNota_Click);
            // 
            // MainButtonNome
            // 
            this.MainButtonNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonNome.ForeColor = System.Drawing.Color.White;
            this.MainButtonNome.Location = new System.Drawing.Point(0, 139);
            this.MainButtonNome.Name = "MainButtonNome";
            this.MainButtonNome.Size = new System.Drawing.Size(200, 43);
            this.MainButtonNome.TabIndex = 0;
            this.MainButtonNome.Text = "Nome";
            this.MainButtonNome.UseVisualStyleBackColor = true;
            this.MainButtonNome.Click += new System.EventHandler(this.MainButtonNome_Click);
            // 
            // MainChartAlunos
            // 
            this.MainChartAlunos.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea5.Name = "ChartArea1";
            this.MainChartAlunos.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.MainChartAlunos.Legends.Add(legend5);
            this.MainChartAlunos.Location = new System.Drawing.Point(269, 52);
            this.MainChartAlunos.Name = "MainChartAlunos";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.MainChartAlunos.Series.Add(series5);
            this.MainChartAlunos.Size = new System.Drawing.Size(466, 329);
            this.MainChartAlunos.TabIndex = 1;
            this.MainChartAlunos.Text = "MainChartAlunos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainChartAlunos);
            this.Controls.Add(this.MainPanelLeft);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico Alunos";
            this.MainPanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChartAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelLeft;
        private System.Windows.Forms.Button MainButtonNota;
        private System.Windows.Forms.Button MainButtonNome;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChartAlunos;
    }
}

