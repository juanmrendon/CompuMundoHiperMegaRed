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
    public class DirectivoDeleteModel : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        [BindProperty]
        public Directivo directivo { get; set; }
        
        public IActionResult OnGet(int directivoId)
        {
            directivo = _repoDirectivo.GetDirectivo(directivoId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoDirectivo.DeleteDirectivo(directivo.id);
            return RedirectToPage("./DirectivoList");
        }
    }
}

