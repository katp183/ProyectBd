using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySqlConnector;




namespace Datos
{
    public class ConexionSQL
    {
        /*
          
        static string conexionstring = "server= localhost; database= PuntodeVenta; " + "integrated security= true";
        MySqlConnection con = new MySqlConnection(conexionstring);

        public int consultalogin (string Usuario, string Contrasena)
        {
            int count;
            con.Open();
            string Query = "Select Count(*) From Persona where usuario = '"+Usuario+"'"" and contrasena = '"+Contrasena+"'";
           MySqlCommand cmd = new MySqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return 0;
        }
        */
        static string connectionString = "server=localhost;database=mydb;uid=root;pwd=18300923";
        MySqlConnection con = new MySqlConnection(connectionString);

        public int ConsultaLogin(string usuario, string contraseña)
        {
            int count ;
            con.Open();
            string query = "SELECT COUNT(*) FROM Doctores WHERE usuario = @usuario AND contraseña = @contraseña";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public DataTable ConsultaUsuariosDG()
        {
            string query = "select * from Doctores";
            MySqlCommand cmd = new MySqlCommand(@query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
           
        }
        public DataTable ConsultaUsuariosDG2()
        {
            string query = "select * from pacientes";
            MySqlCommand cmd = new MySqlCommand(@query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;

        }
        public int InsertarDoctores (string idDoctores, string usuario, string contraseña, string nombre, string apellido, string especialidad, string hospital, string direccionHospital, string telefono, string email)
        {
            
            int flag = 0;
            con.Open();
            string query = "insert into Doctores values ('"+idDoctores+ "','" + usuario + "','" + contraseña + "','" + nombre + "','" + apellido + "','" + especialidad + "','" + hospital + "','" + direccionHospital + "','" + telefono + "','" + email + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag =cmd.ExecuteNonQuery();
            con.Close();
            return flag;    
            
            

        }

        public int ModificarDoctor(string idDoctores, string usuario, string contraseña, string nombre, string apellido, string especialidad, string hospital, string direccionHospital, string telefono, string email)
        {
            int flag = 0;
            con.Open();
            string query = "UPDATE Doctores SET usuario='" + usuario + "', contraseña='" + contraseña + "', nombre='" + nombre + "', apellido='" + apellido + "', especialidad='" + especialidad + "', hospital='" + hospital + "', direccionHospital='" + direccionHospital + "', telefono='" + telefono + "', email='" + email + "' WHERE idDoctores='" + idDoctores + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }


        public int EliminarDoctor(string idDoctores)
        {
            int flag = 0;
            con.Open();
            string query = "DELETE FROM Doctores WHERE idDoctores= '" + idDoctores + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }


    }
}
