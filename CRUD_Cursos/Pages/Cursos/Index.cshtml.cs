using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_Cursos.Data;
using CRUD_Cursos.Model;

namespace CRUD_Cursos.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_Cursos.Data.CRUD_CursosContext _context;

        public IndexModel(CRUD_Cursos.Data.CRUD_CursosContext context)
        {
            _context = context;
        }

        public IList<Curso> Curso { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Curso = await _context.Curso.ToListAsync();
        }
    }
}
