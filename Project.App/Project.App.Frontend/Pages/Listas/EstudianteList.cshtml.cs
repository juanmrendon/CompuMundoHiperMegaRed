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
    public class EstudianteList : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        public IEnumerable<Estudiante> Estudiantes{get; set;}
        

        public void OnGet()
        {
            Estudiantes = _repoEstudiante.GetAllEstudiantes();
        }
    }
}