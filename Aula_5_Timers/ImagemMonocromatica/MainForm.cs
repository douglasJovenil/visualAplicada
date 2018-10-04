using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.IO;
using System;

namespace ImagemMonocromatica
{
    public partial class MainPictureBoxLogo : Form
    {
        private int MainFormPositionX;
        private int MainFormPositionY;
        private bool MainMoveForm;
        private string FolderName;
        private int IndexImage;
        private int SizeIterImage;

        public MainPictureBoxLogo()
        {
            MainFormPositionY = Height / 2;
            MainFormPositionX = Width / 2;
            MainMoveForm = false;
            IndexImage = 0;
            SizeIterImage = 0;
            InitializeComponent();
        }

        private void MainButtonConverter_Click(object sender, EventArgs e)
        {
            MainPictureBoxModificado.Image = MainPictureBoxOriginal.Image;
            if (MainCheckBoxConverterTudo.Checked && !MainCheckBoxConverterLinha.Checked && !MainCheckBoxColuna.Checked)
            {
                ConverterImagemTudo();
            } else if (!MainCheckBoxConverterTudo.Checked && MainCheckBoxConverterLinha.Checked && !MainCheckBoxColuna.Checked)
            {
                SizeIterImage = MainPictureBoxModificado.Image.Height;
                MainTimerTempo.Enabled = true;
            } else if (!MainCheckBoxConverterTudo.Checked && !MainCheckBoxConverterLinha.Checked && MainCheckBoxColuna.Checked)
            {
                SizeIterImage = MainPictureBoxModificado.Image.Width;
                MainTimerTempo.Enabled = true;
            }
        }

        private void MainTimerTempo_Tick(object sender, EventArgs e)
        {
            if (IndexImage < SizeIterImage && !MainCheckBoxConverterTudo.Checked && MainCheckBoxConverterLinha.Checked && !MainCheckBoxColuna.Checked)
            {
                ConverterImagemLinha();
            } else if (IndexImage < SizeIterImage && !MainCheckBoxConverterTudo.Checked && !MainCheckBoxConverterLinha.Checked && MainCheckBoxColuna.Checked)
            {
                ConverterImagemColuna();
            }
            else
            {
                IndexImage = 0;
                MainTimerTempo.Enabled = false;
            }
        }

