using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblUsuario.Text = Form1.Usuario;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblFecha.Text = fecha.ToString("yyyy/MM/dd");
            lblHora.Text = fecha.ToString("HH:mm");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            grpE.Visible = true;
            cmbLista.Visible = false;
            grpFormulario.Visible = false;
            grpFormulario2.Visible = false;
            grpFormulario3.Visible = false;
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmación Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            grpFormulario.Visible = false;
            cmbLista.Visible = true;
            grpE.Visible = true;
            grpFormulario2.Visible = false;
        }

        private void Capturar(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pctFotoEst.Image = Imagen;
        }

        private void rdEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEstudiante.Checked)
            {
                grpFormulario.Visible = true;
                grpFormulario2.Visible = false;
                grpFormulario3.Visible = false;
            }
        }

        private void radEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEmpleado.Checked)
            {
                grpFormulario2.Visible = true;
                grpFormulario.Visible = false;
                grpFormulario3.Visible = false;
            }
        }

        private void grpE_Enter(object sender, EventArgs e)
        {
            if (rdEstudiante.Checked)
            {
                grpFormulario.Visible = true;
                grpFormulario2.Visible = false;
                grpFormulario3.Visible = false;
            }
            else if (rdEmpleado.Checked)
            {
                grpFormulario2.Visible = true;
                grpFormulario.Visible = false;
                grpFormulario3.Visible = false;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           String contenido = txtNombreEst.Text + " " + txtApellidoEst.Text + "\n" + cmbIdentificacionEst.SelectedItem + " " + txtIdentificacionEst.Text + "\n" + txtCorreoEst.Text + "\n" + txtCodEst.Text + "\n" + cmbProgramaEst.SelectedItem;
           QRCodeGenerator generarQR = new QRCodeGenerator();
           QRCodeData datosQR = generarQR.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
           QRCode codigoQR = new QRCode(datosQR);

           Bitmap imagenQR = codigoQR.GetGraphic(3, Color.DarkBlue, Color.White, true);
            pctCodQR.Image = imagenQR; 
        }

        private void grpFormulario_Enter(object sender, EventArgs e)
        {
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            Form3 TomarFoto = new Form3();
            TomarFoto.Show();
        }

        private void pctFotoEst_Click(object sender, EventArgs e)
        {
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar2_Click(object sender, EventArgs e)
        {
            String contenido = txtNombres.Text + " " + txtApellidos.Text + "\n" + cmbTiposIden.SelectedItem + " " + txtNumIde.Text + "\n" + txtCorreoP.Text + "\n" + cmbArea.SelectedItem;
            QRCodeGenerator generarQR = new QRCodeGenerator();
            QRCodeData datosQR = generarQR.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
            QRCode codigoQR = new QRCode(datosQR);

            Bitmap imagenQR = codigoQR.GetGraphic(3, Color.DarkBlue, Color.White, true);
            pctCodEmp.Image = imagenQR;
        }

        private void btnTomarFoto2_Click(object sender, EventArgs e)
        {
            Form3 TomarFoto = new Form3();
            TomarFoto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpE.Visible = false;
            cmbLista.Visible = false;
            grpFormulario.Visible = false;
            grpFormulario2.Visible = false;
            grpFormulario3.Visible = true;
        }

        private void btnGenerar3_Click(object sender, EventArgs e)
        {
            String contenido = txtDescripcion.Text + "\n" + nmrCantidad.Value + "\n" + cmbArea2.SelectedItem;
            QRCodeGenerator generarQR = new QRCodeGenerator();
            QRCodeData datosQR = generarQR.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
            QRCode codigoQR = new QRCode(datosQR);

            Bitmap imagenQR = codigoQR.GetGraphic(3, Color.DarkBlue, Color.White, true);
            pctCodInv.Image = imagenQR;
        }
    }
}