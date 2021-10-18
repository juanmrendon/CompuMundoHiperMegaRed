using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Project.App.Persistencia;
using Project.App.Dominio;

namespace Project.App.Frontend.Pages
{
    public class EstudianteDeleteModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        [BindProperty]
        public Estudiante estudiante { get; set; }

        public IActionResult OnGet(int estudianteId)
        {
            estudiante = _repoEstudiante.GetEstudiante(estudianteId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoEstudiante.DeleteEstudiante(estudiante.id);
            return RedirectToPage("./EstudianteList");
        }
    }
}

