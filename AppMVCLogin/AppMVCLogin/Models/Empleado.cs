using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AppMVCLogin.Models
{
    public class Empleado
    {
        //propiedades
        public int IdEmpleado { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "El Password es requerido."), DisplayName("Password")]
        public string Apellidos { get; set; }

        [DisplayName("Usuario")]
        [Required(ErrorMessage = "El usuario es requerido.")]
        public string Nombre { get; set; }

        public string LoginErrorMessage { get; set; }

    }
}