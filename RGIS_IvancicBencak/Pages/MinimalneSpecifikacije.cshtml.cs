using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RGIS_IvancicBencak.Pages;

namespace RGIS_IvancicBencak
{
    public class MinimalneSpecifikacijeModel : PageModel
    {
        private readonly ILogger<MinimalneSpecifikacijeModel> _logger;

        public MinimalneSpecifikacijeModel(ILogger<MinimalneSpecifikacijeModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
