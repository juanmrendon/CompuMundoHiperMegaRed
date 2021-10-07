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
    public class DirectivoList : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        public IEnumerable<Directivo> Directivos{get; set;}
        

        public void OnGet()
        {
            Directivos = _repoDirectivo.GetAllDirectivos();
        }
    }
}