using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SPSCRUDWebApi.Models
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass'
    public class EmpClass
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass'
    {
        [IgnoreDataMember]
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.IdEmpleado'
        public int IdEmpleado { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.IdEmpleado'

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Nombre'
        public string Nombre { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Nombre'
        
        [Required(ErrorMessage = "El campo email es obligatorio")]
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Email'
        public string Email { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Email'

        [Required(ErrorMessage = "El campo puesto es obligatorio")]
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Puesto'
        public string Puesto { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Puesto'

        [Required(ErrorMessage = "El campo salario es obligatorio")]
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Salario'
        public int Salario { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EmpClass.Salario'
    }
}