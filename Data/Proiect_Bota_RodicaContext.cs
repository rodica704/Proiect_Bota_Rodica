using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Bota_Rodica.Models;

namespace Proiect_Bota_Rodica.Data
{
    public class Proiect_Bota_RodicaContext : DbContext
    {
        public Proiect_Bota_RodicaContext (DbContextOptions<Proiect_Bota_RodicaContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Bota_Rodica.Models.Produs> Produs { get; set; } = default!;

        public DbSet<Proiect_Bota_Rodica.Models.Client>? Client { get; set; }

        public DbSet<Proiect_Bota_Rodica.Models.Distribuitor>? Distribuitor { get; set; }
    }
}
