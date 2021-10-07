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
    public class DirectivoDetalle : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        public Directivo directivo{get; set;}

        public IActionResult OnGet(int directivoId)
        {
            directivo = _repoDirectivo.GetDirectivo(directivoId);
            if(directivo==null)
            {
                return RedirectToPage("./DirectivoList");
            }else
            return Page();        
        }
    }
}