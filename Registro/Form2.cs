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
            grpE.Visible = false;
        }

        private void rdEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEstudiante.Checked)
            {
                grpFormulario.Visible = true;
                grpFormulario2.Visible = false;
            }
        }

        private void radEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEmpleado.Checked)
            {
                grpFormulario2.Visible = true;
                grpFormulario.Visible = false;
            }
        }

        private void grpE_Enter(object sender, EventArgs e)
        {

            if (rdEstudiante.Checked)
            {
                grpFormulario.Visible = true;
                grpFormulario2.Visible = false;
            }
            else if (rdEmpleado.Checked)
            {
                grpFormulario2.Visible = true;
                grpFormulario.Visible = false;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           String contenido = txtNombreEst.Text + " " + txtApellidoEst.Text + "\n" + cmbIdentificacionEst.SelectedItem + " " + txtIdentificacionEst.Text + "\n" + txtCorreoEst.Text + "\n" + txtCodEst.Text + "\n" + cmbProgramaEst.SelectedItem;
           QRCodeGenerator generarQR = new QRCodeGenerator();
           QRCodeData datosQR = generarQR.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
           QRCode codigoQR = new QRCode(datosQR);

           Bitmap imagenQR = codigoQR.GetGraphic(2, Color.DarkBlue, Color.White, true);
            pctCodQR.Image = imagenQR; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FormValidacion validacion = new FormValidacion();
            validacion.Show();
            this.Hide();
        }
    }
}
