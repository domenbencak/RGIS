using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS_IvancicBencak.Pages
{
	public class LoginModel : PageModel
    { 
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username == "uporabnik" && Password == "geslo")
            {
                return RedirectToPage("/Index");
            }
            else
            {
                ViewData["Message"] = "Neuspešna prijava. Poskusite znova.";
                return Page();
            }
        }
    }
}
