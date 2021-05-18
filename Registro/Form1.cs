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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Usuario;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
                if (txtUsuario.Text == "Admin" && txtPassword.Text == "12345")
                {
                    Usuario = this.txtUsuario.Text;
                    Form2 validar = new Form2();
                    validar.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmación Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
