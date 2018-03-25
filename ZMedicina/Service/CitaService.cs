using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface ICitaService
    {
        IEnumerable<Cita> GetAll();
        bool Add(Cita model);
        bool Update(Cita model);
        bool Delete(int CitaID);
        Cita Get(int id);
    }

    public class CitaService : ICitaService
    {
        private readonly PacienteDbContext _PacienteDbContext;
        public CitaService(
                PacienteDbContext PacienteDbContext
                )
        {
            _PacienteDbContext = PacienteDbContext;
        }


        public IEnumerable<Cita> GetAll()
        {
            var result = new List<Cita>();
            try
            {

                result = _PacienteDbContext.Cita.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public Cita Get(int id)
        {
            var result = new Cita();
            try
            {

                result = _PacienteDbContext.Cita.Single(x => x.CitaID == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(Cita model)
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
        public bool Update(Cita model)
        {
            try
            {

                var originalModel = _PacienteDbContext.Cita.Single(x =>
                    x.CitaID == model.CitaID
                    );

               
                originalModel.Fecha = model.Fecha;
                originalModel.Tipo = model.Tipo;




                _PacienteDbContext.Update(originalModel);
                _PacienteDbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int CitaID)
        {
            try
            {
                _PacienteDbContext.Entry(new Cita { CitaID = CitaID }).State = EntityState.Deleted; ;
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
