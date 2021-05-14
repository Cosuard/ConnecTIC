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
           
        }

        private void radEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void grpE_Enter(object sender, EventArgs e)
        {
            if (rdEstudiante.Checked)
            {
                grpFormulario.Visible = false;
            }
            else if (rdEmpleado.Checked)
            {
                grpFormulario.Visible = false;
            }
        }
    }
}
