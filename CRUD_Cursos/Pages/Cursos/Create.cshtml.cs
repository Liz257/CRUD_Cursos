using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD_Cursos.Data;
using CRUD_Cursos.Model;

namespace CRUD_Cursos.Pages.Cursos
{
    public class CreateModel : PageModel
    {
        private readonly CRUD_Cursos.Data.CRUD_CursosContext _context;

        public CreateModel(CRUD_Cursos.Data.CRUD_CursosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Curso Curso { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Curso.Add(Curso);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
