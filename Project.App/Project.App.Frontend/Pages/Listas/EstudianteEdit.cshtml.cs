using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Project.App.Persistencia;
using Project.App.Dominio;

namespace Project.App.Frontend.pages
{
    public class EstudianteEditModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        [BindProperty]
        public Estudiante estudiante{get;set;}

        public IActionResult OnGet(int? estudianteId)
        {
            if(estudianteId.HasValue)
            {
                estudiante = _repoEstudiante.GetEstudiante(estudianteId.Value);
            }else
            {
                estudiante = new Estudiante();
            }
            
            if(estudiante==null)
            {
                return RedirectToPage("/Listas/EstudianteList");
            }else
            return Page(); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
            
                return Page();                
            }else{
                if(estudiante.id>0)
                {
                    estudiante = _repoEstudiante.UpdateEstudiante(estudiante);
                }else{
                    _repoEstudiante.AddEstudiante(estudiante);
                }     
                return RedirectToPage("/Listas/EstudianteList");
            }     
        }
    }
}
