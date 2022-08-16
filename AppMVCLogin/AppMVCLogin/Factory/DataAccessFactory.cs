using AppMVCLogin.Interfaces;
using AppMVCLogin.Models;

namespace AppMVCLogin.Factory
{
    abstract class DataAccessFactory
    {
        public static IEmpleadoDataAccess GetProductDataAccessObj()
        {
            return new EmpleadoDao();
        }

        public static IEmpleadoDataAccess GetProductDataAccessObj2()
        {
            return new EmpleadoDao();
        }
    }
}