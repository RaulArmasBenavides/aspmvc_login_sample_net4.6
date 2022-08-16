using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using AppMVCLogin.DataBase;
using AppMVCLogin.Interfaces;
using AppMVCLogin.Util;

namespace AppMVCLogin.Models
{
    public class EmpleadoDao : IEmpleadoDataAccess
    {

        //IDBConnection conex ;
        //propiedad
        //variables       
        SqlCommand cmd = null;
        public string CadenaConexion { get; set; }
        public EmpleadoDao()
        {
            //conex = new AccesoDB(CadenaConexion);
            CadenaConexion = CustomXMLReader.leerConexion(); ;// ConfigurationManager.ConnectionStrings["neptuno"].ConnectionString;
        }

        public void create(Empleado t)
        {
            throw new NotImplementedException();
        }

        public void delete(Empleado t)
        {
            throw new NotImplementedException();
        }

        public Empleado findForId(Empleado t)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> readAll()
        {
            throw new NotImplementedException();
        }

        public void update(Empleado t)
        {
            throw new NotImplementedException();
        }

        public Empleado validar(string nombre, string apellido)
        {
            Empleado emp = null;
            try
            {
                using (var cn = Conexion.getConnection(CadenaConexion))
                {
                    var cmd = new SqlCommand("usp_validar_empleado", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cn.Open();
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        emp = new Empleado()
                        {
                            IdEmpleado=Convert.ToInt32(dr["IdEmpleado"]),
                            Apellidos=dr["Apellidos"].ToString(),
                            Nombre = dr["Nombre"].ToString()
                        };

                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emp;
        }
    }
}