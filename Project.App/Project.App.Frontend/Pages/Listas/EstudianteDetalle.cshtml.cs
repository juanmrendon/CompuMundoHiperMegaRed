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
    public class EstudianteDetalle : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        public Estudiante estudiante{get; set;}

        public IActionResult OnGet(int estudianteId)
        {
            estudiante = _repoEstudiante.GetEstudiante(estudianteId);
            if(estudiante==null)
            {
                return RedirectToPage("./EstudianteList");
            }else
            return Page();        
        }
    }
}