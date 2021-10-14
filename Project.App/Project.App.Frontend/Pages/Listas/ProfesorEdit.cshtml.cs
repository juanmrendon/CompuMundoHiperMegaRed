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
    public class ProfesorEditModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        public Profesor profesor{get;set;}

        public IActionResult OnGet(int? profesorId)
        {
            if(profesorId.HasValue)
            {
                profesor = _repoProfesor.GetProfesor(profesorId.Value);
            }else
            {
                profesor = new Profesor();
            }
            
            if(profesor==null)
            {
                return RedirectToPage("/Listas/ProfesorList");
            }else
            return Page(); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
            
                return Page();                
            }else{
                if(profesor.id>0)
                {
                    profesor = _repoProfesor.UpdateProfesor(profesor);
                }else{
                    _repoProfesor.AddProfesor(profesor);
                }     
                return RedirectToPage("/Listas/ProfesorList");
            }     
        }
    }
}
