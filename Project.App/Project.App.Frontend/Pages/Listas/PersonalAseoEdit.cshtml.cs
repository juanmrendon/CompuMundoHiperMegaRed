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
    public class PersonalAseoEditModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personalAseo{get;set;}

        public IActionResult OnGet(int? personalAseoId)
        {
            if(personalAseoId.HasValue)
            {
                personalAseo = _repoPersonalAseo.GetPersonalAseo(personalAseoId.Value);
            }else
            {
                personalAseo = new PersonalAseo();
            }
            
            if(personalAseo==null)
            {
                return RedirectToPage("/Listas/PersonalAseoList");
            }else
            return Page(); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
            
                return Page();                
            }else{
                if(personalAseo.id>0)
                {
                    personalAseo = _repoPersonalAseo.UpdatePersonalAseo(personalAseo);
                }else{
                    _repoPersonalAseo.AddPersonalAseo(personalAseo);
                }     
                return RedirectToPage("/Listas/PersonalAseoList");
            }     
        }
    }
}
