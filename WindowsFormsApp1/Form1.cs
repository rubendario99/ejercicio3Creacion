using System;
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
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecciona la carpeta con imágenes";
            folderBrowserDialog.ShowDialog();
            string rutaFotos = folderBrowserDialog.SelectedPath;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer1.TimerFuncionando)
            {
               //codigo para pasar de foto
            }
            else
            {
               //codigo para pausar
            }
        }
    }   
}
