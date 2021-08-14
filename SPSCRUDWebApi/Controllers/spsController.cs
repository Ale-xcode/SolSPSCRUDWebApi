using SPSCRUDWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPSCRUDWebApi.Controllers
{
    /// <summary>
    /// Controladores de las API's que se encuentran conectados a BD para devolver una accion. 
    /// </summary>
    public class spsController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();

        /// <summary>
        /// Obtiene una lista general de empleados
        /// </summary>    
        /// <response code="200">Ok. Obtiene el listado</response>
        /// <response code="404">Notfound No se ha encontrado el objeto</response>
        [AcceptVerbs("GET")]
        public IHttpActionResult Obtener()
        {
            var lstEmp = db.spCrudEmp(null, null, null, null, null, "Select").ToList();
            db.Dispose();
            return Ok(lstEmp);
        }

        /// <summary>
        /// Realiza un reistro de un empleado mediante un procedimiento almacenado
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Ok. Registra un nuevo empleado</response>
        /// <response code="404">Notfound No se ha encontrado el objeto</response>
        [AcceptVerbs("POST")]
        public IHttpActionResult Create([FromBody] EmpClass model)
        {
            if (!ModelState.IsValid)
                return NotFound();
            var Insertemp = db.spCrudEmp(0, model.Nombre, model.Email, model.Puesto, model.Salario, "Insert").ToList();
            db.SubmitChanges();
            db.Dispose();
            return Ok(Insertemp);
        }

        /// <summary>
        /// Despliega a detalle por medio de un id informacion de un empleado mediante un procedimiento almacenado
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Ok. Obtiene un empleado</response>
        /// <response code="404">Notfound No se ha encontrado el objeto</response>
        [AcceptVerbs("GET")]
        public IHttpActionResult ObtenerId(int id)
        {
            var Obtenerlst = db.spCrudEmp(id, null, null, null, 0, "SelectId").FirstOrDefault();
            db.Dispose();
            return Ok(Obtenerlst);
        }

        /// <summary>
        /// Realiza una actualizacion de datos de un empleado mediante un procedimiento almacenado
        /// </summary>
        /// <param name="model"></param>        
        /// <param name="id"></param>
        /// <response code="200">Ok. Devuelve la actualizacion hecha</response>
        /// <response code="404">Notfound No se ha encontrado el objeto</response>
        [AcceptVerbs("PUT")]
        public IHttpActionResult Put([FromBody] EmpClass model, int id)
        {
            if (!ModelState.IsValid)
                return NotFound();
            var UpdateEmp = db.spCrudEmp(id, model.Nombre, model.Email, model.Puesto, model.Salario, "Update").FirstOrDefault();
            db.SubmitChanges();
            db.Dispose();
            return Ok(UpdateEmp);
        }

        /// <summary>
        /// Realiza una eliminacion por un id de un empleado mediante un procedimiento almacenado 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Ok. Elimina en empleado</response>
        /// <response code="404">Notfound No se ha encontrado el objeto</response>       
        public IHttpActionResult Delete(int id)
        {
            var deleteEmp = db.spCrudEmp(id, null, null, null, null, "Delete").Select(x => new EmpClass()
            {
                IdEmpleado = x.IdEmpleado,
                Nombre = x.Nombre,
                Email = x.Email,
                Puesto = x.Puesto,
                Salario = x.Salario
            }).FirstOrDefault<EmpClass>();
            db.SubmitChanges();
            db.Dispose();
            return Ok();
        }
    }
}
