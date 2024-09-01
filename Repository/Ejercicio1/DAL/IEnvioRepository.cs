using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.DAL
{
    public interface IEnvioRepository:IDisposable
    {
        IEnumerable<Envio> GetAll();
        Envio GetByID(int studentId);
        void Insert(Envio student);
        void Delete(int studentID);
        void Update(Envio student);
        void Save();
    }
}
