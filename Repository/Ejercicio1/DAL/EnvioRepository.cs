using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.DAL
{
    public class EnvioRepository : IEnvioRepository, IDisposable
    {
        private LogisticaContext context;

        public EnvioRepository(LogisticaContext context)
        {
            this.context = context;
        }

        public IEnumerable<Envio> GetAll()
        {
            return context.Envios.ToList();
        }

        public Envio GetByID(int id)
        {
            return context.Envios.Find(id);
        }

        public void Insert(Envio entity)
        {
            context.Envios.Add(entity);
        }

        public void Delete(int studentID)
        {
            var entity = context.Envios.Find(studentID);
            context.Envios.Remove(entity);
        }

        public void Update(Envio entidad)
        {
            context.Entry(entidad).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
