using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPSCRUDWebApi.Controllers
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController'
    public class ValuesController : ApiController
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController'
    {
        // GET api/values
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Get()'
        public IEnumerable<string> Get()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Get()'
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Get(int)'
        public string Get(int id)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Get(int)'
        {
            return "value";
        }

        // POST api/values
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Post(string)'
        public void Post([FromBody] string value)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Post(string)'
        {
        }

        // PUT api/values/5
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Put(int, string)'
        public void Put(int id, [FromBody] string value)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Put(int, string)'
        {
        }

        // DELETE api/values/5
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Delete(int)'
        public void Delete(int id)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ValuesController.Delete(int)'
        {
        }
    }
}
