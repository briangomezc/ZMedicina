using System;
using System.Collections.Generic;
using System.IO;
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
        [HttpPost]
        public IActionResult Login([FromBody] Paciente paciente)
        {
            return Json(
                _PacienteService.Login(paciente)
                );
        }

        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] FileUploadViewModel model, [FromForm] string Cedula, [FromForm]string Pass, [FromForm] string Nombre
            , [FromForm]string Apellidos, [FromForm]string Fecha, [FromForm]string Email, [FromForm]string sexo, [FromForm]string Telefono,
            [FromForm]string Direccion, [FromForm]string Seguro, [FromForm]string Sintomas, [FromForm]string Usuario
            )
        {

            var file = model.File;

            var modelo = new Paciente();
            string path = Path.Combine("C:\\Users\\Brian Gómez\\Desktop\\Proyecto\\prueba\\static\\img");

            if (file.Length > 0)
            {


                using (var fs = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                {
                    await file.CopyToAsync(fs);
                }

                modelo.Cedula = Cedula;
                modelo.Pass = Pass;
                modelo.Nombre = Nombre;
                modelo.Apellidos = Apellidos;
                modelo.Email = Email;
                modelo.Fecha = Convert.ToDateTime(Fecha);
                modelo.sexo = sexo;
                modelo.Telefono = Telefono;
                modelo.Direccion = Direccion;
                modelo.Seguro = Seguro;
                modelo.Sintomas = Sintomas;
                modelo.Usuario = Usuario;
                modelo.Foto = "/static/img/" + file.FileName;

                model.Source = "/static/img/" + file.FileName;
                model.Extension = Path.GetExtension(file.FileName).Substring(1);
                model.Size = file.Length / 1000;

                // ModelCurso.Imagen = "/static/img/" + file.FileName; ;

                _PacienteService.Add(modelo);
                return Ok(modelo);


            }
            return BadRequest();
        }


    }
    
}