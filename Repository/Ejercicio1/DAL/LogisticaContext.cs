


using System.Data.Entity;
namespace Ejercicio1.Models
{
    public class LogisticaContext : DbContext
    {
        public DbSet<Envio> Envios { get; set; }
        public DbSet<Costo> Costos { get; set; }

        public LogisticaContext() : base("name=EnviosDB")
        {
           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LogisticaContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<LogisticaContext>();

            // Configura la jerarquía TPH
            //modelBuilder.Entity<Costo>()
            //       .Map<Fijo>(m => m.MapInheritedProperties())
            //       .Map<Variable>(m => m.MapInheritedProperties());

            modelBuilder.Entity<Costo>()
                   .Map<Fijo>(m => m.Requires("Tipo").HasValue("Fijo"))
                   .Map<Variable>(m => m.Requires("Tipo").HasValue("Variable"));

            modelBuilder.Entity<Costo>()
                .HasRequired(c => c.Envio)
                .WithMany(e => e.Costos)
                .HasForeignKey(c => c.EnvioId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
