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
    [Route("api/[controller]")]
    public class MedicosController : Controller
    {
        private readonly IMedicoService _MedicoService;

        public MedicosController(IMedicoService MedicoService)
        {
            _MedicoService = MedicoService;


        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(
                _MedicoService.GetAll()
                );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(
                _MedicoService.Get(id)
             );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Medico Model)
        {
            return Json(
                _MedicoService.Add(Model)
             );

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Medico model)
        {
            return Json(
               _MedicoService.Update(model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Json(
              _MedicoService.Delete(id)
           );
        }


    }
}