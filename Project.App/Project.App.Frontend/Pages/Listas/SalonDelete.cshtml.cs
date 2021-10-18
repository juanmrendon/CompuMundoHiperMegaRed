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
    public class SalonDeleteModel : PageModel
    {
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        [BindProperty]
        public Salon salon { get; set; }

        public IActionResult OnGet(int salonId)
        {
            salon = _repoSalon.GetSalon(salonId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoSalon.DeleteSalon(salon.id);
            return RedirectToPage("./SaloneList");
        }
    }
}

