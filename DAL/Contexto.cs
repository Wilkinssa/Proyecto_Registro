using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Registro.Entidades;

namespace Proyecto_Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios{ get; set; }

        public DbSet<Roles> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = datosUsuarios.Db");
        }
    }
}
