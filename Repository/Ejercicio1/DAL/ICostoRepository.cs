using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.DAL
{
    public interface ICostoRepository:IDisposable
    {
        IEnumerable<Costo> GetAll();
        Costo GetByID(int studentId);
        void Insert(Costo student);
        void Delete(int studentID);
        void Update(Costo student);
        void Save();
    }
}
