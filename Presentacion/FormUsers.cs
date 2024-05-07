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



namespace Presentacion
{
    public partial class FormUsers : System.Windows.Forms.Form
    {
        ConexionSQLN cn= new ConexionSQLN();
        public FormUsers()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_nuevousuario_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =cn.ConsultaDT();
        }

        private void Btn_modusuario_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void Btn_eliminarusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
