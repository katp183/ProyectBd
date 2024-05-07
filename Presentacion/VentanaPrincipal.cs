using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VentanaPrincipal : System.Windows.Forms.Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarios_Btn_Click(object sender, EventArgs e)
        {
            
            FormUsers v1 = new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();



        }

        private void productos_BTN_Click(object sender, EventArgs e)
        {
            FormUsers v1 = new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormDoctores v2 = new FormDoctores();
            this.Hide();
            v2.ShowDialog();
            this.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPacientes v3 = new FormPacientes();
            this.Hide();
            v3.ShowDialog();
            this.Show();
        }
    }
}
