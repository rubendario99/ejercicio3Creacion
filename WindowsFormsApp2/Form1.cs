using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        private bool reproduciendo = false;
        private string[] fotosPresentacion=null;
        private int cont = 0;

        public Form1()
        {
            InitializeComponent();
            mediaPlayer1.Minutos = 0;
            mediaPlayer1.Segundos = 0;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void mediaPlayer1_ClickEnPlayPause_1(object sender, EventArgs e)
        {
            reproduciendo = !reproduciendo;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fotosPresentacion != null)
            {
                if (reproduciendo)
                {
                    if (cont >= fotosPresentacion.Length)
                    {
                        cont = 0;
                    }
                    try
                    {
                        pictureBox1.Image = new Bitmap(fotosPresentacion[cont]);
                        mediaPlayer1.LblTxt = mediaPlayer1.Minutos + " : " + mediaPlayer1.Segundos;
                        mediaPlayer1.Segundos++;
                        cont++;
                    }
                    catch (System.ArgumentException)
                    {
                        cont++;
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                    }
                }
                else
                {
                    pictureBox1.Image = default;
                }
            }
        }
        private void mediaPlayer1_DesbordaTiempo(object sender, EventArgs e)
        {
            mediaPlayer1.Segundos = 0;
            mediaPlayer1.Minutos++;
        }
        private void btnDirectorio_Click_1(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Selecciona la carpeta con imágenes";
                folderBrowserDialog.ShowDialog();
                string rutaFotos = folderBrowserDialog.SelectedPath;
                try
                {
                fotosPresentacion = Directory.GetFiles(rutaFotos, "*png");

                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("No tienes permiso para acceder a este directorio");
                }
            }
            catch (System.ArgumentException)
            {

            }
        }
    }
}
