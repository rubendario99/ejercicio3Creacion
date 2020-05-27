namespace WindowsFormsApp2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaPlayer1 = new Ejercicio3Creacion.MediaPlayer();
            this.btnDirectorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 345);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mediaPlayer1
            // 
            this.mediaPlayer1.ImagePause = ((System.Drawing.Image)(resources.GetObject("mediaPlayer1.ImagePause")));
            this.mediaPlayer1.ImagePlay = ((System.Drawing.Image)(resources.GetObject("mediaPlayer1.ImagePlay")));
            this.mediaPlayer1.LblTxt = "00:00";
            this.mediaPlayer1.Location = new System.Drawing.Point(104, 126);
            this.mediaPlayer1.Minutos = 0;
            this.mediaPlayer1.Name = "mediaPlayer1";
            this.mediaPlayer1.Segundos = 0;
            this.mediaPlayer1.Size = new System.Drawing.Size(152, 203);
            this.mediaPlayer1.TabIndex = 0;
            this.mediaPlayer1.ClickEnPlayPause += new System.EventHandler(this.mediaPlayer1_ClickEnPlayPause_1);
            this.mediaPlayer1.DesbordaTiempo += new System.EventHandler(this.mediaPlayer1_DesbordaTiempo);
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(92, 351);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(174, 48);
            this.btnDirectorio.TabIndex = 2;
            this.btnDirectorio.Text = "Directorio";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDirectorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio3Creacion.MediaPlayer mediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDirectorio;
    }
}

