namespace ImagemMonocromatica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanelTop = new System.Windows.Forms.Panel();
            this.MainButtonMinimize = new System.Windows.Forms.Button();
            this.MainButtonExit = new System.Windows.Forms.Button();
            this.MainLabelTitulo = new System.Windows.Forms.Label();
            this.MainPictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.MainButton13 = new System.Windows.Forms.Button();
            this.MainButton23 = new System.Windows.Forms.Button();
            this.MainButton22 = new System.Windows.Forms.Button();
            this.MainButton21 = new System.Windows.Forms.Button();
            this.MainButton33 = new System.Windows.Forms.Button();
            this.MainButton32 = new System.Windows.Forms.Button();
            this.MainButton31 = new System.Windows.Forms.Button();
            this.MainPanelBottom = new System.Windows.Forms.Panel();
            this.MainLabelPorta = new System.Windows.Forms.Label();
            this.MainComboBoxPorta = new System.Windows.Forms.ComboBox();
            this.MainLabelStatus = new System.Windows.Forms.Label();
            this.MainButton12 = new System.Windows.Forms.Button();
            this.MainButton11 = new System.Windows.Forms.Button();
            this.MainPictureBoxMostraCor = new System.Windows.Forms.PictureBox();
            this.TimerVerifyUSB = new System.Windows.Forms.Timer(this.components);
            this.TimerHandShakeUSB = new System.Windows.Forms.Timer(this.components);
            this.TimerWin = new System.Windows.Forms.Timer(this.components);
            this.MainPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxIcone)).BeginInit();
            this.MainPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxMostraCor)).BeginInit();
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
            this.MainPanelTop.Size = new System.Drawing.Size(412, 30);
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
            this.MainButtonMinimize.Location = new System.Drawing.Point(353, 3);
            this.MainButtonMinimize.Name = "MainButtonMinimize";
            this.MainButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.MainButtonMinimize.TabIndex = 10;
            this.MainButtonMinimize.UseVisualStyleBackColor = true;
            // 
            // MainButtonExit
            // 
            this.MainButtonExit.FlatAppearance.BorderSize = 0;
            this.MainButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButtonExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButtonExit.ForeColor = System.Drawing.Color.White;
            this.MainButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("MainButtonExit.Image")));
            this.MainButtonExit.Location = new System.Drawing.Point(384, 3);
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
            this.MainLabelTitulo.Location = new System.Drawing.Point(40, 7);
            this.MainLabelTitulo.Name = "MainLabelTitulo";
            this.MainLabelTitulo.Size = new System.Drawing.Size(87, 16);
            this.MainLabelTitulo.TabIndex = 1;
            this.MainLabelTitulo.Text = "Jogo Da Velha";
            // 
            // MainPictureBoxIcone
            // 
            this.MainPictureBoxIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPictureBoxIcone.BackgroundImage")));
            this.MainPictureBoxIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPictureBoxIcone.Location = new System.Drawing.Point(13, 5);
            this.MainPictureBoxIcone.Name = "MainPictureBoxIcone";
            this.MainPictureBoxIcone.Size = new System.Drawing.Size(21, 20);
            this.MainPictureBoxIcone.TabIndex = 0;
            this.MainPictureBoxIcone.TabStop = false;
            // 
            // MainButton13
            // 
            this.MainButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton13.Enabled = false;
            this.MainButton13.FlatAppearance.BorderSize = 0;
            this.MainButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton13.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton13.ForeColor = System.Drawing.Color.White;
            this.MainButton13.Location = new System.Drawing.Point(272, 43);
            this.MainButton13.Name = "MainButton13";
            this.MainButton13.Size = new System.Drawing.Size(120, 120);
            this.MainButton13.TabIndex = 10;
            this.MainButton13.UseVisualStyleBackColor = true;
            this.MainButton13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainButton13_Click);
            // 
            // MainButton23
            // 
            this.MainButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton23.Enabled = false;
            this.MainButton23.FlatAppearance.BorderSize = 0;
            this.MainButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton23.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton23.ForeColor = System.Drawing.Color.White;
            this.MainButton23.Location = new System.Drawing.Point(272, 169);
            this.MainButton23.Name = "MainButton23";
            this.MainButton23.Size = new System.Drawing.Size(120, 120);
            this.MainButton23.TabIndex = 13;
            this.MainButton23.UseVisualStyleBackColor = true;
            this.MainButton23.Click += new System.EventHandler(this.MainButton23_Click);
            // 
            // MainButton22
            // 
            this.MainButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton22.Enabled = false;
            this.MainButton22.FlatAppearance.BorderSize = 0;
            this.MainButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton22.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton22.ForeColor = System.Drawing.Color.White;
            this.MainButton22.Location = new System.Drawing.Point(146, 169);
            this.MainButton22.Name = "MainButton22";
            this.MainButton22.Size = new System.Drawing.Size(120, 120);
            this.MainButton22.TabIndex = 12;
            this.MainButton22.UseVisualStyleBackColor = true;
            this.MainButton22.Click += new System.EventHandler(this.MainButton22_Click);
            // 
            // MainButton21
            // 
            this.MainButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton21.Enabled = false;
            this.MainButton21.FlatAppearance.BorderSize = 0;
            this.MainButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton21.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton21.ForeColor = System.Drawing.Color.White;
            this.MainButton21.Location = new System.Drawing.Point(20, 169);
            this.MainButton21.Name = "MainButton21";
            this.MainButton21.Size = new System.Drawing.Size(120, 120);
            this.MainButton21.TabIndex = 11;
            this.MainButton21.UseVisualStyleBackColor = true;
            this.MainButton21.Click += new System.EventHandler(this.MainButton21_Click);
            // 
            // MainButton33
            // 
            this.MainButton33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton33.Enabled = false;
            this.MainButton33.FlatAppearance.BorderSize = 0;
            this.MainButton33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton33.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton33.ForeColor = System.Drawing.Color.White;
            this.MainButton33.Location = new System.Drawing.Point(272, 295);
            this.MainButton33.Name = "MainButton33";
            this.MainButton33.Size = new System.Drawing.Size(120, 120);
            this.MainButton33.TabIndex = 16;
            this.MainButton33.UseVisualStyleBackColor = true;
            this.MainButton33.Click += new System.EventHandler(this.MainButton33_Click);
            // 
            // MainButton32
            // 
            this.MainButton32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton32.Enabled = false;
            this.MainButton32.FlatAppearance.BorderSize = 0;
            this.MainButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton32.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton32.ForeColor = System.Drawing.Color.White;
            this.MainButton32.Location = new System.Drawing.Point(146, 295);
            this.MainButton32.Name = "MainButton32";
            this.MainButton32.Size = new System.Drawing.Size(120, 120);
            this.MainButton32.TabIndex = 15;
            this.MainButton32.UseVisualStyleBackColor = true;
            this.MainButton32.Click += new System.EventHandler(this.MainButton32_Click);
            // 
            // MainButton31
            // 
            this.MainButton31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton31.Enabled = false;
            this.MainButton31.FlatAppearance.BorderSize = 0;
            this.MainButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton31.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton31.ForeColor = System.Drawing.Color.White;
            this.MainButton31.Location = new System.Drawing.Point(20, 295);
            this.MainButton31.Name = "MainButton31";
            this.MainButton31.Size = new System.Drawing.Size(120, 120);
            this.MainButton31.TabIndex = 14;
            this.MainButton31.UseVisualStyleBackColor = true;
            this.MainButton31.Click += new System.EventHandler(this.MainButton31_Click);
            // 
            // MainPanelBottom
            // 
            this.MainPanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanelBottom.Controls.Add(this.MainLabelPorta);
            this.MainPanelBottom.Controls.Add(this.MainComboBoxPorta);
            this.MainPanelBottom.Controls.Add(this.MainLabelStatus);
            this.MainPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanelBottom.Location = new System.Drawing.Point(0, 426);
            this.MainPanelBottom.Name = "MainPanelBottom";
            this.MainPanelBottom.Size = new System.Drawing.Size(412, 30);
            this.MainPanelBottom.TabIndex = 17;
            // 
            // MainLabelPorta
            // 
            this.MainLabelPorta.AutoSize = true;
            this.MainLabelPorta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelPorta.ForeColor = System.Drawing.Color.White;
            this.MainLabelPorta.Location = new System.Drawing.Point(295, 7);
            this.MainLabelPorta.Name = "MainLabelPorta";
            this.MainLabelPorta.Size = new System.Drawing.Size(37, 16);
            this.MainLabelPorta.TabIndex = 21;
            this.MainLabelPorta.Text = "Porta";
            // 
            // MainComboBoxPorta
            // 
            this.MainComboBoxPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainComboBoxPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainComboBoxPorta.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.MainComboBoxPorta.ForeColor = System.Drawing.Color.White;
            this.MainComboBoxPorta.FormattingEnabled = true;
            this.MainComboBoxPorta.Location = new System.Drawing.Point(338, 3);
            this.MainComboBoxPorta.Name = "MainComboBoxPorta";
            this.MainComboBoxPorta.Size = new System.Drawing.Size(69, 24);
            this.MainComboBoxPorta.TabIndex = 20;
            this.MainComboBoxPorta.SelectedIndexChanged += new System.EventHandler(this.MainComboBoxPorta_SelectedIndexChanged);
            // 
            // MainLabelStatus
            // 
            this.MainLabelStatus.AutoSize = true;
            this.MainLabelStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabelStatus.ForeColor = System.Drawing.Color.White;
            this.MainLabelStatus.Location = new System.Drawing.Point(3, 7);
            this.MainLabelStatus.Name = "MainLabelStatus";
            this.MainLabelStatus.Size = new System.Drawing.Size(89, 16);
            this.MainLabelStatus.TabIndex = 11;
            this.MainLabelStatus.Text = "Desconectado";
            // 
            // MainButton12
            // 
            this.MainButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton12.Enabled = false;
            this.MainButton12.FlatAppearance.BorderSize = 0;
            this.MainButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton12.ForeColor = System.Drawing.Color.White;
            this.MainButton12.Location = new System.Drawing.Point(146, 43);
            this.MainButton12.Name = "MainButton12";
            this.MainButton12.Size = new System.Drawing.Size(120, 120);
            this.MainButton12.TabIndex = 9;
            this.MainButton12.UseVisualStyleBackColor = true;
            this.MainButton12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainButton12_Click);
            // 
            // MainButton11
            // 
            this.MainButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainButton11.Enabled = false;
            this.MainButton11.FlatAppearance.BorderSize = 0;
            this.MainButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton11.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainButton11.ForeColor = System.Drawing.Color.White;
            this.MainButton11.Location = new System.Drawing.Point(20, 43);
            this.MainButton11.Name = "MainButton11";
            this.MainButton11.Size = new System.Drawing.Size(120, 120);
            this.MainButton11.TabIndex = 8;
            this.MainButton11.UseVisualStyleBackColor = true;
            this.MainButton11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainButton11_Click);
            // 
            // MainPictureBoxMostraCor
            // 
            this.MainPictureBoxMostraCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPictureBoxMostraCor.Location = new System.Drawing.Point(13, 36);
            this.MainPictureBoxMostraCor.Name = "MainPictureBoxMostraCor";
            this.MainPictureBoxMostraCor.Size = new System.Drawing.Size(386, 384);
            this.MainPictureBoxMostraCor.TabIndex = 7;
            this.MainPictureBoxMostraCor.TabStop = false;
            // 
            // TimerVerifyUSB
            // 
            this.TimerVerifyUSB.Tick += new System.EventHandler(this.TimerVerifyUSB_Tick);
            // 
            // TimerHandShakeUSB
            // 
            this.TimerHandShakeUSB.Tick += new System.EventHandler(this.TimerHandShakeUSB_Tick);
            // 
            // TimerWin
            // 
            this.TimerWin.Tick += new System.EventHandler(this.TimerWin_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(412, 456);
            this.Controls.Add(this.MainPanelBottom);
            this.Controls.Add(this.MainButton33);
            this.Controls.Add(this.MainButton32);
            this.Controls.Add(this.MainButton31);
            this.Controls.Add(this.MainButton23);
            this.Controls.Add(this.MainButton22);
            this.Controls.Add(this.MainButton21);
            this.Controls.Add(this.MainButton13);
            this.Controls.Add(this.MainButton12);
            this.Controls.Add(this.MainButton11);
            this.Controls.Add(this.MainPictureBoxMostraCor);
            this.Controls.Add(this.MainPanelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Da Velha";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanelTop.ResumeLayout(false);
            this.MainPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxIcone)).EndInit();
            this.MainPanelBottom.ResumeLayout(false);
            this.MainPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBoxMostraCor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelTop;
        private System.Windows.Forms.Label MainLabelTitulo;
        private System.Windows.Forms.PictureBox MainPictureBoxIcone;
        private System.Windows.Forms.PictureBox MainPictureBoxMostraCor;
        private System.Windows.Forms.Button MainButtonExit;
        private System.Windows.Forms.Button MainButtonMinimize;
        private System.Windows.Forms.Button MainButton11;
        private System.Windows.Forms.Button MainButton12;
        private System.Windows.Forms.Button MainButton13;
        private System.Windows.Forms.Button MainButton23;
        private System.Windows.Forms.Button MainButton22;
        private System.Windows.Forms.Button MainButton21;
        private System.Windows.Forms.Button MainButton33;
        private System.Windows.Forms.Button MainButton32;
        private System.Windows.Forms.Button MainButton31;
        private System.Windows.Forms.Panel MainPanelBottom;
        private System.Windows.Forms.Label MainLabelStatus;
        private System.Windows.Forms.Label MainLabelPorta;
        private System.Windows.Forms.ComboBox MainComboBoxPorta;
        private System.Windows.Forms.Timer TimerVerifyUSB;
        private System.Windows.Forms.Timer TimerHandShakeUSB;
        private System.Windows.Forms.Timer TimerWin;
    }
}

