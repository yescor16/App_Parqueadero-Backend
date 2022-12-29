using App.Transversal.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructura.Repositorio
{
    public class DatabaseContext:DbContext
    {
        public DbSet<TipoVehiculo> PAR_TIPOVEHICULO { get; set; }
        public DbSet<Tarifa> PAR_TARIFA { get; set; }
        public DbSet<RegistroParqueadero> NEG_REGISTROPARQUEADERO { get; set; }
        public DbSet<ReporteVehiculosConSalidaPorTiempo> SP_ReporteVehiculosConSalidaPorTiempos { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
           

        }

     

    }
}
