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
    public class PacientesController : Controller
    {
        private readonly IPacienteService _PacienteService;

        public PacientesController(IPacienteService PacienteService)
        {
            _PacienteService = PacienteService;


        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(
                _PacienteService.GetAll()
                );
        }

        // GET api/values
        [HttpGet("{Nombre}")]
        public IActionResult GetFiltro(string Nombre)
        {
            return Json(
                _PacienteService.GetFiltro(Nombre)
                );
        }


        // GET api/values
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(
                _PacienteService.Get(id)
             );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Paciente Model)
        {
            return Json(
                _PacienteService.Add(Model)
             );
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Paciente model)
        {
            model.PacienteID = id;
            return Json(
               _PacienteService.Update(model)
            );
        }

        // DELETE api/values
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Json(
              _PacienteService.Delete(id)
           );
        }


    }
    
}