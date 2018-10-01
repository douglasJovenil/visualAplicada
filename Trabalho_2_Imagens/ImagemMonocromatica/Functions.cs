using System.Windows.Forms;
using System.IO;
using System;

namespace ImagemMonocromatica
{
    class Functions
    {
        public OpenFileDialog createOpenFileDialog()
        {
            OpenFileDialog TmpOpenFileDialog = new OpenFileDialog();
            TmpOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
            TmpOpenFileDialog.Title = "Carregar Imagem";
            TmpOpenFileDialog.DefaultExt = "bmp";
            TmpOpenFileDialog.Filter = "Imagens Bitmap (*.bmp)|*.bmp|" +
                                        "Todos os Arquivos (*.*)|*.*";
            return TmpOpenFileDialog;
        }

        
    }
}