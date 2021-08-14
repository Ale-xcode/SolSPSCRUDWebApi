using SPSCRUDWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SPSCRUDWebApi.Controllers
{
    /// <summary>
    /// Controladores que consumen las API's del lado del cliente.
    /// </summary>
    public class EmpController : Controller
    {
        // GET: Emp
        /// <summary>
        /// Devuelve una lista de todos los empledos que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            IEnumerable<spCrudEmpResult> empObj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44376/api/sps/");

            var ConsApi = hc.GetAsync("Obtener");
            ConsApi.Wait();

            var readData = ConsApi.Result;
            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<IList<spCrudEmpResult>>();
                displayData.Wait();
                empObj = displayData.Result;
            }
            return View(empObj);
        }

        /// <summary>
        /// Muestra el formulario de registro de los empleados
        /// </summary>
        /// <returns></returns>        
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Registro de un nuevo empleado
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(EmpClass model)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44376/api/sps/");

            var Insertemp = hc.PostAsJsonAsync<EmpClass>("Create", model);
            Insertemp.Wait();

            var readData = Insertemp.Result;
            if (readData.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");
        }

        /// <summary>
        /// Despliega los detalles de un empleado por medio de un identificador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Details(int id)
        {
            EmpClass empObj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44376/api/sps/");

            var Consumeapi = hc.GetAsync("ObtenerId/" + id.ToString());
            Consumeapi.Wait();

            var readData = Consumeapi.Result;
            if (readData.IsSuccessStatusCode)
            {
                var detailsEmp = readData.Content.ReadAsAsync<EmpClass>();
                detailsEmp.Wait();
                empObj = detailsEmp.Result;
            }
            return View(empObj);
        }

        /// <summary>
        /// Recibe un identificador para mostrar su registro del empleado registrado, para su edicion
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmpClass empObj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44376/api/sps/");

            var Consumeapi = hc.GetAsync("ObtenerId/" + id.ToString());
            Consumeapi.Wait();

            var readData = Consumeapi.Result;
            if (readData.IsSuccessStatusCode)
            {
                var detailsEmp = readData.Content.ReadAsAsync<EmpClass>();
                detailsEmp.Wait();
                empObj = detailsEmp.Result;
            }
            return View(empObj);
        }

        /// <summary>
        /// Realiza la edicion de un empleado
        /// </summary>
        /// <param name="model"></param>
        /// <param name= "id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(EmpClass model, int id)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44376/api/sps/");

            var Updateemp = hc.PutAsJsonAsync<EmpClass>("Put/" + id.ToString(), model);
            Updateemp.Wait();

            var Savedata = Updateemp.Result;
            if (Savedata.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        /// <summary>
        /// Realiza la baja de un empleado por medio de un identificador unico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44376/api/sps/");

            var DeleteEmp = hc.DeleteAsync("Delete/" + id.ToString());
            DeleteEmp.Wait();

            var Savedata = DeleteEmp.Result;
            if (Savedata.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}