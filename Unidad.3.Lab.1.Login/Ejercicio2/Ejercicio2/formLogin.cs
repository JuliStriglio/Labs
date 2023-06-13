using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtusuario.Text == "Admin" && this.txtpass.Text == "admin")
            {
                //MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login",
                //  MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidepass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es ud. un usuario muy descuidado, haga memoria ", "Olvide mi contraseña",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
