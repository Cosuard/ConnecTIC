using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnecTic
{
    public partial class FormValidacion : Form
    {
        public FormValidacion()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void FormValidacion_Load(object sender, EventArgs e)
        {
            txtCodEstudiantil.Text = "";
            txtNombre.Text = "";
            txtPrograma.Text = "";
            txtRol.Text = "";
        }
    }
}
