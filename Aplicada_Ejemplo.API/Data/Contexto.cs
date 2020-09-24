using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicada_Ejemplo.Api.Models;

namespace Aplicada_Ejemplo.Api.Data
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions options) : base(options) { }

        public DbSet<Estudiantes> Estudiantes { get; set; }
    }
}
