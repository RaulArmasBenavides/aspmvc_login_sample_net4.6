using System.Collections.Generic;
using AppMVCLogin.Models;

namespace AppMVCLogin.Interfaces
{
    public interface IEmpleadoDataAccess
    {
        void create(Empleado t);
        void update(Empleado t);
        void delete(Empleado t);
        Empleado findById(Empleado t);
        List<Empleado> readAll();
    }
}
