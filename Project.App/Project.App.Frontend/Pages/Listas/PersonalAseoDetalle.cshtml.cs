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
    public class PersonalAseoDetalle : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        
        public PersonalAseo personalAseo{get; set;}

        public IActionResult OnGet(int personalAseoId)
        {
            personalAseo = _repoPersonalAseo.GetPersonalAseo(personalAseoId);
            if(personalAseo==null)
            {
                return RedirectToPage("./PersonalAseoList");
            }else
            return Page();        
        }
    }
}