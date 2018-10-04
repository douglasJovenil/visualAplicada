using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;


namespace ImagemMonocromatica
{
    public partial class MainPictureBoxLogo : Form
    {
        private int MainFormPositionX;
        private int MainFormPositionY;
        private bool MainMoveForm;
        private Image imagem;
        private string folderName;

        public MainPictureBoxLogo()
        {
            MainFormPositionY = Height / 2;
            MainFormPositionX = Width / 2;
            MainMoveForm = false;
            InitializeComponent();
        }

        private void MainButtonAbrir_Click(object sender, EventArgs e) // Abrir IMAGEM à ser convertida
        {
            OpenFileDialog TmpOpenFileDialog = new OpenFileDialog();
            TmpOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
            TmpOpenFileDialog.Title = "Carregar Imagem";
            TmpOpenFileDialog.DefaultExt = "bmp";
            TmpOpenFileDialog.Filter = "Imagens Bitmap (*.bmp)|*.bmp|" +
                                        "Todos os Arquivos (*.*)|*.*";

            if (TmpOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainPictureBoxOriginal.Image = new Bitmap(TmpOpenFileDialog.FileName);
            }
        }

        private void MainButtonConverter_Click(object sender, EventArgs e)
        {
            ConverterImagem();
        }

        private void MainButtonSair_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainButtonSalvar_Click(object sender, EventArgs e)
        {
         SalvaImagem();
        }

        private void MainButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainTrackBarSelecionaCor_Scroll(object sender, EventArgs e)
        {
            ChangeColorMainTackBarSelecionaCor();
        }

        private void ChangeColorMainTackBarSelecionaCor()
        {
            Color BackgroundOriginal = Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            int Red = MainTrackBarRed.Value;
            int Green = MainTrackBarGreen.Value;
            int Blue = MainTrackBarBlue.Value;
            Color SelectColor = Color.FromArgb(((int)(((byte)(Red)))), ((int)(((byte)(Green)))), ((int)(((byte)(Blue)))));
            MainPictureBoxMostraCor.BackColor = SelectColor;
        }

        private void MainButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainPanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainFormPositionX = e.X;
                MainFormPositionY = e.Y;
                MainMoveForm = true;
            }
        }

        private void MainPanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            MainMoveForm = false;
        }

        private void MainPanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainMoveForm)
            {
                Location = new Point(e.X + Location.X - MainFormPositionX, e.Y + Location.Y - MainFormPositionY);
            }
        }

        private void MainTrackBarGreen_Scroll(object sender, EventArgs e)
        {
            ChangeColorMainTackBarSelecionaCor();
        }

        private void MainTrackBarBlue_Scroll(object sender, EventArgs e)
        {
            ChangeColorMainTackBarSelecionaCor();
        }
        private void SalvaImagem() // Diálogo para SALVAR o resultado
        {
            try
            {
                Bitmap imagem = new Bitmap(MainPictureBoxModificado.Image);
                SaveFileDialog saveFiledialog = new SaveFileDialog()
                {
                    Title = "Salve o seu arquivo de imagem modificada",
                    InitialDirectory = "C:\\Área de Trabalho",
                    Filter = "Imagens(*.bmp; *.jpg; *.gif)| *.bmp; *.jpg; *.gif | Todos os Arquivos(*.*)| *.*",
                    RestoreDirectory = false
                };

                if (saveFiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string local = saveFiledialog.FileName;
                    imagem.Save(local, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve converter uma imagem para poder salvar.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

 
        private void ConverterImagem() //Processo de CONVERSÃO
        {
            try
            {
                Bitmap ChangedImage = (Bitmap)MainPictureBoxOriginal.Image.Clone();

                for (int i = 0; i < ChangedImage.Width; i++)
                {
                    for (int j = 0; j < ChangedImage.Height; j++)
                    {
                        Color TmpColor = ChangedImage.GetPixel(i, j);
                        Color SelectColor = MainPictureBoxMostraCor.BackColor;
                        int distance = (int)Math.Sqrt(Math.Pow(SelectColor.R - TmpColor.R, 2) + Math.Pow(SelectColor.G - TmpColor.G, 2) + Math.Pow(SelectColor.B - TmpColor.B, 2));
                        if (distance > MainTrackBarTolerancia.Value) // Mudar aqui
                        {
                            int scale = (int)(TmpColor.R * 0.3 + TmpColor.G * 0.59 + TmpColor.B * 0.11);
                            Color SetColor = Color.FromArgb(scale, scale, scale);
                            ChangedImage.SetPixel(i, j, SetColor);
                        }

                    }
                }
                Color SelectColor2 = MainPictureBoxMostraCor.BackColor;
                Console.WriteLine($"Red: {SelectColor2.R} Green: {SelectColor2.G} Blue: {SelectColor2.B}");
                MainPictureBoxModificado.Image = ChangedImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve carregar uma imagem ou diretorio para poder converter.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void MainButtonAbrirDiretorio_Click(object sender, EventArgs e) //Abrir DIRETÓRIO a ser convertido
        {
            OpenFileDialog Diretoriodialog = new OpenFileDialog();
            SaveFileDialog saveFiledialog = new SaveFileDialog();
            ArrayList listaArquivos = new ArrayList();

            try
            {

                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderName = folderBrowserDialog1.SelectedPath;
                }
             
                DirectoryInfo Dir = new DirectoryInfo(folderName);
                FileInfo[] Files = Dir.GetFiles("*.bmp", SearchOption.AllDirectories);
                //Busca o nome de todos os arquivos .bmp e salva no array
                foreach (FileInfo File in Files)
                {
                    listaArquivos.Add(File.FullName);
                    MainPictureBoxOriginal.Image = Image.FromFile(File.FullName);
                    ConverterImagem();
                    SalvaImagem();
                }
                
            }
            catch(Exception)
            {
                {
                    MessageBox.Show("Erro ao tentar abrir o diretório escolhido.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Abrir LINK pela imagem da UCS
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void VisitLink()
        {
            //Chama o método Process.Start para abrir pelo browser padrão   
            //Com a URL:  
            System.Diagnostics.Process.Start("https://www.ucs.br/site");
        }
    }  
}
