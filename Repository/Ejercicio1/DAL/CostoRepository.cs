using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.DAL
{
    public class CostoRepository : ICostoRepository, IDisposable
    {
        private LogisticaContext context;

        public CostoRepository(LogisticaContext context)
        {
            this.context = context;
        }

        public IEnumerable<Costo> GetAll()
        {
            return context.Costos.ToList();
        }

        public Costo GetByID(int id)
        {
            return context.Costos.Find(id);
        }

        public void Insert(Costo entity)
        {
            context.Costos.Add(entity);
        }

        public void Delete(int studentID)
        {
            var entity = context.Costos.Find(studentID);
            context.Costos.Remove(entity);
        }

        public void Update(Costo entidad)
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
