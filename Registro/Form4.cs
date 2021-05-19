using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Registro
{
    public partial class FormValidacion : Form
    {
        public FormValidacion()
        {
            InitializeComponent();
        }

        //identificar los dispositivos de grabación conectados al equipo
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice capturarVideo;


        private void btnSalirVal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            else
                    return;
        }

        private void FormValidacion_Load(object sender, EventArgs e)
        {
            txtInfoEst.Text = "";

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cmbCamara.Items.Add(filterInfo.Name);
            cmbCamara.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 volver = new Form2();
            volver.Show();
            this.Hide();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            capturarVideo = new VideoCaptureDevice(filterInfoCollection[cmbCamara.SelectedIndex].MonikerString);
            capturarVideo.NewFrame += CaptureDevice_NewFrame;
            capturarVideo.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs) 
        {
            pctEscanear.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormValidacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capturarVideo.IsRunning)
                capturarVideo.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pctEscanear.Image != null) 
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result resultado = barcodeReader.Decode((Bitmap)pctEscanear.Image);
                if (resultado != null) 
                {                  
                    txtInfoEst.Text = resultado.ToString();
                    MessageBox.Show("Está autorizado para ingresar", "Autorización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Stop();
                    if (capturarVideo.IsRunning) 
                        capturarVideo.Stop();
                }
            }
        }
    }
}
