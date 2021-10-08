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
    public class SalonList : PageModel
    {
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        
        public IEnumerable<Salon> Salones{get; set;}
        

        public void OnGet()
        {
            Salones = _repoSalon.GetAllSalones();
        }
    }
}