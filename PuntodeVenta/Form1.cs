using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Presentacion;

namespace PuntodeVenta
{
    public partial class Login : System.Windows.Forms.Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txt_Ususario.Text, txt_Contrasena.Text) == 1)
            {
                MessageBox.Show("El Usuario ha sido Encontrado ");
                this.Hide();
                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("El usuario no fue encontrado");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Ususario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Contrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
