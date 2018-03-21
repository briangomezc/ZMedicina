using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Service
{
    public interface IMedicoService
    {

        IEnumerable<Medico> GetAll();
        bool Add(Medico model);
        bool Update(Medico model);
        bool Delete(int categoriaid);
        Medico Get(int id);
    }
    
    public class MedicoService : IMedicoService
    {
        private readonly PacienteDbContext _PacienteDbContext;
        public MedicoService(
                PacienteDbContext PacienteDbContext
                )
        {
            _PacienteDbContext = PacienteDbContext;
        }
    

        public IEnumerable<Medico> GetAll()
        {
            var result = new List<Medico>();
            try
            {

                result = _PacienteDbContext.Medico.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public Medico Get(int id)
        {
            var result = new Medico();
            try
            {

                result = _PacienteDbContext.Medico.Single(x => x.MedicoID == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(Medico model)
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
        public bool Update(Medico model)
        {
            try
            {

                var originalModel = _PacienteDbContext.Medico.Single(x =>
                    x.MedicoID == model.MedicoID
                    );

                originalModel.Cedula = model.Cedula;
                originalModel.Nombre = model.Nombre;
                originalModel.Apellidos = model.Apellidos;
                originalModel.Fecha = model.Fecha;
                originalModel.Pass = model.Pass;
                originalModel.Email = model.Email;
                originalModel.sexo = model.sexo;
                originalModel.Tipo = model.Tipo;
                originalModel.Especializaciones = model.Especializaciones;
                originalModel.Telefono = model.Telefono;
                originalModel.Celular = model.Celular;



                _PacienteDbContext.Update(originalModel);
                _PacienteDbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int MedicoID)
        {
            try
            {
                _PacienteDbContext.Entry(new Medico { MedicoID = MedicoID }).State = EntityState.Deleted; ;
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
