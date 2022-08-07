using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Form1 : Form
    {
        int vl = 50;
        public OpenFileDialog archivo = new OpenFileDialog();
        int play = 0;
        public string Direccion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            Volumen.Visible = true; 
        }

        private void Volumen_MouseLeave(object sender, EventArgs e)
        {
            Volumen.Visible = true;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if (play == 1)
            {
                AbrirMusica();
                play = 2;
            }
            else if (play == 2)
            {
                Media.Ctlcontrols.pause();
                Tiempo.Stop();

                Iniciar.BackgroundImage = Properties.Resources.omitir;
                play = 3;
            }
            else if (play == 3)
            {
                Media.Ctlcontrols.play();
                Tiempo.Start();

                Iniciar.BackgroundImage = Properties.Resources.pausa;
                play = 2;
            }

        }
        public void AbrirMusica()
        {
            try
            {

                Media.URL = @"" + Direccion;
                Media.Ctlcontrols.play();

                this.Visible = true;
                Tiempo.Start();

                Duracion.Enabled = true;

                Iniciar.BackgroundImage = Properties.Resources.pausa;

            }
            catch
            {


            }


        }
        // metodo para buscar el archivo multimedia para abrir
        public void AbrirArchivo() 
        {

            archivo.Filter = "Archivo files|*.mp3;*.mp4;.*;";
            DialogResult dres1 = archivo.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            Direccion = archivo.FileName;
            Titulo.Text = archivo.SafeFileName;

        }

        private void Duracion_ValueChanged(object sender, decimal value)
        {
            Duracion.Maximum = (int)Media.currentMedia.duration;

            if (Duracion.Value == (int)Media.Ctlcontrols.currentPosition)
            {

            }
            else
            {

                Media.Ctlcontrols.currentPosition = Duracion.Value;

            }
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            try
            {
                Duracion.Value = (int)Media.Ctlcontrols.currentPosition;
                TiempoInicial.Text = Media.Ctlcontrols.currentPositionString;
                TiempoFinal.Text = Media.currentMedia.durationString;
            }
            catch
            {


            }
        }

        private void Retornar_Click(object sender, EventArgs e)
        {
            if ((Duracion.Value = Duracion.Value - 15) < 0)
            {
                Duracion.Value = 0;
            }
            else
            {
                Duracion.Value = Duracion.Value - 15;
            }

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();

                if (Direccion != "")
                {
                    play = 2;
                    AbrirMusica();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Volumen_ValueChanged(object sender, decimal value)
        {
            Media.settings.volume = Volumen.Value;
            NumeroVolumen.Text = Media.settings.volume.ToString();
        }

        private void Adelantar_Click(object sender, EventArgs e)
        {
            Duracion.Value = Duracion.Value + 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumeroVolumen.Text = (Volumen.Value = Media.settings.volume = vl).ToString();
            this.Media.uiMode = "none";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void contactanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puedes enviarnos correo a la siguiente direccion elihantejada@gmail.com");
        }
    }
 
}
