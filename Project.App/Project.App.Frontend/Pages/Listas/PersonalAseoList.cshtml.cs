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
    public class PersonalAseoList : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        
        public IEnumerable<PersonalAseo> PersonalAseos{get; set;}
        

        public void OnGet()
        {
            PersonalAseos = _repoPersonalAseo.GetAllPersonalAseos();
        }
    }
}