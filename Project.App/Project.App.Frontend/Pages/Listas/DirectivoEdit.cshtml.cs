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
    public class DirectivoEditModel : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        [BindProperty]
        public Directivo directivo{get;set;}

        public IActionResult OnGet(int? directivoId)
        {
            if(directivoId.HasValue)
            {
                directivo = _repoDirectivo.GetDirectivo(directivoId.Value);
            }else
            {
                directivo = new Directivo();
            }
            
            if(directivo==null)
            {
                return RedirectToPage("/Listas/DirectivoList");
            }else
            return Page(); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
            
                return Page();                
            }else{
                if(directivo.id>0)
                {
                    directivo = _repoDirectivo.UpdateDirectivo(directivo);
                }else{
                    _repoDirectivo.AddDirectivo(directivo);
                }     
                return RedirectToPage("/Listas/EstudianteList");
            }     
        }
    }
}
