using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using AppMVCLogin.DataBase;
using AppMVCLogin.Interfaces;
using AppMVCLogin.Util;
using System.Configuration;

namespace AppMVCLogin.Models
{
    public class EmpleadoDao : IEmpleadoDataAccess
    { 
        SqlCommand cmd = null;
        public string CadenaConexion { get; set; }
        public EmpleadoDao()
        {
            CadenaConexion =  ConfigurationManager.ConnectionStrings["ModelNeptuno"].ConnectionString;
        }

        public void create(Empleado t)
        {
            throw new NotImplementedException();
        }

        public void delete(Empleado t)
        {
            throw new NotImplementedException();
        }

        public Empleado findById(Empleado t)
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

        public Empleado validarLogin(string nombre, string apellido)
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
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        emp = new Empleado()
                        {
                            IdEmpleado=Convert.ToInt32(dr["IdEmpleado"]),
                            Apellidos=dr["Apellidos"].ToString(),
                            Nombre = dr["Nombre"].ToString()
                        };

                    }
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