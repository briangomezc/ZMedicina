using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Persistence;
using Service;

namespace ZMedicina.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class HistorialsController : Controller
    {
        private readonly IHistorialService _HistorialService;

        public HistorialsController(IHistorialService HistorialService)
        {
            _HistorialService = HistorialService;


        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(
                _HistorialService.GetAll()
                );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(
                _HistorialService.Get(id)
             );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Historial Model)
        {
            return Json(
                _HistorialService.Add(Model)
             );

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Historial model)
        {
            model.HistorialID = id;
            return Json(
               _HistorialService.Update(model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Json(
              _HistorialService.Delete(id)
           );
        }
    }
}