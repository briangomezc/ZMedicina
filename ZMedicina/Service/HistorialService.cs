using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface IHistorialService
    {

        IEnumerable<Historial> GetAll();
        bool Add(Historial model);
        bool Update(Historial model);
        bool Delete(int categoriaid);
        Historial Get(int id);
    }

    public class HistorialService : IHistorialService
    {
        private readonly PacienteDbContext _PacienteDbContext;
        public HistorialService(
                PacienteDbContext PacienteDbContext
                )
        {
            _PacienteDbContext = PacienteDbContext;
        }


        public IEnumerable<Historial> GetAll()
        {
            var result = new List<Historial>();
            try
            {

                result = _PacienteDbContext.Historial.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public Historial Get(int id)
        {
            var result = new Historial();
            try
            {

                result = _PacienteDbContext.Historial.Single(x => x.HistorialID == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(Historial model)
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
        public bool Update(Historial model)
        {
            try
            {

                var originalModel = _PacienteDbContext.Historial.Single(x =>
                    x.HistorialID == model.HistorialID
                    );


                originalModel.Nombre = model.Nombre;
                originalModel.Apellidos = model.Apellidos;
                originalModel.Cedula = model.Cedula;
                originalModel.Edad = model.Edad;
                originalModel.sexo = model.sexo;
                originalModel.Seguro = model.Seguro;
                originalModel.Ocupacion = model.Ocupacion;
                originalModel.Telefono = model.Telefono;
                originalModel.Celular = model.Celular;
                originalModel.Direccion = model.Direccion;
                originalModel.Sintomas = model.Sintomas;
                originalModel.Antecedentes = model.Antecedentes;


                _PacienteDbContext.Update(originalModel);
                _PacienteDbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int HistorialID)
        {
            try
            {
                _PacienteDbContext.Entry(new Historial { HistorialID = HistorialID }).State = EntityState.Deleted; ;
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