        private void ConverterImagemLinha()
        {
            try
            {
                Bitmap ChangedImage = (MainPictureBoxModificado.Image == null) ? (Bitmap)MainPictureBoxOriginal.Image.Clone() : (Bitmap)MainPictureBoxModificado.Image.Clone();

                for (int i = 0; i < ChangedImage.Width; i++)
                {
                    Color TmpColor = ChangedImage.GetPixel(i, IndexImage);
                    Color SelectColor = MainPictureBoxMostraCor.BackColor;
                    int distance = (int)Math.Sqrt(Math.Pow(SelectColor.R - TmpColor.R, 2) + Math.Pow(SelectColor.G - TmpColor.G, 2) + Math.Pow(SelectColor.B - TmpColor.B, 2));
                    if (distance > MainTrackBarTolerancia.Value)
                    {
                        int scale = (int)(TmpColor.R * 0.3 + TmpColor.G * 0.59 + TmpColor.B * 0.11);
                        Color SetColor = Color.FromArgb(scale, scale, scale);
                        ChangedImage.SetPixel(i, IndexImage, SetColor);
                    }
                }
                MainPictureBoxModificado.Image = ChangedImage;
                IndexImage++;
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve carregar uma imagem ou diretorio para poder converter.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ConverterImagemColuna()
        {
            try
            {
                Bitmap ChangedImage = (MainPictureBoxModificado.Image == null) ? (Bitmap)MainPictureBoxOriginal.Image.Clone() : (Bitmap)MainPictureBoxModificado.Image.Clone();

                for (int i = 0; i < ChangedImage.Height; i++)
                {
                    Color TmpColor = ChangedImage.GetPixel(IndexImage, i);
                    Color SelectColor = MainPictureBoxMostraCor.BackColor;
                    int distance = (int)Math.Sqrt(Math.Pow(SelectColor.R - TmpColor.R, 2) + Math.Pow(SelectColor.G - TmpColor.G, 2) + Math.Pow(SelectColor.B - TmpColor.B, 2));
                    if (distance > MainTrackBarTolerancia.Value)
                    {
                        int scale = (int)(TmpColor.R * 0.3 + TmpColor.G * 0.59 + TmpColor.B * 0.11);
                        Color SetColor = Color.FromArgb(scale, scale, scale);
                        ChangedImage.SetPixel(IndexImage, i, SetColor);
                    }
                }
                MainPictureBoxModificado.Image = ChangedImage;
                IndexImage++;
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve carregar uma imagem ou diretorio para poder converter.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ConverterImagemTudo()
        {
            try
            {
                Bitmap ChangedImage = (MainPictureBoxModificado.Image == null) ? (Bitmap)MainPictureBoxOriginal.Image.Clone() : (Bitmap)MainPictureBoxModificado.Image.Clone();

                for (int i = 0; i < ChangedImage.Width; i++)
                {
                    for (int j = 0; j < ChangedImage.Height; j++)
                    {
                        Color TmpColor = ChangedImage.GetPixel(i, j);
                        Color SelectColor = MainPictureBoxMostraCor.BackColor;
                        int distance = (int)Math.Sqrt(Math.Pow(SelectColor.R - TmpColor.R, 2) + Math.Pow(SelectColor.G - TmpColor.G, 2) + Math.Pow(SelectColor.B - TmpColor.B, 2));
                        if (distance > MainTrackBarTolerancia.Value)
                        {
                            int scale = (int)(TmpColor.R * 0.3 + TmpColor.G * 0.59 + TmpColor.B * 0.11);
                            Color SetColor = Color.FromArgb(scale, scale, scale);
                            ChangedImage.SetPixel(i, j, SetColor);
                        }
                    }
                }
                MainPictureBoxModificado.Image = ChangedImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve carregar uma imagem ou diretorio para poder converter.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void MainButtonAbrir_Click(object sender, EventArgs e)
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

        private void SalvaImagem()
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

        private void MainButtonAbrirDiretorio_Click(object sender, EventArgs e)
        {
            OpenFileDialog Diretoriodialog = new OpenFileDialog();
            SaveFileDialog saveFiledialog = new SaveFileDialog();
            ArrayList listaArquivos = new ArrayList();

            try
            {

                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FolderName = folderBrowserDialog1.SelectedPath;
                }
             
                DirectoryInfo Dir = new DirectoryInfo(FolderName);
                FileInfo[] Files = Dir.GetFiles("*.bmp", SearchOption.AllDirectories);
                foreach (FileInfo File in Files)
                {
                    listaArquivos.Add(File.FullName);
                    MainPictureBoxOriginal.Image = Image.FromFile(File.FullName);
                    ConverterImagemTudo();
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

        private void MainPictureBoxLogoUCS_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.ucs.br/site");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void MainTrackBarTempo_Scroll(object sender, EventArgs e)
        {
            MainTimerTempo.Interval = MainTrackBarTempo.Value;
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

        private void MainButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void ChangeColorMainTackBarSelecionaCor()
        {
            int Red = MainTrackBarRed.Value;
            int Green = MainTrackBarGreen.Value;
            int Blue = MainTrackBarBlue.Value;
            Color SelectColor = Color.FromArgb(((int)(((byte)(Red)))), ((int)(((byte)(Green)))), ((int)(((byte)(Blue)))));
            MainPictureBoxMostraCor.BackColor = SelectColor;
        }

        private void MainTrackBarRed_Scroll(object sender, EventArgs e)
        {
            ChangeColorMainTackBarSelecionaCor();
        }

        private void MainTrackBarGreen_Scroll(object sender, EventArgs e)
        {
            ChangeColorMainTackBarSelecionaCor();
        }

        private void MainTrackBarBlue_Scroll(object sender, EventArgs e)
        {
            ChangeColorMainTackBarSelecionaCor();
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
    }  
}
