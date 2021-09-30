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
    public class DetallesModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        
        public Profesor profesor{get; set;}

        public IActionResult OnGet(int profesorId)
        {
            profesor =_repoProfesor.GetProfesor(profesorId);
            if(profesor==null)
            {
                return RedirectToPage("./ProfesorList");
            }else
            return Page();        
        }
    }
}