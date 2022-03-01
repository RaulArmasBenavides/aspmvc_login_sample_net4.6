using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppMVCLogin.DataBase
{
   public class Conexion
    {
       public static SqlConnection getConnection()
       {
           SqlConnection cn = new SqlConnection("database=Neptuno;server=.;integrated security=true");
           return cn;
       }       
    }
}
