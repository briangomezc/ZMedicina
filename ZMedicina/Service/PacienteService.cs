using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface IPacienteService
    {
        IEnumerable<Paciente> GetAll();
        bool Add(Paciente model);
        bool Update(Paciente model);
        bool Delete(int categoriaid);
        Paciente Get(int id);
    }

    public class PacienteService : IPacienteService
    {
        private readonly PacienteDbContext _PacienteDbContext;
        public PacienteService(
                PacienteDbContext PacienteDbContext
                )
        {
            _PacienteDbContext = PacienteDbContext;
        }



        public IEnumerable<Paciente> GetAll()
        {
            var result = new List<Paciente>();
            try
            {

                result = _PacienteDbContext.Paciente.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public Paciente Get(int id)
        {
            var result = new Paciente();
            try
            {

                result = _PacienteDbContext.Paciente.Single(x => x.PacienteID == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(Paciente model)
        {
            try
            {
                _PacienteDbContext.Add(model);
                _PacienteDbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Update(Paciente model)
        {
            try
            {

                var originalModel = _PacienteDbContext.Paciente.Single(x =>
                    x.PacienteID == model.PacienteID
                    );

                originalModel.Cedula = model.Cedula;
                originalModel.Nombre = model.Nombre;
                originalModel.Apellidos = model.Apellidos;
                originalModel.Fecha = model.Fecha;
                originalModel.Pass = model.Pass;
                originalModel.Email = model.Email;
                originalModel.sexo = model.sexo;
                originalModel.Telefono = model.Telefono;
                originalModel.Direccion = model.Direccion;
                originalModel.Seguro = model.Seguro;
                originalModel.Sintomas = model.Sintomas;



                _PacienteDbContext.Update(originalModel);
                _PacienteDbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int PacienteID)
        {
            try
            {
                _PacienteDbContext.Entry(new Paciente { PacienteID = PacienteID }).State = EntityState.Deleted; ;
                _PacienteDbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }



}
