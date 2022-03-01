using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using AppMVCLogin.DataBase;

namespace AppMVCLogin.Models
{
    public class EmpleadoDao
    {
        public Empleado validar(string nombre, string apellido)
        {
            Empleado emp = null;
            try
            {
                using (var cn = Conexion.getConnection())
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