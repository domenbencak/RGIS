using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS_IvancicBencak.Pages
{
	public class KonfiguracijaModel : PageModel
    {
        [BindProperty]
        public string Cpu { get; set; }

        [BindProperty]
        public string Gpu { get; set; }

        [BindProperty]
        public string Ram { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Shranjevanje

            return RedirectToPage("/Index");
        }
    }
}
