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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainLabelProgramName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainButtonMinimize = new System.Windows.Forms.Button();
            this.MainButtonExpandCompress = new System.Windows.Forms.Button();
            this.MainButtonExit = new System.Windows.Forms.Button();
            this.MainLabelStatusBar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainProgressBarStatus = new Bunifu.Framework.UI.BunifuProgressBar();
            this.MainPanelStatusBar = new System.Windows.Forms.Panel();
            this.MainPictureBoxUcsIco = new System.Windows.Forms.PictureBox();
            this.MainPictureBoxUcsLogo = new System.Windows.Forms.PictureBox();
            this.MainButtonAbrir = new System.Windows.Forms.Button();
            this.MainButtonAdicionar = new System.Windows.Forms.Button();
            this.MainButtonRemover = new System.Windows.Forms.Button();
            this.MainPanelButtonIndicator = new System.Windows.Forms.Panel();
            this.MainPanelLeftButtons = new System.Windows.Forms.Panel();
            this.MainButtonProcessar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainButtonSair = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MainPanelDesktop = new System.Windows.Forms.Panel();
            this.MainPanelScrollBarBottom = new System.Windows.Forms.Panel();
            this.MainPanelScrollBottomDataGrid = new System.Windows.Forms.Panel();
            this.MainPanelScrollBarRight = new System.Windows.Forms.Panel();
            this.MainPanelScrollLeftDataGrid = new System.Windows.Forms.Panel();
            this.MainPanelDataGrid = new System.Windows.Forms.Panel();
            this.MainDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MainPanelTop.SuspendLayout();
            this.MainPanelStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxUcsIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxUcsLogo)).BeginInit();
            this.MainPanelLeftButtons.SuspendLayout();
            this.panel5.SuspendLayout();
            this.MainPanelDesktop.SuspendLayout();
            this.MainPanelScrollBarBottom.SuspendLayout();
            this.MainPanelScrollBarRight.SuspendLayout();
            this.MainPanelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelTop
            // 
            this.MainPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelTop.Controls.Add(this.panel2);
            this.MainPanelTop.Controls.Add(this.MainLabelProgramName);
            this.MainPanelTop.Controls.Add(this.MainButtonMinimize);
            this.MainPanelTop.Controls.Add(this.MainButtonExpandCompress);
            this.MainPanelTop.Controls.Add(this.MainButtonExit);
            this.MainPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanelTop.Location = new System.Drawing.Point(0, 0);
            this.MainPanelTop.Name = "MainPanelTop";
            this.MainPanelTop.Size = new System.Drawing.Size(619, 30);
            this.MainPanelTop.TabIndex = 0;
            this.MainPanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseDown);
            this.MainPanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseMove);
            this.MainPanelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(149, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 455);
            this.panel2.TabIndex = 19;
            // 
            // MainLabelProgramName
            // 
            this.MainLabelProgramName.AutoSize = true;
            this.MainLabelProgramName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelProgramName.ForeColor = System.Drawing.Color.White;
            this.MainLabelProgramName.Location = new System.Drawing.Point(34, 7);
            this.MainLabelProgramName.Name = "MainLabelProgramName";
            this.MainLabelProgramName.Size = new System.Drawing.Size(115, 17);
            this.MainLabelProgramName.TabIndex = 3;
            this.MainLabelProgramName.Text = "Sensor de Carga";
            // 
            // MainButtonMinimize
            // 
            this.MainButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonMinimize.FlatAppearance.BorderSize = 0;
            this.MainButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonMinimize.Image")));
            this.MainButtonMinimize.Location = new System.Drawing.Point(526, -1);
            this.MainButtonMinimize.Name = "MainButtonMinimize";
            this.MainButtonMinimize.Size = new System.Drawing.Size(28, 28);
            this.MainButtonMinimize.TabIndex = 18;
            this.MainButtonMinimize.UseVisualStyleBackColor = false;
            this.MainButtonMinimize.Click += new System.EventHandler(this.MainButtonMinimize_Click);
            // 
            // MainButtonExpandCompress
            // 
            this.MainButtonExpandCompress.Enabled = false;
            this.MainButtonExpandCompress.FlatAppearance.BorderSize = 0;
            this.MainButtonExpandCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonExpandCompress.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonExpandCompress.Image")));
            this.MainButtonExpandCompress.Location = new System.Drawing.Point(557, -1);
            this.MainButtonExpandCompress.Name = "MainButtonExpandCompress";
            this.MainButtonExpandCompress.Size = new System.Drawing.Size(28, 28);
            this.MainButtonExpandCompress.TabIndex = 17;
            this.MainButtonExpandCompress.UseVisualStyleBackColor = true;
            this.MainButtonExpandCompress.Click += new System.EventHandler(this.MainButtonExpandCompress_Click);
            // 
            // MainButtonExit
            // 
            this.MainButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonExit.FlatAppearance.BorderSize = 0;
            this.MainButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.MainButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonExit.Image")));
            this.MainButtonExit.Location = new System.Drawing.Point(588, -1);
            this.MainButtonExit.Name = "MainButtonExit";
            this.MainButtonExit.Size = new System.Drawing.Size(28, 28);
            this.MainButtonExit.TabIndex = 16;
            this.MainButtonExit.UseVisualStyleBackColor = false;
            this.MainButtonExit.Click += new System.EventHandler(this.MainButtonExit_Click);
            // 
            // MainLabelStatusBar
            // 
            this.MainLabelStatusBar.AutoSize = true;
            this.MainLabelStatusBar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelStatusBar.ForeColor = System.Drawing.Color.White;
            this.MainLabelStatusBar.Location = new System.Drawing.Point(13, 7);
            this.MainLabelStatusBar.Name = "MainLabelStatusBar";
            this.MainLabelStatusBar.Size = new System.Drawing.Size(192, 16);
            this.MainLabelStatusBar.TabIndex = 0;
            this.MainLabelStatusBar.Text = "Aguardando carregar o arquivo...";
            // 
            // MainProgressBarStatus
            // 
            this.MainProgressBarStatus.BackColor = System.Drawing.Color.White;
            this.MainProgressBarStatus.BorderRadius = 5;
            this.MainProgressBarStatus.Location = new System.Drawing.Point(162, 11);
            this.MainProgressBarStatus.MaximumValue = 100;
            this.MainProgressBarStatus.Name = "MainProgressBarStatus";
            this.MainProgressBarStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.MainProgressBarStatus.Size = new System.Drawing.Size(444, 10);
            this.MainProgressBarStatus.TabIndex = 1;
            this.MainProgressBarStatus.Value = 0;
            this.MainProgressBarStatus.Visible = false;
            // 
            // MainPanelStatusBar
            // 
            this.MainPanelStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.MainPanelStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelStatusBar.Controls.Add(this.MainProgressBarStatus);
            this.MainPanelStatusBar.Controls.Add(this.MainLabelStatusBar);
            this.MainPanelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanelStatusBar.Location = new System.Drawing.Point(0, 484);
            this.MainPanelStatusBar.Name = "MainPanelStatusBar";
            this.MainPanelStatusBar.Size = new System.Drawing.Size(619, 30);
            this.MainPanelStatusBar.TabIndex = 1;
            // 
            // MainPictureBoxUcsIco
            // 
            this.MainPictureBoxUcsIco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPictureBoxUcsIco.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBoxUcsIco.Image")));
            this.MainPictureBoxUcsIco.Location = new System.Drawing.Point(7, 4);
            this.MainPictureBoxUcsIco.Name = "MainPictureBoxUcsIco";
            this.MainPictureBoxUcsIco.Size = new System.Drawing.Size(21, 22);
            this.MainPictureBoxUcsIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainPictureBoxUcsIco.TabIndex = 11;
            this.MainPictureBoxUcsIco.TabStop = false;
            // 
            // MainPictureBoxUcsLogo
            // 
            this.MainPictureBoxUcsLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPictureBoxUcsLogo.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBoxUcsLogo.Image")));
            this.MainPictureBoxUcsLogo.Location = new System.Drawing.Point(0, -1);
            this.MainPictureBoxUcsLogo.Name = "MainPictureBoxUcsLogo";
            this.MainPictureBoxUcsLogo.Size = new System.Drawing.Size(150, 103);
            this.MainPictureBoxUcsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainPictureBoxUcsLogo.TabIndex = 10;
            this.MainPictureBoxUcsLogo.TabStop = false;
            // 
            // MainButtonAbrir
            // 
            this.MainButtonAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonAbrir.FlatAppearance.BorderSize = 0;
            this.MainButtonAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonAbrir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonAbrir.ForeColor = System.Drawing.Color.Transparent;
            this.MainButtonAbrir.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonAbrir.Image")));
            this.MainButtonAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonAbrir.Location = new System.Drawing.Point(13, 101);
            this.MainButtonAbrir.Name = "MainButtonAbrir";
            this.MainButtonAbrir.Size = new System.Drawing.Size(137, 70);
            this.MainButtonAbrir.TabIndex = 16;
            this.MainButtonAbrir.Text = "Atualizar";
            this.MainButtonAbrir.UseVisualStyleBackColor = false;
            this.MainButtonAbrir.Click += new System.EventHandler(this.MainButtonAbrir_Click);
            // 
            // MainButtonAdicionar
            // 
            this.MainButtonAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonAdicionar.FlatAppearance.BorderSize = 0;
            this.MainButtonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonAdicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonAdicionar.ForeColor = System.Drawing.Color.Transparent;
            this.MainButtonAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonAdicionar.Image")));
            this.MainButtonAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonAdicionar.Location = new System.Drawing.Point(12, 171);
            this.MainButtonAdicionar.Name = "MainButtonAdicionar";
            this.MainButtonAdicionar.Size = new System.Drawing.Size(137, 70);
            this.MainButtonAdicionar.TabIndex = 17;
            this.MainButtonAdicionar.Text = "Adicionar";
            this.MainButtonAdicionar.UseVisualStyleBackColor = false;
            this.MainButtonAdicionar.Click += new System.EventHandler(this.MainButtonAdicionar_Click);
            // 
            // MainButtonRemover
            // 
            this.MainButtonRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonRemover.FlatAppearance.BorderSize = 0;
            this.MainButtonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonRemover.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonRemover.ForeColor = System.Drawing.Color.Transparent;
            this.MainButtonRemover.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonRemover.Image")));
            this.MainButtonRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonRemover.Location = new System.Drawing.Point(12, 241);
            this.MainButtonRemover.Name = "MainButtonRemover";
            this.MainButtonRemover.Size = new System.Drawing.Size(137, 70);
            this.MainButtonRemover.TabIndex = 18;
            this.MainButtonRemover.Text = "Remover";
            this.MainButtonRemover.UseVisualStyleBackColor = false;
            this.MainButtonRemover.Click += new System.EventHandler(this.MainButtonRemover_Click);
            // 
            // MainPanelButtonIndicator
            // 
            this.MainPanelButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.MainPanelButtonIndicator.Location = new System.Drawing.Point(0, 101);
            this.MainPanelButtonIndicator.Name = "MainPanelButtonIndicator";
            this.MainPanelButtonIndicator.Size = new System.Drawing.Size(12, 70);
            this.MainPanelButtonIndicator.TabIndex = 5;
            // 
            // MainPanelLeftButtons
            // 
            this.MainPanelLeftButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelLeftButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelLeftButtons.Controls.Add(this.MainButtonProcessar);
            this.MainPanelLeftButtons.Controls.Add(this.panel3);
            this.MainPanelLeftButtons.Controls.Add(this.MainButtonSair);
            this.MainPanelLeftButtons.Controls.Add(this.MainPanelButtonIndicator);
            this.MainPanelLeftButtons.Controls.Add(this.MainPictureBoxUcsLogo);
            this.MainPanelLeftButtons.Controls.Add(this.MainButtonRemover);
            this.MainPanelLeftButtons.Controls.Add(this.MainButtonAdicionar);
            this.MainPanelLeftButtons.Controls.Add(this.MainButtonAbrir);
            this.MainPanelLeftButtons.Location = new System.Drawing.Point(0, 29);
            this.MainPanelLeftButtons.Name = "MainPanelLeftButtons";
            this.MainPanelLeftButtons.Size = new System.Drawing.Size(150, 455);
            this.MainPanelLeftButtons.TabIndex = 2;
            // 
            // MainButtonProcessar
            // 
            this.MainButtonProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonProcessar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonProcessar.FlatAppearance.BorderSize = 0;
            this.MainButtonProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonProcessar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonProcessar.ForeColor = System.Drawing.Color.Transparent;
            this.MainButtonProcessar.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonProcessar.Image")));
            this.MainButtonProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonProcessar.Location = new System.Drawing.Point(12, 311);
            this.MainButtonProcessar.Name = "MainButtonProcessar";
            this.MainButtonProcessar.Size = new System.Drawing.Size(137, 70);
            this.MainButtonProcessar.TabIndex = 22;
            this.MainButtonProcessar.Text = "Processar";
            this.MainButtonProcessar.UseVisualStyleBackColor = false;
            this.MainButtonProcessar.Click += new System.EventHandler(this.MainButtonProcessar_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(148, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 454);
            this.panel3.TabIndex = 21;
            // 
            // MainButtonSair
            // 
            this.MainButtonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainButtonSair.FlatAppearance.BorderSize = 0;
            this.MainButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonSair.ForeColor = System.Drawing.Color.Transparent;
            this.MainButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonSair.Image")));
            this.MainButtonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonSair.Location = new System.Drawing.Point(13, 381);
            this.MainButtonSair.Name = "MainButtonSair";
            this.MainButtonSair.Size = new System.Drawing.Size(137, 70);
            this.MainButtonSair.TabIndex = 20;
            this.MainButtonSair.Text = "Sair";
            this.MainButtonSair.UseVisualStyleBackColor = false;
            this.MainButtonSair.Click += new System.EventHandler(this.MainButtonSair_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.MainPanelDesktop);
            this.panel5.Location = new System.Drawing.Point(151, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 456);
            this.panel5.TabIndex = 21;
            // 
            // MainPanelDesktop
            // 
            this.MainPanelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelDesktop.Controls.Add(this.MainPanelDataGrid);
            this.MainPanelDesktop.Location = new System.Drawing.Point(13, 13);
            this.MainPanelDesktop.Name = "MainPanelDesktop";
            this.MainPanelDesktop.Size = new System.Drawing.Size(441, 431);
            this.MainPanelDesktop.TabIndex = 20;
            // 
            // MainPanelScrollBarBottom
            // 
            this.MainPanelScrollBarBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelScrollBarBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelScrollBarBottom.Controls.Add(this.MainPanelScrollBottomDataGrid);
            this.MainPanelScrollBarBottom.Location = new System.Drawing.Point(-1, 412);
            this.MainPanelScrollBarBottom.Name = "MainPanelScrollBarBottom";
            this.MainPanelScrollBarBottom.Size = new System.Drawing.Size(423, 18);
            this.MainPanelScrollBarBottom.TabIndex = 14;
            // 
            // MainPanelScrollBottomDataGrid
            // 
            this.MainPanelScrollBottomDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.MainPanelScrollBottomDataGrid.Location = new System.Drawing.Point(2, 2);
            this.MainPanelScrollBottomDataGrid.Name = "MainPanelScrollBottomDataGrid";
            this.MainPanelScrollBottomDataGrid.Size = new System.Drawing.Size(64, 12);
            this.MainPanelScrollBottomDataGrid.TabIndex = 6;
            // 
            // MainPanelScrollBarRight
            // 
            this.MainPanelScrollBarRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelScrollBarRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelScrollBarRight.Controls.Add(this.MainPanelScrollLeftDataGrid);
            this.MainPanelScrollBarRight.Location = new System.Drawing.Point(422, -1);
            this.MainPanelScrollBarRight.Name = "MainPanelScrollBarRight";
            this.MainPanelScrollBarRight.Size = new System.Drawing.Size(18, 414);
            this.MainPanelScrollBarRight.TabIndex = 15;
            // 
            // MainPanelScrollLeftDataGrid
            // 
            this.MainPanelScrollLeftDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.MainPanelScrollLeftDataGrid.Location = new System.Drawing.Point(2, 2);
            this.MainPanelScrollLeftDataGrid.Name = "MainPanelScrollLeftDataGrid";
            this.MainPanelScrollLeftDataGrid.Size = new System.Drawing.Size(12, 64);
            this.MainPanelScrollLeftDataGrid.TabIndex = 6;
            // 
            // MainPanelDataGrid
            // 
            this.MainPanelDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanelDataGrid.Controls.Add(this.MainPanelScrollBarRight);
            this.MainPanelDataGrid.Controls.Add(this.MainPanelScrollBarBottom);
            this.MainPanelDataGrid.Controls.Add(this.MainDataGrid);
            this.MainPanelDataGrid.Location = new System.Drawing.Point(-1, -1);
            this.MainPanelDataGrid.Name = "MainPanelDataGrid";
            this.MainPanelDataGrid.Size = new System.Drawing.Size(441, 431);
            this.MainPanelDataGrid.TabIndex = 19;
            // 
            // MainDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.MainDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MainDataGrid.ColumnHeadersHeight = 20;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.MainDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.MainDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MainDataGrid.RowHeadersVisible = false;
            this.MainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MainDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MainDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.MainDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.MainDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MainDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGrid.RowTemplate.ReadOnly = true;
            this.MainDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MainDataGrid.Size = new System.Drawing.Size(422, 413);
            this.MainDataGrid.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(619, 514);
            this.Controls.Add(this.MainPictureBoxUcsIco);
            this.Controls.Add(this.MainPanelLeftButtons);
            this.Controls.Add(this.MainPanelTop);
            this.Controls.Add(this.MainPanelStatusBar);
            this.Controls.Add(this.panel5);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MainPanelTop.ResumeLayout(false);
            this.MainPanelTop.PerformLayout();
            this.MainPanelStatusBar.ResumeLayout(false);
            this.MainPanelStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxUcsIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxUcsLogo)).EndInit();
            this.MainPanelLeftButtons.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.MainPanelDesktop.ResumeLayout(false);
            this.MainPanelScrollBarBottom.ResumeLayout(false);
            this.MainPanelScrollBarRight.ResumeLayout(false);
            this.MainPanelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        #region Declaração dos componentes
        private System.Windows.Forms.Panel MainPanelTop;
        private Bunifu.Framework.UI.BunifuCustomLabel MainLabelProgramName;
        private Bunifu.Framework.UI.BunifuCustomLabel MainLabelStatusBar;
        private Bunifu.Framework.UI.BunifuProgressBar MainProgressBarStatus;
        private System.Windows.Forms.Panel MainPanelStatusBar;
        private System.Windows.Forms.PictureBox MainPictureBoxUcsIco;
        #endregion
        private System.Windows.Forms.PictureBox MainPictureBoxUcsLogo;
        private System.Windows.Forms.Button MainButtonAbrir;
        private System.Windows.Forms.Button MainButtonAdicionar;
        private System.Windows.Forms.Button MainButtonRemover;
        private System.Windows.Forms.Panel MainPanelButtonIndicator;
        private System.Windows.Forms.Panel MainPanelLeftButtons;
        private System.Windows.Forms.Button MainButtonExit;
        private System.Windows.Forms.Button MainButtonMinimize;
        private System.Windows.Forms.Button MainButtonExpandCompress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MainButtonSair;
        private System.Windows.Forms.Button MainButtonProcessar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel MainPanelDesktop;
        private System.Windows.Forms.Panel MainPanelDataGrid;
        private System.Windows.Forms.Panel MainPanelScrollBarRight;
        private System.Windows.Forms.Panel MainPanelScrollLeftDataGrid;
        private System.Windows.Forms.Panel MainPanelScrollBarBottom;
        private System.Windows.Forms.Panel MainPanelScrollBottomDataGrid;
        public Bunifu.Framework.UI.BunifuCustomDataGrid MainDataGrid;
    }
}

