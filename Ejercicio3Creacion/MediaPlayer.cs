using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Creacion
{
    public partial class MediaPlayer : UserControl
    {
        public MediaPlayer()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ImagePlay = Properties.Resources.play;
            this.ImagePause = Properties.Resources.pause;
            TimerFuncionando = false;
        }

        [Category("Funcionamiento")]
        [Description("True si el timer está enabled")]
        public bool TimerFuncionando { set; get; }

        private Image imagePlay;
        [Category("Design")]
        [Description("Imagen del play")]
        public Image ImagePlay
        {
            set
            {
                imagePlay = value;
                pictureBox1.Image = ImagePlay;
                this.Refresh();
            }
            get
            {
                return imagePlay;
            }
        }

        private Image imagePause;
        [Category("Design")]
        [Description("Imagen del pause")]
        public Image ImagePause
        {
            set
            {
                imagePause = value;
                Refresh();
            }
            get
            {
                return imagePause;
            }
        }

        [Category("Timer")]
        [Description("Minutos de reproducción")]
        public int Minutos { set; get; }

        [Category("Timer")]
        [Description("Segundos de reproducción")]
        public int Segundos { set; get; }

        //eventos

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando se pulsa el reproductor")]
        public event System.EventHandler ClickEnPlayPause;

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando pasa 1 minuto de reproducción")]
        public event System.EventHandler DesbordaTiempo;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == ImagePlay)
            {
                pictureBox1.Image = ImagePause;
                timer1.Enabled = true;
                TimerFuncionando = true;
            }
            else
            {
                timer1.Enabled = false;
                pictureBox1.Image = ImagePlay;
                TimerFuncionando = false;
            }
            ClickEnPlayPause?.Invoke(this, e);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Segundos++;

            if (Segundos > 59)
            {
                Minutos++;
                Segundos = 0;
                DesbordaTiempo?.Invoke(this, e);
            }
            if (Minutos > 99)
            {
                Minutos = 0;
            }
            if (Minutos != 0)
            {
                lbl.Text = Minutos + " m " + Segundos + " s";
            }
            else
            {
                lbl.Text = Segundos + " s";
            }

        }
    }
}
