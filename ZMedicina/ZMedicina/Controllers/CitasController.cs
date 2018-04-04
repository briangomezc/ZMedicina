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
    public class CitasController : Controller
    {
        private readonly ICitaService _CitaService;

        public CitasController(ICitaService CitaService)
        {
            _CitaService = CitaService;


        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(
                _CitaService.GetAll()
                );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(
                _CitaService.Get(id)
             );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult CitaPaciente(int id)
        {
            return Json(
                _CitaService.PacienteCita(id)
             );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult CitaMedico(int id)
        {
            return Json(
                _CitaService.MedicoCita(id)
             );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Cita Model)
        {
            return Json(
                _CitaService.Add(Model)
             );

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Cita model)
        {
            model.CitaID = id;
            return Json(
               _CitaService.Update(model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Json(
              _CitaService.Delete(id)
           );
        }

        [HttpPost]
        public IActionResult Login([FromBody] Cita cita)
        {
            return Json(
                _CitaService.Login(cita)
                );
        }

        

    }
}