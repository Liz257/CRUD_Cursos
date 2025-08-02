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
    public class DetailsModel : PageModel
    {
        private readonly CRUD_Cursos.Data.CRUD_CursosContext _context;

        public DetailsModel(CRUD_Cursos.Data.CRUD_CursosContext context)
        {
            _context = context;
        }

        public Curso Curso { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso.FirstOrDefaultAsync(m => m.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            else
            {
                Curso = curso;
            }
            return Page();
        }
    }
}
