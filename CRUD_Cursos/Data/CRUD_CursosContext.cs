using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Cursos.Model;

namespace CRUD_Cursos.Data
{
    public class CRUD_CursosContext : DbContext
    {
        public CRUD_CursosContext (DbContextOptions<CRUD_CursosContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Cursos.Model.Curso> Curso { get; set; } = default!;
    }
}
