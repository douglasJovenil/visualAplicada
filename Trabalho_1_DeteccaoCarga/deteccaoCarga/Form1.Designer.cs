using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing;
using System;

namespace deteccaoCarga
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            this.MainPanelTop = new Panel();
            this.MainLabelProgramName = new BunifuCustomLabel();
            this.panel3 = new Panel();
            this.MainButtonAbrir = new BunifuImageButton();
            this.MainLabelAbrir = new BunifuCustomLabel();
            this.MainButtonSair = new BunifuImageButton();
            this.MainLabelSair = new BunifuCustomLabel();
            this.pictureBox1 = new PictureBox();
            this.MainLabelProcessar = new BunifuCustomLabel();
            this.MainButtonProcessar = new BunifuImageButton();
            this.bunifuSeparator1 = new BunifuSeparator();
            this.bunifuSeparator3 = new BunifuSeparator();
            this.bunifuSeparator2 = new BunifuSeparator();
            this.MainButtonIndicator = new Panel();
            this.MainStatusBar = new BunifuCustomLabel();
            this.MainProgressBar = new BunifuProgressBar();
            this.panel2 = new Panel();
            this.bunifuSeparator5 = new BunifuSeparator();
            this.bunifuSeparator4 = new BunifuSeparator();
            this.MainButtonMinimize = new BunifuImageButton();
            this.MainButtonExpandCompress = new BunifuImageButton();
            this.MainButtonExit = new BunifuImageButton();
            this.pictureBox2 = new PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainDataGrid = new BunifuCustomDataGrid();
            this.panel1 = new Panel();
            this.panel5 = new Panel();
            this.bunifuImageButton2 = new BunifuImageButton();
            this.bunifuImageButton1 = new BunifuImageButton();
            this.panel4 = new Panel();
            this.panel6 = new Panel();
            this.bunifuImageButton4 = new BunifuImageButton();
            this.bunifuImageButton3 = new BunifuImageButton();
            this.MainPanelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonProcessar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonExpandCompress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelTop
            // 
            this.MainPanelTop.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainPanelTop.BorderStyle = BorderStyle.FixedSingle;
            this.MainPanelTop.Controls.Add(this.MainLabelProgramName);
            this.MainPanelTop.Dock = DockStyle.Top;
            this.MainPanelTop.Location = new Point(0, 0);
            this.MainPanelTop.Name = "MainPanelTop";
            this.MainPanelTop.Size = new Size(650, 30);
            this.MainPanelTop.TabIndex = 0;
            this.MainPanelTop.MouseDown += new MouseEventHandler(this.MainPanelTop_MouseDown);
            this.MainPanelTop.MouseMove += new MouseEventHandler(this.MainPanelTop_MouseMove);
            this.MainPanelTop.MouseUp += new MouseEventHandler(this.MainPanelTop_MouseUp);
            // 
            // MainLabelProgramName
            // 
            this.MainLabelProgramName.AutoSize = true;
            this.MainLabelProgramName.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelProgramName.ForeColor = Color.White;
            this.MainLabelProgramName.Location = new Point(34, 8);
            this.MainLabelProgramName.Name = "MainLabelProgramName";
            this.MainLabelProgramName.Size = new Size(115, 17);
            this.MainLabelProgramName.TabIndex = 3;
            this.MainLabelProgramName.Text = "Sensor de Carga";
            // 
            // panel3
            // 
            this.panel3.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.MainButtonAbrir);
            this.panel3.Controls.Add(this.MainLabelAbrir);
            this.panel3.Controls.Add(this.MainButtonSair);
            this.panel3.Controls.Add(this.MainLabelSair);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.MainLabelProcessar);
            this.panel3.Controls.Add(this.MainButtonProcessar);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.bunifuSeparator3);
            this.panel3.Controls.Add(this.bunifuSeparator2);
            this.panel3.Dock = DockStyle.Left;
            this.panel3.Location = new Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(150, 312);
            this.panel3.TabIndex = 2;
            // 
            // MainButtonAbrir
            // 
            this.MainButtonAbrir.BackColor = Color.Transparent;
            this.MainButtonAbrir.ErrorImage = null;
            this.MainButtonAbrir.Image = ((Image)(resources.GetObject("MainButtonAbrir.Image")));
            this.MainButtonAbrir.ImageActive = null;
            this.MainButtonAbrir.InitialImage = null;
            this.MainButtonAbrir.Location = new Point(10, 99);
            this.MainButtonAbrir.Name = "MainButtonAbrir";
            this.MainButtonAbrir.Size = new Size(40, 70);
            this.MainButtonAbrir.SizeMode = PictureBoxSizeMode.CenterImage;
            this.MainButtonAbrir.TabIndex = 4;
            this.MainButtonAbrir.TabStop = false;
            this.MainButtonAbrir.Zoom = 0;
            this.MainButtonAbrir.Click += new EventHandler(this.MainButtonAbrir_Click);            // 
            // MainLabelAbrir
            // 
            this.MainLabelAbrir.AutoSize = true;
            this.MainLabelAbrir.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelAbrir.ForeColor = Color.White;
            this.MainLabelAbrir.Location = new Point(53, 126);
            this.MainLabelAbrir.Name = "MainLabelAbrir";
            this.MainLabelAbrir.Size = new Size(37, 17);
            this.MainLabelAbrir.TabIndex = 8;
            this.MainLabelAbrir.Text = "Abrir";            // 
            // MainButtonSair
            // 
            this.MainButtonSair.BackColor = Color.Transparent;
            this.MainButtonSair.Image = global::deteccaoCarga.Properties.Resources.exitProgram;
            this.MainButtonSair.ImageActive = null;
            this.MainButtonSair.InitialImage = null;
            this.MainButtonSair.Location = new Point(14, 244);
            this.MainButtonSair.Name = "MainButtonSair";
            this.MainButtonSair.Size = new Size(32, 64);
            this.MainButtonSair.SizeMode = PictureBoxSizeMode.CenterImage;
            this.MainButtonSair.TabIndex = 13;
            this.MainButtonSair.TabStop = false;
            this.MainButtonSair.Zoom = 0;
            this.MainButtonSair.Click += new EventHandler(this.MainButtonSair_Click);
            // 
            // MainLabelSair
            // 
            this.MainLabelSair.AutoSize = true;
            this.MainLabelSair.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelSair.ForeColor = Color.White;
            this.MainLabelSair.Location = new Point(53, 268);
            this.MainLabelSair.Name = "MainLabelSair";
            this.MainLabelSair.Size = new Size(30, 17);
            this.MainLabelSair.TabIndex = 10;
            this.MainLabelSair.Text = "Sair";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(136, 70);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainLabelProcessar
            // 
            this.MainLabelProcessar.AutoSize = true;
            this.MainLabelProcessar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelProcessar.ForeColor = Color.White;
            this.MainLabelProcessar.Location = new Point(53, 197);
            this.MainLabelProcessar.Name = "MainLabelProcessar";
            this.MainLabelProcessar.Size = new Size(68, 17);
            this.MainLabelProcessar.TabIndex = 9;
            this.MainLabelProcessar.Text = "Processar";
            // 
            // MainButtonProcessar
            // 
            this.MainButtonProcessar.BackColor = Color.Transparent;
            this.MainButtonProcessar.Image = global::deteccaoCarga.Properties.Resources.processFile;
            this.MainButtonProcessar.ImageActive = null;
            this.MainButtonProcessar.InitialImage = null;
            this.MainButtonProcessar.Location = new Point(14, 173);
            this.MainButtonProcessar.Name = "MainButtonProcessar";
            this.MainButtonProcessar.Size = new Size(33, 64);
            this.MainButtonProcessar.SizeMode = PictureBoxSizeMode.CenterImage;
            this.MainButtonProcessar.TabIndex = 5;
            this.MainButtonProcessar.TabStop = false;
            this.MainButtonProcessar.Zoom = 0;
            this.MainButtonProcessar.Click += new EventHandler(this.MainButtonProcessar_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = Color.Transparent;
            this.bunifuSeparator1.LineColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new Point(4, 81);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new Size(164, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = Color.Transparent;
            this.bunifuSeparator3.LineColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new Point(4, 223);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new Size(164, 35);
            this.bunifuSeparator3.TabIndex = 12;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = Color.Transparent;
            this.bunifuSeparator2.LineColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new Point(4, 152);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new Size(164, 35);
            this.bunifuSeparator2.TabIndex = 11;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // MainButtonIndicator
            // 
            this.MainButtonIndicator.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.MainButtonIndicator.Location = new Point(131, 132);
            this.MainButtonIndicator.Name = "MainButtonIndicator";
            this.MainButtonIndicator.Size = new Size(12, 64);
            this.MainButtonIndicator.TabIndex = 5;
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.AutoSize = true;
            this.MainStatusBar.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusBar.ForeColor = Color.White;
            this.MainStatusBar.Location = new Point(13, 7);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new Size(192, 16);
            this.MainStatusBar.TabIndex = 0;
            this.MainStatusBar.Text = "Aguardando carregar o arquivo...";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.BackColor = Color.White;
            this.MainProgressBar.BorderRadius = 5;
            this.MainProgressBar.Location = new Point(221, 11);
            this.MainProgressBar.MaximumValue = 100;
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.ProgressColor = Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.MainProgressBar.Size = new Size(417, 10);
            this.MainProgressBar.TabIndex = 1;
            this.MainProgressBar.Value = 0;
            this.MainProgressBar.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.MainProgressBar);
            this.panel2.Controls.Add(this.MainStatusBar);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(650, 30);
            this.panel2.TabIndex = 1;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = Color.Transparent;
            this.bunifuSeparator5.LineColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new Point(143, 34);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new Size(10, 308);
            this.bunifuSeparator5.TabIndex = 4;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = Color.Transparent;
            this.bunifuSeparator4.LineColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new Point(0, 28);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new Size(650, 10);
            this.bunifuSeparator4.TabIndex = 3;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // MainButtonMinimize
            // 
            this.MainButtonMinimize.AccessibleRole = AccessibleRole.None;
            this.MainButtonMinimize.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainButtonMinimize.Image = global::deteccaoCarga.Properties.Resources.minimizeWindow1;
            this.MainButtonMinimize.ImageActive = null;
            this.MainButtonMinimize.InitialImage = null;
            this.MainButtonMinimize.Location = new Point(555, 1);
            this.MainButtonMinimize.Name = "MainButtonMinimize";
            this.MainButtonMinimize.Size = new Size(31, 31);
            this.MainButtonMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            this.MainButtonMinimize.TabIndex = 9;
            this.MainButtonMinimize.TabStop = false;
            this.MainButtonMinimize.Zoom = 0;
            this.MainButtonMinimize.Click += new EventHandler(this.MainButtonMinimize_Click);
            this.MainButtonMinimize.MouseLeave += new EventHandler(this.MainButtonMinimize_MouseLeave);
            this.MainButtonMinimize.MouseHover += new EventHandler(this.MainButtonMinimize_MouseHover);
            // 
            // MainButtonExpandCompress
            // 
            this.MainButtonExpandCompress.AccessibleRole = AccessibleRole.None;
            this.MainButtonExpandCompress.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainButtonExpandCompress.Enabled = false;
            this.MainButtonExpandCompress.Image = global::deteccaoCarga.Properties.Resources.expandWindow;
            this.MainButtonExpandCompress.ImageActive = null;
            this.MainButtonExpandCompress.InitialImage = null;
            this.MainButtonExpandCompress.Location = new Point(587, 1);
            this.MainButtonExpandCompress.Name = "MainButtonExpandCompress";
            this.MainButtonExpandCompress.Size = new Size(31, 31);
            this.MainButtonExpandCompress.SizeMode = PictureBoxSizeMode.CenterImage;
            this.MainButtonExpandCompress.TabIndex = 8;
            this.MainButtonExpandCompress.TabStop = false;
            this.MainButtonExpandCompress.Zoom = 0;
            this.MainButtonExpandCompress.Click += new EventHandler(this.MainButtonExpandCompress_Click);
            this.MainButtonExpandCompress.MouseLeave += new EventHandler(this.MainButtonExpandCompress_MouseLeave);
            this.MainButtonExpandCompress.MouseHover += new EventHandler(this.MainButtonExpandCompress_MouseHover);
            // 
            // MainButtonExit
            // 
            this.MainButtonExit.AccessibleRole = AccessibleRole.None;
            this.MainButtonExit.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainButtonExit.Image = global::deteccaoCarga.Properties.Resources.closeWindow1;
            this.MainButtonExit.ImageActive = null;
            this.MainButtonExit.InitialImage = null;
            this.MainButtonExit.Location = new Point(619, 1);
            this.MainButtonExit.Name = "MainButtonExit";
            this.MainButtonExit.Size = new Size(31, 31);
            this.MainButtonExit.SizeMode = PictureBoxSizeMode.CenterImage;
            this.MainButtonExit.TabIndex = 4;
            this.MainButtonExit.TabStop = false;
            this.MainButtonExit.Zoom = 0;
            this.MainButtonExit.Click += new EventHandler(this.MainButtonExit_Click);
            this.MainButtonExit.MouseLeave += new EventHandler(this.MainButtonExit_MouseLeave);
            this.MainButtonExit.MouseHover += new EventHandler(this.MainButtonExit_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new Point(7, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(22, 25);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // MainDataGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.MainDataGrid.BackgroundColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainDataGrid.BorderStyle = BorderStyle.None;
            this.MainDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.MainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Cursor = Cursors.Default;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            this.MainDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainDataGrid.DoubleBuffered = true;
            this.MainDataGrid.EnableHeadersVisualStyles = false;
            this.MainDataGrid.HeaderBgColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.MainDataGrid.HeaderForeColor = Color.SeaShell;
            this.MainDataGrid.Location = new Point(159, 44);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.MainDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MainDataGrid.Size = new Size(480, 290);
            this.MainDataGrid.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new Point(159, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(464, 16);
            this.panel1.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.panel5.Location = new Point(22, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(64, 12);
            this.panel5.TabIndex = 6;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.bunifuImageButton2.Image = ((Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new Point(448, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new Size(16, 16);
            this.bunifuImageButton2.SizeMode = PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 17;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.bunifuImageButton1.Image = ((Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new Size(16, 16);
            this.bunifuImageButton1.SizeMode = PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.bunifuImageButton4);
            this.panel4.Controls.Add(this.bunifuImageButton3);
            this.panel4.Location = new Point(623, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(16, 274);
            this.panel4.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.panel6.Location = new Point(2, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new Size(12, 64);
            this.panel6.TabIndex = 6;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.bunifuImageButton4.Image = ((Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new Point(0, 258);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new Size(16, 16);
            this.bunifuImageButton4.SizeMode = PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 19;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.bunifuImageButton3.Image = ((Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new Point(0, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new Size(16, 16);
            this.bunifuImageButton3.SizeMode = PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 18;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new Size(650, 372);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainDataGrid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MainButtonMinimize);
            this.Controls.Add(this.MainButtonExpandCompress);
            this.Controls.Add(this.MainButtonExit);
            this.Controls.Add(this.MainButtonIndicator);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MainPanelTop);
            this.Controls.Add(this.panel2);
            this.Cursor = Cursors.Default;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MainPanelTop.ResumeLayout(false);
            this.MainPanelTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonProcessar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonExpandCompress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Declaração dos componentes
        private Panel MainPanelTop;
        private Panel panel3;
        private BunifuCustomLabel MainLabelProgramName;
        private BunifuCustomLabel MainLabelSair;
        private BunifuCustomLabel MainLabelProcessar;
        private BunifuCustomLabel MainLabelAbrir;
        private BunifuImageButton MainButtonProcessar;
        private BunifuImageButton MainButtonAbrir;
        private Panel MainButtonIndicator;
        private BunifuImageButton MainButtonSair;
        private BunifuImageButton MainButtonExit;
        private BunifuImageButton MainButtonExpandCompress;
        private BunifuImageButton MainButtonMinimize;
        private BunifuCustomLabel MainStatusBar;
        private BunifuProgressBar MainProgressBar;
        private Panel panel2;
        private BunifuSeparator bunifuSeparator1;
        private BunifuSeparator bunifuSeparator3;
        private BunifuSeparator bunifuSeparator2;
        private BunifuSeparator bunifuSeparator5;
        private BunifuSeparator bunifuSeparator4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private BackgroundWorker backgroundWorker1;
        private BunifuCustomDataGrid MainDataGrid;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private BunifuImageButton bunifuImageButton2;
        private BunifuImageButton bunifuImageButton1;
        private Panel panel6;
        private BunifuImageButton bunifuImageButton4;
        private BunifuImageButton bunifuImageButton3;
        #endregion
    }
}

