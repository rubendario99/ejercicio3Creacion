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
        private int minutos;
        public int Minutos
        {
            set
            {
                if (minutos > 99)
                {
                    minutos = 0;
                }
                else
                {
                    minutos = value;
                }
            }
            get
            {
                return minutos;
            }
        }

        [Category("Texto")]
        [Description("Texto del label")]
        public string LblTxt
        {
            set
            {
                lbl.Text = value;
            }
            get
            {
                return lbl.Text;
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
        private int segundos;
        public int Segundos
        {
            set
            {
                segundos = value;
                if (segundos > 59)
                {
                    segundos = segundos % 60;
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                }
               
            }
            get
            {
                return segundos;
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
