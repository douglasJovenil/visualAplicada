namespace ImagemMonocromatica
{
    partial class MainPictureBoxLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPictureBoxLogo));
            this.MainPanelTop = new System.Windows.Forms.Panel();
            this.MainButtonMinimize = new System.Windows.Forms.Button();
            this.MainButtonExit = new System.Windows.Forms.Button();
            this.MainLabelTitulo = new System.Windows.Forms.Label();
            this.MainPictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainButtonAbrirDiretorio = new System.Windows.Forms.Button();
            this.MainButtonSair = new System.Windows.Forms.Button();
            this.MainButtonSalvar = new System.Windows.Forms.Button();
            this.MainButtonConverter = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainButtonAbrir = new System.Windows.Forms.Button();
            this.MainPictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.MainPictureBoxModificado = new System.Windows.Forms.PictureBox();
            this.MainLabelOriginal = new System.Windows.Forms.Label();
            this.MainLabelModificado = new System.Windows.Forms.Label();
            this.MainPictureBoxMostraCor = new System.Windows.Forms.PictureBox();
            this.MainTrackBarRed = new System.Windows.Forms.TrackBar();
            this.MainTrackBarGreen = new System.Windows.Forms.TrackBar();
            this.MainTrackBarBlue = new System.Windows.Forms.TrackBar();
            this.MainTrackBarTolerancia = new System.Windows.Forms.TrackBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.MainTimerTempo = new System.Windows.Forms.Timer(this.components);
            this.MainTrackBarTempo = new System.Windows.Forms.TrackBar();
            this.MainCheckBoxConverterTudo = new System.Windows.Forms.CheckBox();
            this.MainCheckBoxConverterLinha = new System.Windows.Forms.CheckBox();
            this.MainCheckBoxColuna = new System.Windows.Forms.CheckBox();
            this.MainPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxIcone)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxModificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxMostraCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarTolerancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelTop
            // 
            this.MainPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelTop.Controls.Add(this.MainButtonMinimize);
            this.MainPanelTop.Controls.Add(this.MainButtonExit);
            this.MainPanelTop.Controls.Add(this.MainLabelTitulo);
            this.MainPanelTop.Controls.Add(this.MainPictureBoxIcone);
            this.MainPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanelTop.Location = new System.Drawing.Point(0, 0);
            this.MainPanelTop.Name = "MainPanelTop";
            this.MainPanelTop.Size = new System.Drawing.Size(839, 30);
            this.MainPanelTop.TabIndex = 0;
            this.MainPanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseDown);
            this.MainPanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseMove);
            this.MainPanelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPanelTop_MouseUp);
            // 
            // MainButtonMinimize
            // 
            this.MainButtonMinimize.FlatAppearance.BorderSize = 0;
            this.MainButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonMinimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonMinimize.ForeColor = System.Drawing.Color.White;
            this.MainButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonMinimize.Image")));
            this.MainButtonMinimize.Location = new System.Drawing.Point(780, 2);
            this.MainButtonMinimize.Name = "MainButtonMinimize";
            this.MainButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.MainButtonMinimize.TabIndex = 10;
            this.MainButtonMinimize.UseVisualStyleBackColor = true;
            this.MainButtonMinimize.Click += new System.EventHandler(this.MainButtonMinimize_Click);
            // 
            // MainButtonExit
            // 
            this.MainButtonExit.FlatAppearance.BorderSize = 0;
            this.MainButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonExit.ForeColor = System.Drawing.Color.White;
            this.MainButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonExit.Image")));
            this.MainButtonExit.Location = new System.Drawing.Point(811, 3);
            this.MainButtonExit.Name = "MainButtonExit";
            this.MainButtonExit.Size = new System.Drawing.Size(25, 25);
            this.MainButtonExit.TabIndex = 8;
            this.MainButtonExit.UseVisualStyleBackColor = true;
            this.MainButtonExit.Click += new System.EventHandler(this.MainButtonExit_Click);
            // 
            // MainLabelTitulo
            // 
            this.MainLabelTitulo.AutoSize = true;
            this.MainLabelTitulo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelTitulo.ForeColor = System.Drawing.Color.White;
            this.MainLabelTitulo.Location = new System.Drawing.Point(40, 9);
            this.MainLabelTitulo.Name = "MainLabelTitulo";
            this.MainLabelTitulo.Size = new System.Drawing.Size(144, 16);
            this.MainLabelTitulo.TabIndex = 1;
            this.MainLabelTitulo.Text = "Imagem Monocromática";
            // 
            // MainPictureBoxIcone
            // 
            this.MainPictureBoxIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPictureBoxIcone.BackgroundImage")));
            this.MainPictureBoxIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPictureBoxIcone.Location = new System.Drawing.Point(13, 4);
            this.MainPictureBoxIcone.Name = "MainPictureBoxIcone";
            this.MainPictureBoxIcone.Size = new System.Drawing.Size(21, 20);
            this.MainPictureBoxIcone.TabIndex = 0;
            this.MainPictureBoxIcone.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.MainButtonAbrirDiretorio);
            this.panel1.Controls.Add(this.MainButtonSair);
            this.panel1.Controls.Add(this.MainButtonSalvar);
            this.panel1.Controls.Add(this.MainButtonConverter);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.MainButtonAbrir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 539);
            this.panel1.TabIndex = 2;
            // 
            // MainButtonAbrirDiretorio
            // 
            this.MainButtonAbrirDiretorio.FlatAppearance.BorderSize = 0;
            this.MainButtonAbrirDiretorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonAbrirDiretorio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButtonAbrirDiretorio.ForeColor = System.Drawing.Color.White;
            this.MainButtonAbrirDiretorio.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonAbrirDiretorio.Image")));
            this.MainButtonAbrirDiretorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonAbrirDiretorio.Location = new System.Drawing.Point(3, 199);
            this.MainButtonAbrirDiretorio.Name = "MainButtonAbrirDiretorio";
            this.MainButtonAbrirDiretorio.Size = new System.Drawing.Size(165, 64);
            this.MainButtonAbrirDiretorio.TabIndex = 8;
            this.MainButtonAbrirDiretorio.Text = "Abrir Diretório";
            this.MainButtonAbrirDiretorio.UseVisualStyleBackColor = true;
            this.MainButtonAbrirDiretorio.Click += new System.EventHandler(this.MainButtonAbrirDiretorio_Click);
            // 
            // MainButtonSair
            // 
            this.MainButtonSair.FlatAppearance.BorderSize = 0;
            this.MainButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonSair.ForeColor = System.Drawing.Color.White;
            this.MainButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonSair.Image")));
            this.MainButtonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonSair.Location = new System.Drawing.Point(3, 418);
            this.MainButtonSair.Name = "MainButtonSair";
            this.MainButtonSair.Size = new System.Drawing.Size(165, 64);
            this.MainButtonSair.TabIndex = 7;
            this.MainButtonSair.Text = "Sair";
            this.MainButtonSair.UseCompatibleTextRendering = true;
            this.MainButtonSair.UseVisualStyleBackColor = true;
            this.MainButtonSair.Click += new System.EventHandler(this.MainButtonSair_Click);
            // 
            // MainButtonSalvar
            // 
            this.MainButtonSalvar.FlatAppearance.BorderSize = 0;
            this.MainButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonSalvar.ForeColor = System.Drawing.Color.White;
            this.MainButtonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonSalvar.Image")));
            this.MainButtonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonSalvar.Location = new System.Drawing.Point(3, 345);
            this.MainButtonSalvar.Name = "MainButtonSalvar";
            this.MainButtonSalvar.Size = new System.Drawing.Size(165, 64);
            this.MainButtonSalvar.TabIndex = 6;
            this.MainButtonSalvar.Text = "Salvar";
            this.MainButtonSalvar.UseVisualStyleBackColor = true;
            this.MainButtonSalvar.Click += new System.EventHandler(this.MainButtonSalvar_Click);
            // 
            // MainButtonConverter
            // 
            this.MainButtonConverter.FlatAppearance.BorderSize = 0;
            this.MainButtonConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonConverter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonConverter.ForeColor = System.Drawing.Color.White;
            this.MainButtonConverter.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonConverter.Image")));
            this.MainButtonConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonConverter.Location = new System.Drawing.Point(3, 272);
            this.MainButtonConverter.Name = "MainButtonConverter";
            this.MainButtonConverter.Size = new System.Drawing.Size(165, 64);
            this.MainButtonConverter.TabIndex = 5;
            this.MainButtonConverter.Text = "Converter";
            this.MainButtonConverter.UseVisualStyleBackColor = true;
            this.MainButtonConverter.Click += new System.EventHandler(this.MainButtonConverter_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 124);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainButtonAbrir
            // 
            this.MainButtonAbrir.FlatAppearance.BorderSize = 0;
            this.MainButtonAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonAbrir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonAbrir.ForeColor = System.Drawing.Color.White;
            this.MainButtonAbrir.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonAbrir.Image")));
            this.MainButtonAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButtonAbrir.Location = new System.Drawing.Point(3, 126);
            this.MainButtonAbrir.Name = "MainButtonAbrir";
            this.MainButtonAbrir.Size = new System.Drawing.Size(165, 64);
            this.MainButtonAbrir.TabIndex = 3;
            this.MainButtonAbrir.Text = "Abrir";
            this.MainButtonAbrir.UseVisualStyleBackColor = true;
            this.MainButtonAbrir.Click += new System.EventHandler(this.MainButtonAbrir_Click);
            // 
            // MainPictureBoxOriginal
            // 
            this.MainPictureBoxOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPictureBoxOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPictureBoxOriginal.Location = new System.Drawing.Point(177, 68);
            this.MainPictureBoxOriginal.Name = "MainPictureBoxOriginal";
            this.MainPictureBoxOriginal.Size = new System.Drawing.Size(320, 240);
            this.MainPictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBoxOriginal.TabIndex = 3;
            this.MainPictureBoxOriginal.TabStop = false;
            // 
            // MainPictureBoxModificado
            // 
            this.MainPictureBoxModificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPictureBoxModificado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPictureBoxModificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPictureBoxModificado.Location = new System.Drawing.Point(512, 68);
            this.MainPictureBoxModificado.Name = "MainPictureBoxModificado";
            this.MainPictureBoxModificado.Size = new System.Drawing.Size(320, 240);
            this.MainPictureBoxModificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBoxModificado.TabIndex = 4;
            this.MainPictureBoxModificado.TabStop = false;
            // 
            // MainLabelOriginal
            // 
            this.MainLabelOriginal.AutoSize = true;
            this.MainLabelOriginal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelOriginal.ForeColor = System.Drawing.Color.White;
            this.MainLabelOriginal.Location = new System.Drawing.Point(303, 41);
            this.MainLabelOriginal.Name = "MainLabelOriginal";
            this.MainLabelOriginal.Size = new System.Drawing.Size(49, 16);
            this.MainLabelOriginal.TabIndex = 2;
            this.MainLabelOriginal.Text = "Original";
            // 
            // MainLabelModificado
            // 
            this.MainLabelModificado.AutoSize = true;
            this.MainLabelModificado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelModificado.ForeColor = System.Drawing.Color.White;
            this.MainLabelModificado.Location = new System.Drawing.Point(648, 41);
            this.MainLabelModificado.Name = "MainLabelModificado";
            this.MainLabelModificado.Size = new System.Drawing.Size(72, 16);
            this.MainLabelModificado.TabIndex = 5;
            this.MainLabelModificado.Text = "Modificada";
            // 
            // MainPictureBoxMostraCor
            // 
            this.MainPictureBoxMostraCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPictureBoxMostraCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPictureBoxMostraCor.Location = new System.Drawing.Point(512, 315);
            this.MainPictureBoxMostraCor.Name = "MainPictureBoxMostraCor";
            this.MainPictureBoxMostraCor.Size = new System.Drawing.Size(320, 219);
            this.MainPictureBoxMostraCor.TabIndex = 7;
            this.MainPictureBoxMostraCor.TabStop = false;
            // 
            // MainTrackBarRed
            // 
            this.MainTrackBarRed.AllowDrop = true;
            this.MainTrackBarRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTrackBarRed.Location = new System.Drawing.Point(177, 314);
            this.MainTrackBarRed.Maximum = 255;
            this.MainTrackBarRed.Name = "MainTrackBarRed";
            this.MainTrackBarRed.Size = new System.Drawing.Size(320, 42);
            this.MainTrackBarRed.TabIndex = 1;
            this.MainTrackBarRed.Scroll += new System.EventHandler(this.MainTrackBarSelecionaCor_Scroll);
            // 
            // MainTrackBarGreen
            // 
            this.MainTrackBarGreen.AllowDrop = true;
            this.MainTrackBarGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTrackBarGreen.Location = new System.Drawing.Point(177, 365);
            this.MainTrackBarGreen.Maximum = 255;
            this.MainTrackBarGreen.Name = "MainTrackBarGreen";
            this.MainTrackBarGreen.Size = new System.Drawing.Size(320, 42);
            this.MainTrackBarGreen.TabIndex = 8;
            this.MainTrackBarGreen.Scroll += new System.EventHandler(this.MainTrackBarGreen_Scroll);
            // 
            // MainTrackBarBlue
            // 
            this.MainTrackBarBlue.AllowDrop = true;
            this.MainTrackBarBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTrackBarBlue.Location = new System.Drawing.Point(177, 416);
            this.MainTrackBarBlue.Maximum = 255;
            this.MainTrackBarBlue.Name = "MainTrackBarBlue";
            this.MainTrackBarBlue.Size = new System.Drawing.Size(320, 42);
            this.MainTrackBarBlue.TabIndex = 9;
            this.MainTrackBarBlue.Scroll += new System.EventHandler(this.MainTrackBarBlue_Scroll);
            // 
            // MainTrackBarTolerancia
            // 
            this.MainTrackBarTolerancia.AllowDrop = true;
            this.MainTrackBarTolerancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTrackBarTolerancia.Location = new System.Drawing.Point(177, 467);
            this.MainTrackBarTolerancia.Maximum = 255;
            this.MainTrackBarTolerancia.Name = "MainTrackBarTolerancia";
            this.MainTrackBarTolerancia.Size = new System.Drawing.Size(320, 42);
            this.MainTrackBarTolerancia.TabIndex = 10;
            // 
            // MainTimerTempo
            // 
            this.MainTimerTempo.Interval = 10;
            this.MainTimerTempo.Tick += new System.EventHandler(this.MainTimerTempo_Tick);
            // 
            // MainTrackBarTempo
            // 
            this.MainTrackBarTempo.AllowDrop = true;
            this.MainTrackBarTempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTrackBarTempo.Location = new System.Drawing.Point(177, 518);
            this.MainTrackBarTempo.Maximum = 10000;
            this.MainTrackBarTempo.Minimum = 10;
            this.MainTrackBarTempo.Name = "MainTrackBarTempo";
            this.MainTrackBarTempo.Size = new System.Drawing.Size(320, 42);
            this.MainTrackBarTempo.TabIndex = 15;
            this.MainTrackBarTempo.Value = 10;
            this.MainTrackBarTempo.Scroll += new System.EventHandler(this.MainTrackBarTempo_Scroll);
            // 
            // MainCheckBoxConverterTudo
            // 
            this.MainCheckBoxConverterTudo.AutoSize = true;
            this.MainCheckBoxConverterTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainCheckBoxConverterTudo.Checked = true;
            this.MainCheckBoxConverterTudo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainCheckBoxConverterTudo.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.MainCheckBoxConverterTudo.ForeColor = System.Drawing.Color.White;
            this.MainCheckBoxConverterTudo.Location = new System.Drawing.Point(512, 540);
            this.MainCheckBoxConverterTudo.Name = "MainCheckBoxConverterTudo";
            this.MainCheckBoxConverterTudo.Size = new System.Drawing.Size(54, 20);
            this.MainCheckBoxConverterTudo.TabIndex = 16;
            this.MainCheckBoxConverterTudo.Text = "Tudo";
            this.MainCheckBoxConverterTudo.UseVisualStyleBackColor = false;
            // 
            // MainCheckBoxConverterLinha
            // 
            this.MainCheckBoxConverterLinha.AutoSize = true;
            this.MainCheckBoxConverterLinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainCheckBoxConverterLinha.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.MainCheckBoxConverterLinha.ForeColor = System.Drawing.Color.White;
            this.MainCheckBoxConverterLinha.Location = new System.Drawing.Point(637, 540);
            this.MainCheckBoxConverterLinha.Name = "MainCheckBoxConverterLinha";
            this.MainCheckBoxConverterLinha.Size = new System.Drawing.Size(56, 20);
            this.MainCheckBoxConverterLinha.TabIndex = 17;
            this.MainCheckBoxConverterLinha.Text = "Linha";
            this.MainCheckBoxConverterLinha.UseVisualStyleBackColor = false;
            // 
            // MainCheckBoxColuna
            // 
            this.MainCheckBoxColuna.AutoSize = true;
            this.MainCheckBoxColuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainCheckBoxColuna.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.MainCheckBoxColuna.ForeColor = System.Drawing.Color.White;
            this.MainCheckBoxColuna.Location = new System.Drawing.Point(764, 540);
            this.MainCheckBoxColuna.Name = "MainCheckBoxColuna";
            this.MainCheckBoxColuna.Size = new System.Drawing.Size(67, 20);
            this.MainCheckBoxColuna.TabIndex = 18;
            this.MainCheckBoxColuna.Text = "Coluna";
            this.MainCheckBoxColuna.UseVisualStyleBackColor = false;
            // 
            // MainPictureBoxLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(839, 569);
            this.Controls.Add(this.MainCheckBoxColuna);
            this.Controls.Add(this.MainCheckBoxConverterLinha);
            this.Controls.Add(this.MainCheckBoxConverterTudo);
            this.Controls.Add(this.MainTrackBarTempo);
            this.Controls.Add(this.MainTrackBarTolerancia);
            this.Controls.Add(this.MainTrackBarBlue);
            this.Controls.Add(this.MainTrackBarGreen);
            this.Controls.Add(this.MainPictureBoxMostraCor);
            this.Controls.Add(this.MainTrackBarRed);
            this.Controls.Add(this.MainLabelModificado);
            this.Controls.Add(this.MainLabelOriginal);
            this.Controls.Add(this.MainPictureBoxModificado);
            this.Controls.Add(this.MainPictureBoxOriginal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPictureBoxLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagem Monocromática";
            this.MainPanelTop.ResumeLayout(false);
            this.MainPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxIcone)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxModificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxMostraCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarTolerancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTrackBarTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainButtonAbrir;
        private System.Windows.Forms.PictureBox MainPictureBoxOriginal;
        private System.Windows.Forms.PictureBox MainPictureBoxModificado;
        private System.Windows.Forms.Label MainLabelTitulo;
        private System.Windows.Forms.PictureBox MainPictureBoxIcone;
        private System.Windows.Forms.Button MainButtonSair;
        private System.Windows.Forms.Button MainButtonSalvar;
        private System.Windows.Forms.Button MainButtonConverter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MainLabelOriginal;
        private System.Windows.Forms.Label MainLabelModificado;
        private System.Windows.Forms.PictureBox MainPictureBoxMostraCor;
        private System.Windows.Forms.Button MainButtonExit;
        private System.Windows.Forms.Button MainButtonMinimize;
        private System.Windows.Forms.TrackBar MainTrackBarRed;
        private System.Windows.Forms.TrackBar MainTrackBarGreen;
        private System.Windows.Forms.TrackBar MainTrackBarBlue;
        private System.Windows.Forms.Button MainButtonAbrirDiretorio;
        private System.Windows.Forms.TrackBar MainTrackBarTolerancia;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer MainTimerTempo;
        private System.Windows.Forms.TrackBar MainTrackBarTempo;
        private System.Windows.Forms.CheckBox MainCheckBoxConverterTudo;
        private System.Windows.Forms.CheckBox MainCheckBoxConverterLinha;
        private System.Windows.Forms.CheckBox MainCheckBoxColuna;
    }
}

