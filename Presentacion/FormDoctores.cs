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
    public partial class FormDoctores : System.Windows.Forms.Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public FormDoctores()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //usuario,contraseña,nombre,apellido,especialidad,hospital,direcciónDelHospital,telefono,email
            cn.InsertarDoctores(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text);
            //dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.ModificarDoctor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cn.EliminarDoctor(textBox1.Text);
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
