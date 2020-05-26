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
        }

        //propiedades

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
        public int Minutos
        {
            set
            {
                if (Minutos > 99)
                {
                    Minutos = 0;
                }
            }
            get
            {
                return Minutos;
            }
        }

        //eventos

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando se pulsa el reproductor")]
        public event System.EventHandler ClickEnPlayPause;

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando pasa 1 minuto de reproducción")]
        public event System.EventHandler DesbordaTiempo;

        //propiedades

        [Category("Timer")]
        [Description("Segundos de reproducción")]
        public int Segundos
        {
            set
            {
                if (Segundos > 59)
                {
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                    Segundos = Segundos % 60;
                }
            }
            get
            {
                return Segundos;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClickEnPlayPause?.Invoke(this, e);

            if (pictureBox1.Image == ImagePlay)
            {
                pictureBox1.Image = ImagePause;
            }

            else
            {
                pictureBox1.Image = ImagePlay;
            }
        }
    }
}
