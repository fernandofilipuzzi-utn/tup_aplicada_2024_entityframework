
using Ejercicio1.DAL;
using Ejercicio1.Models;
using System;
using System.Linq;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var db = new LogisticaContext();

            IEnvioRepository envRepo = new EnvioRepository(db);

            #region caso1
            var nuevo = new Envio() { ValorTotal = 83 };
            envRepo.Insert(nuevo);
            envRepo.Save();
            Console.WriteLine(nuevo.Id);
            #endregion

            #region caso 2
            nuevo = new Envio() { ValorTotal = 23 };
            nuevo.Costos.Add(new Fijo() { Concepto = "Transporte", ValorFinal = 38.4 });
            nuevo.Costos.Add(new Variable() { Concepto = "Aduana", ValorFinal = 35.4 });
            envRepo.Insert(nuevo);
            envRepo.Save();
            #endregion


            foreach (Envio env in envRepo.GetAll())
            {
                Console.WriteLine($"{env.Id} {env.ValorTotal}");
                foreach (Costo costo in env.Costos)
                {
                    Console.WriteLine($"{costo.Id} {costo.ToString()}");
                }
            }

            Console.ReadKey();

        }
    }
}
