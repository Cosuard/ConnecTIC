using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form3 : Form
    {
        private string Path = @"C:\Users\maria\OneDrive\Pictures\Estudiantes";
        private bool hayDispositivos;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice micamara;

        public Form3()
        {
            InitializeComponent();
        }

        private void cerrarCamara()
        {
            if (micamara != null && micamara.IsRunning)
            {
                micamara.SignalToStop();
                micamara = null;
            }
        }
        public void cargarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                int i;
                hayDispositivos = true;
                for (i = 0; i < misDispositivos.Count; i++)
                    cmbDispositivos.Items.Add(misDispositivos[i].Name.ToString());
                cmbDispositivos.Text = "HD User Facing";
            }
            else
                hayDispositivos = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cargarDispositivos();
            cerrarCamara();
            string nombreVideo = misDispositivos[0].MonikerString;
            micamara = new VideoCaptureDevice(nombreVideo);
            micamara.NewFrame += new NewFrameEventHandler(Capturar);
            micamara.Start();          

        }

        private void grpRegistro_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmación Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void Capturar(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pctFotoEst.Image = Imagen;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarCamara();
        }
         
        private void btnCapturarFoto_Click(object sender, EventArgs e)
        {
            pctFotoCapturada.Visible = true;
            pctFotoCapturada.Image = pctFotoEst.Image;
            //pctFotoCapturada.Image.Save(Path + "Estudiante.jpg", ImageFormat.Jpeg);
        }

        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            cerrarCamara();
        }

        private void pctFotoCapturada_Click(object sender, EventArgs e)
        {
            
        }
    }
}
