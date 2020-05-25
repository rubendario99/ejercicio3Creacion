namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaPlayer1 = new Ejercicio3Creacion.MediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(91, 309);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(132, 38);
            this.btnDirectorio.TabIndex = 1;
            this.btnDirectorio.Text = "Elegir Directorio";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(351, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 303);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mediaPlayer1
            // 
            this.mediaPlayer1.ImagePause = ((System.Drawing.Image)(resources.GetObject("mediaPlayer1.ImagePause")));
            this.mediaPlayer1.ImagePlay = ((System.Drawing.Image)(resources.GetObject("mediaPlayer1.ImagePlay")));
            this.mediaPlayer1.Location = new System.Drawing.Point(91, 35);
            this.mediaPlayer1.Minutos = 0;
            this.mediaPlayer1.Name = "mediaPlayer1";
            this.mediaPlayer1.Segundos = 0;
            this.mediaPlayer1.Size = new System.Drawing.Size(152, 203);
            this.mediaPlayer1.TabIndex = 3;
            this.mediaPlayer1.TimerFuncionando = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mediaPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDirectorio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Ejercicio3Creacion.MediaPlayer mediaPlayer1;
        private System.Windows.Forms.Timer timer1;
    }
}

