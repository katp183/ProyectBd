using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string user, string pass)
        {
            return cn.ConsultaLogin(user, pass);


        }
        public DataTable ConsultaDT()
        {
            return cn.ConsultaUsuariosDG();
        }
        public DataTable ConsultaDT2()
        {
            return cn.ConsultaUsuariosDG2();
        }
        public int InsertarDoctores(string idDoctores,string usuario, string contraseña, string nombre, string apellido, string especialidad, string hospital, string direccionHospital, string telefono, string email)
        {
            return cn.InsertarDoctores(idDoctores,usuario,contraseña,nombre,apellido,especialidad,hospital,direccionHospital,telefono,email);

        }
        public int ModificarDoctor(string idDoctores, string usuario, string contraseña, string nombre, string apellido, string especialidad, string hospital, string direccionHospital, string telefono, string email)
        {
            return cn.ModificarDoctor(idDoctores, usuario,contraseña, nombre, apellido, especialidad, hospital, direccionHospital, telefono, email);
        }
        public int EliminarDoctor(string idDoctores)
        {
            return cn.EliminarDoctor(idDoctores);
        }
    }
}
