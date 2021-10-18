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
    public class PersonalAseoDeleteModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personalAseo { get; set; }
        
        public IActionResult OnGet(int personalAseoId)
        {
            personalAseo = _repoPersonalAseo.GetPersonalAseo(personalAseoId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoPersonalAseo.DeletePersonalAseo(personalAseo.id);
            return RedirectToPage("./PersonalAseoList");
        }
    }
}

