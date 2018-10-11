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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainPanelLeft = new System.Windows.Forms.Panel();
            this.MainButtonNota = new System.Windows.Forms.Button();
            this.MainButtonNome = new System.Windows.Forms.Button();
            this.MainChartAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainButtonColumn = new System.Windows.Forms.Button();
            this.MainButtonFastline = new System.Windows.Forms.Button();
            this.MainButtonFunnel = new System.Windows.Forms.Button();
            this.MainButtonPolar = new System.Windows.Forms.Button();
            this.MainButtonBoxPlot = new System.Windows.Forms.Button();
            this.MainButtonSair = new System.Windows.Forms.Button();
            this.MainPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChartAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelLeft
            // 
            this.MainPanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelLeft.Controls.Add(this.MainButtonSair);
            this.MainPanelLeft.Controls.Add(this.MainButtonBoxPlot);
            this.MainPanelLeft.Controls.Add(this.MainButtonPolar);
            this.MainPanelLeft.Controls.Add(this.MainButtonFunnel);
            this.MainPanelLeft.Controls.Add(this.MainButtonFastline);
            this.MainPanelLeft.Controls.Add(this.MainButtonColumn);
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
            this.MainButtonNota.Location = new System.Drawing.Point(0, 60);
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
            this.MainButtonNome.Location = new System.Drawing.Point(0, 3);
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
            chartArea1.Name = "ChartArea1";
            this.MainChartAlunos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChartAlunos.Legends.Add(legend1);
            this.MainChartAlunos.Location = new System.Drawing.Point(269, 52);
            this.MainChartAlunos.Name = "MainChartAlunos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MainChartAlunos.Series.Add(series1);
            this.MainChartAlunos.Size = new System.Drawing.Size(466, 329);
            this.MainChartAlunos.TabIndex = 1;
            this.MainChartAlunos.Text = "MainChartAlunos";
            // 
            // MainButtonColumn
            // 
            this.MainButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonColumn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonColumn.ForeColor = System.Drawing.Color.White;
            this.MainButtonColumn.Location = new System.Drawing.Point(0, 174);
            this.MainButtonColumn.Name = "MainButtonColumn";
            this.MainButtonColumn.Size = new System.Drawing.Size(200, 43);
            this.MainButtonColumn.TabIndex = 2;
            this.MainButtonColumn.Text = "Column";
            this.MainButtonColumn.UseVisualStyleBackColor = true;
            // 
            // MainButtonFastline
            // 
            this.MainButtonFastline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonFastline.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonFastline.ForeColor = System.Drawing.Color.White;
            this.MainButtonFastline.Location = new System.Drawing.Point(0, 231);
            this.MainButtonFastline.Name = "MainButtonFastline";
            this.MainButtonFastline.Size = new System.Drawing.Size(200, 43);
            this.MainButtonFastline.TabIndex = 3;
            this.MainButtonFastline.Text = "FastLine";
            this.MainButtonFastline.UseVisualStyleBackColor = true;
            // 
            // MainButtonFunnel
            // 
            this.MainButtonFunnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonFunnel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonFunnel.ForeColor = System.Drawing.Color.White;
            this.MainButtonFunnel.Location = new System.Drawing.Point(0, 288);
            this.MainButtonFunnel.Name = "MainButtonFunnel";
            this.MainButtonFunnel.Size = new System.Drawing.Size(200, 43);
            this.MainButtonFunnel.TabIndex = 4;
            this.MainButtonFunnel.Text = "Funnel";
            this.MainButtonFunnel.UseVisualStyleBackColor = true;
            // 
            // MainButtonPolar
            // 
            this.MainButtonPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonPolar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonPolar.ForeColor = System.Drawing.Color.White;
            this.MainButtonPolar.Location = new System.Drawing.Point(0, 345);
            this.MainButtonPolar.Name = "MainButtonPolar";
            this.MainButtonPolar.Size = new System.Drawing.Size(200, 43);
            this.MainButtonPolar.TabIndex = 5;
            this.MainButtonPolar.Text = "Polar";
            this.MainButtonPolar.UseVisualStyleBackColor = true;
            // 
            // MainButtonBoxPlot
            // 
            this.MainButtonBoxPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonBoxPlot.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonBoxPlot.ForeColor = System.Drawing.Color.White;
            this.MainButtonBoxPlot.Location = new System.Drawing.Point(0, 117);
            this.MainButtonBoxPlot.Name = "MainButtonBoxPlot";
            this.MainButtonBoxPlot.Size = new System.Drawing.Size(200, 43);
            this.MainButtonBoxPlot.TabIndex = 6;
            this.MainButtonBoxPlot.Text = "BoxPlot";
            this.MainButtonBoxPlot.UseVisualStyleBackColor = true;
            this.MainButtonBoxPlot.Click += new System.EventHandler(this.MainButtonBoxPlot_Click);
            // 
            // MainButtonSair
            // 
            this.MainButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonSair.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonSair.ForeColor = System.Drawing.Color.White;
            this.MainButtonSair.Location = new System.Drawing.Point(0, 402);
            this.MainButtonSair.Name = "MainButtonSair";
            this.MainButtonSair.Size = new System.Drawing.Size(200, 43);
            this.MainButtonSair.TabIndex = 7;
            this.MainButtonSair.Text = "Sair";
            this.MainButtonSair.UseVisualStyleBackColor = true;
            this.MainButtonSair.Click += new System.EventHandler(this.MainButtonSair_Click);
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
        private System.Windows.Forms.Button MainButtonBoxPlot;
        private System.Windows.Forms.Button MainButtonPolar;
        private System.Windows.Forms.Button MainButtonFunnel;
        private System.Windows.Forms.Button MainButtonFastline;
        private System.Windows.Forms.Button MainButtonColumn;
        private System.Windows.Forms.Button MainButtonSair;
    }
}

