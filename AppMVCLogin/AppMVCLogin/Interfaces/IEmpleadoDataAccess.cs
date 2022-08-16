using System.Collections.Generic;
using AppMVCLogin.Models;

namespace AppMVCLogin.Interfaces
{
    public interface IEmpleadoDataAccess
    {
        //definir las firmas
        void create(Empleado t);
        void update(Empleado t);
        void delete(Empleado t);
        Empleado findForId(Empleado t);
        List<Empleado> readAll();
    }
}
