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
    public class SalonEditModel : PageModel
    {
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        [BindProperty]
        public Salon salon{get;set;}

        public IActionResult OnGet(int? salonId)
        {
            if(salonId.HasValue)
            {
                salon = _repoSalon.GetSalon(salonId.Value);
            }else
            {
                salon = new Salon();
            }
            
            if(salon==null)
            {
                return RedirectToPage("/Listas/SalonList");
            }else
            return Page(); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
            
                return Page();                
            }else{
                if(salon.id>0)
                {
                    salon = _repoSalon.UpdateSalon(salon);
                }else{
                    _repoSalon.AddSalon(salon);
                }     
                return RedirectToPage("/Listas/SalonList");
            }     
        }
    }
}
