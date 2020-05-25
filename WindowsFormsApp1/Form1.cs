using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] fotosPresentacion;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Selecciona la carpeta con imágenes";
                folderBrowserDialog.ShowDialog();
                string rutaFotos = folderBrowserDialog.SelectedPath;
                fotosPresentacion = Directory.GetFiles(rutaFotos, "*png");
            }
            catch (System.ArgumentException)
            {

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fotosPresentacion != null)
            {
                if (mediaPlayer1.TimerFuncionando)
                {
                    pictureBox1.Image = new Bitmap(fotosPresentacion[cont]);
                    cont++;

                    if (cont >= fotosPresentacion.Length)
                    {
                        cont = 0;
                    }
                }
                else
                {
                    pictureBox1.Image = default;
                }
            }
        }
    }
}
