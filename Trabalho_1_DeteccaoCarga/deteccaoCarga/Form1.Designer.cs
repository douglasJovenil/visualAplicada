namespace deteccaoCarga
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanelTop = new System.Windows.Forms.Panel();
            this.MainLabelProgramName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainButtonSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainLabelSair = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainLabelProcessar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainLabelAbrir = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainButtonProcessar = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainButtonAbrir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.MainButtonIndicator = new System.Windows.Forms.Panel();
            this.MainStatusBar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.MainMinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainExpandCompressButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MainPanelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonProcessar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonAbrir)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainExpandCompressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelTop
            // 
            this.MainPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainPanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelTop.Controls.Add(this.MainLabelProgramName);
            this.MainPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanelTop.Location = new System.Drawing.Point(0, 0);
            this.MainPanelTop.Name = "MainPanelTop";
            this.MainPanelTop.Size = new System.Drawing.Size(650, 30);
            this.MainPanelTop.TabIndex = 0;
            this.MainPanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseDown);
            this.MainPanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseMove);
            this.MainPanelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseUp);
            // 
            // MainLabelProgramName
            // 
            this.MainLabelProgramName.AutoSize = true;
            this.MainLabelProgramName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelProgramName.ForeColor = System.Drawing.Color.White;
            this.MainLabelProgramName.Location = new System.Drawing.Point(34, 8);
            this.MainLabelProgramName.Name = "MainLabelProgramName";
            this.MainLabelProgramName.Size = new System.Drawing.Size(115, 17);
            this.MainLabelProgramName.TabIndex = 3;
            this.MainLabelProgramName.Text = "Sensor de Carga";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.MainButtonSair);
            this.panel3.Controls.Add(this.MainLabelSair);
            this.panel3.Controls.Add(this.MainLabelProcessar);
            this.panel3.Controls.Add(this.MainLabelAbrir);
            this.panel3.Controls.Add(this.MainButtonProcessar);
            this.panel3.Controls.Add(this.MainButtonAbrir);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.bunifuSeparator3);
            this.panel3.Controls.Add(this.bunifuSeparator2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 312);
            this.panel3.TabIndex = 2;
            // 
            // MainButtonSair
            // 
            this.MainButtonSair.BackColor = System.Drawing.Color.Transparent;
            this.MainButtonSair.Image = global::deteccaoCarga.Properties.Resources.exitProgram;
            this.MainButtonSair.ImageActive = null;
            this.MainButtonSair.InitialImage = null;
            this.MainButtonSair.Location = new System.Drawing.Point(14, 244);
            this.MainButtonSair.Name = "MainButtonSair";
            this.MainButtonSair.Size = new System.Drawing.Size(32, 64);
            this.MainButtonSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainButtonSair.TabIndex = 13;
            this.MainButtonSair.TabStop = false;
            this.MainButtonSair.Zoom = 0;
            this.MainButtonSair.Click += new System.EventHandler(this.MainButtonSair_Click);
            // 
            // MainLabelSair
            // 
            this.MainLabelSair.AutoSize = true;
            this.MainLabelSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelSair.ForeColor = System.Drawing.Color.White;
            this.MainLabelSair.Location = new System.Drawing.Point(53, 268);
            this.MainLabelSair.Name = "MainLabelSair";
            this.MainLabelSair.Size = new System.Drawing.Size(30, 17);
            this.MainLabelSair.TabIndex = 10;
            this.MainLabelSair.Text = "Sair";
            // 
            // MainLabelProcessar
            // 
            this.MainLabelProcessar.AutoSize = true;
            this.MainLabelProcessar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelProcessar.ForeColor = System.Drawing.Color.White;
            this.MainLabelProcessar.Location = new System.Drawing.Point(53, 197);
            this.MainLabelProcessar.Name = "MainLabelProcessar";
            this.MainLabelProcessar.Size = new System.Drawing.Size(68, 17);
            this.MainLabelProcessar.TabIndex = 9;
            this.MainLabelProcessar.Text = "Processar";
            // 
            // MainLabelAbrir
            // 
            this.MainLabelAbrir.AutoSize = true;
            this.MainLabelAbrir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelAbrir.ForeColor = System.Drawing.Color.White;
            this.MainLabelAbrir.Location = new System.Drawing.Point(53, 126);
            this.MainLabelAbrir.Name = "MainLabelAbrir";
            this.MainLabelAbrir.Size = new System.Drawing.Size(37, 17);
            this.MainLabelAbrir.TabIndex = 8;
            this.MainLabelAbrir.Text = "Abrir";
            // 
            // MainButtonProcessar
            // 
            this.MainButtonProcessar.BackColor = System.Drawing.Color.Transparent;
            this.MainButtonProcessar.Image = global::deteccaoCarga.Properties.Resources.processFile;
            this.MainButtonProcessar.ImageActive = null;
            this.MainButtonProcessar.InitialImage = null;
            this.MainButtonProcessar.Location = new System.Drawing.Point(14, 173);
            this.MainButtonProcessar.Name = "MainButtonProcessar";
            this.MainButtonProcessar.Size = new System.Drawing.Size(33, 64);
            this.MainButtonProcessar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainButtonProcessar.TabIndex = 5;
            this.MainButtonProcessar.TabStop = false;
            this.MainButtonProcessar.Zoom = 0;
            this.MainButtonProcessar.Click += new System.EventHandler(this.MainButtonProcessar_Click);
            // 
            // MainButtonAbrir
            // 
            this.MainButtonAbrir.BackColor = System.Drawing.Color.Transparent;
            this.MainButtonAbrir.ErrorImage = null;
            this.MainButtonAbrir.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonAbrir.Image")));
            this.MainButtonAbrir.ImageActive = null;
            this.MainButtonAbrir.InitialImage = null;
            this.MainButtonAbrir.Location = new System.Drawing.Point(10, 99);
            this.MainButtonAbrir.Name = "MainButtonAbrir";
            this.MainButtonAbrir.Size = new System.Drawing.Size(40, 70);
            this.MainButtonAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainButtonAbrir.TabIndex = 4;
            this.MainButtonAbrir.TabStop = false;
            this.MainButtonAbrir.Zoom = 0;
            this.MainButtonAbrir.Click += new System.EventHandler(this.MainButtonAbrir_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 81);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(164, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(4, 223);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(164, 35);
            this.bunifuSeparator3.TabIndex = 12;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(4, 152);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(164, 35);
            this.bunifuSeparator2.TabIndex = 11;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // MainButtonIndicator
            // 
            this.MainButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.MainButtonIndicator.Location = new System.Drawing.Point(128, 132);
            this.MainButtonIndicator.Name = "MainButtonIndicator";
            this.MainButtonIndicator.Size = new System.Drawing.Size(15, 64);
            this.MainButtonIndicator.TabIndex = 5;
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.AutoSize = true;
            this.MainStatusBar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusBar.ForeColor = System.Drawing.Color.White;
            this.MainStatusBar.Location = new System.Drawing.Point(13, 7);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(192, 16);
            this.MainStatusBar.TabIndex = 0;
            this.MainStatusBar.Text = "Aguardando carregar o arquivo...";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.BackColor = System.Drawing.Color.White;
            this.MainProgressBar.BorderRadius = 5;
            this.MainProgressBar.Location = new System.Drawing.Point(221, 11);
            this.MainProgressBar.MaximumValue = 100;
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.MainProgressBar.Size = new System.Drawing.Size(417, 10);
            this.MainProgressBar.TabIndex = 1;
            this.MainProgressBar.Value = 0;
            this.MainProgressBar.Visible = false;
            this.MainProgressBar.progressChanged += new System.EventHandler(this.MainProgressBar_progressChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.MainProgressBar);
            this.panel2.Controls.Add(this.MainStatusBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 30);
            this.panel2.TabIndex = 1;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(143, 34);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(10, 308);
            this.bunifuSeparator5.TabIndex = 4;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(0, 28);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(650, 10);
            this.bunifuSeparator4.TabIndex = 3;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // MainMinimizeButton
            // 
            this.MainMinimizeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainMinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainMinimizeButton.Image = global::deteccaoCarga.Properties.Resources.minimizeWindow1;
            this.MainMinimizeButton.ImageActive = null;
            this.MainMinimizeButton.InitialImage = null;
            this.MainMinimizeButton.Location = new System.Drawing.Point(558, 1);
            this.MainMinimizeButton.Name = "MainMinimizeButton";
            this.MainMinimizeButton.Size = new System.Drawing.Size(31, 31);
            this.MainMinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainMinimizeButton.TabIndex = 9;
            this.MainMinimizeButton.TabStop = false;
            this.MainMinimizeButton.Zoom = 0;
            this.MainMinimizeButton.Click += new System.EventHandler(this.MainMinimizeButton_Click);
            // 
            // MainExpandCompressButton
            // 
            this.MainExpandCompressButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainExpandCompressButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainExpandCompressButton.Enabled = false;
            this.MainExpandCompressButton.Image = global::deteccaoCarga.Properties.Resources.expandWindow;
            this.MainExpandCompressButton.ImageActive = null;
            this.MainExpandCompressButton.InitialImage = null;
            this.MainExpandCompressButton.Location = new System.Drawing.Point(588, 1);
            this.MainExpandCompressButton.Name = "MainExpandCompressButton";
            this.MainExpandCompressButton.Size = new System.Drawing.Size(31, 31);
            this.MainExpandCompressButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainExpandCompressButton.TabIndex = 8;
            this.MainExpandCompressButton.TabStop = false;
            this.MainExpandCompressButton.Zoom = 0;
            this.MainExpandCompressButton.Click += new System.EventHandler(this.MainExpandCompressButton_Click);
            // 
            // MainButtonExit
            // 
            this.MainButtonExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainButtonExit.Image = global::deteccaoCarga.Properties.Resources.closeWindow1;
            this.MainButtonExit.ImageActive = null;
            this.MainButtonExit.InitialImage = null;
            this.MainButtonExit.Location = new System.Drawing.Point(619, 1);
            this.MainButtonExit.Name = "MainButtonExit";
            this.MainButtonExit.Size = new System.Drawing.Size(31, 31);
            this.MainButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainButtonExit.TabIndex = 4;
            this.MainButtonExit.TabStop = false;
            this.MainButtonExit.Zoom = 0;
            this.MainButtonExit.Click += new System.EventHandler(this.MainButtonExit_Click);
            this.MainButtonExit.MouseLeave += new System.EventHandler(this.MainButtonExit_MouseLeave);
            this.MainButtonExit.MouseHover += new System.EventHandler(this.MainButtonExit_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::deteccaoCarga.Properties.Resources.UCSLogo4;
            this.pictureBox1.Location = new System.Drawing.Point(6, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::deteccaoCarga.Properties.Resources.ico1;
            this.pictureBox2.Location = new System.Drawing.Point(7, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // MainDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainDataGrid.DoubleBuffered = true;
            this.MainDataGrid.EnableHeadersVisualStyles = false;
            this.MainDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.MainDataGrid.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.MainDataGrid.Location = new System.Drawing.Point(174, 51);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MainDataGrid.Size = new System.Drawing.Size(450, 270);
            this.MainDataGrid.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(650, 372);
            this.Controls.Add(this.MainDataGrid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainMinimizeButton);
            this.Controls.Add(this.MainExpandCompressButton);
            this.Controls.Add(this.MainButtonExit);
            this.Controls.Add(this.MainButtonIndicator);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MainPanelTop);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MainPanelTop.ResumeLayout(false);
            this.MainPanelTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonProcessar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonAbrir)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainExpandCompressButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelTop;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel MainLabelProgramName;
        private Bunifu.Framework.UI.BunifuCustomLabel MainLabelSair;
        private Bunifu.Framework.UI.BunifuCustomLabel MainLabelProcessar;
        private Bunifu.Framework.UI.BunifuCustomLabel MainLabelAbrir;
        private Bunifu.Framework.UI.BunifuImageButton MainButtonProcessar;
        private Bunifu.Framework.UI.BunifuImageButton MainButtonAbrir;
        private System.Windows.Forms.Panel MainButtonIndicator;
        private Bunifu.Framework.UI.BunifuImageButton MainButtonSair;
        private Bunifu.Framework.UI.BunifuImageButton MainButtonExit;
        private Bunifu.Framework.UI.BunifuImageButton MainExpandCompressButton;
        private Bunifu.Framework.UI.BunifuImageButton MainMinimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel MainStatusBar;
        private Bunifu.Framework.UI.BunifuProgressBar MainProgressBar;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid MainDataGrid;
    }
}

