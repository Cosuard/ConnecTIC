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
    public partial class FormValidacion : Form
    {
        public FormValidacion()
        {
            InitializeComponent();
        }

        private void btnSalirVal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void FormValidacion_Load(object sender, EventArgs e)
        {
            txtCodEst.Text = "";
            txtNombreVal.Text = "";
            txtPrograma.Text = "";
            txtRol.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 volver = new Form2();
            volver.Show();
            this.Hide();
        }
    }
}
