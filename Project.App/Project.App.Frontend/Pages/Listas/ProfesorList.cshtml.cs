using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Project.App.Persistencia;
using Project.App.Dominio;


namespace Project.App.Frontend.Pages
{
    public class ProfesorList : PageModel
    {
        private readonly IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        
        public IEnumerable<Profesor> Profesores{get; set;}
        

        public void OnGet()
        {
            Profesores = _repoProfesor.GetAllProfesores();
        }
    }
}