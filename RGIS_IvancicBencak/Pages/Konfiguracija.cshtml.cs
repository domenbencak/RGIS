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

        public List<Cpu> cpus { get; set; } = new List<Cpu>
        {
            new Cpu(1, "Ryzen 5 2600", "AMD", 3.4, 6, 12),
            new Cpu(2, "Core i7-4770K", "Intel", 3.5, 4, 8)
        };

        public List<Gpu> gpus { get; set; } = new List<Gpu>
        {
            new Gpu(1, "GeForce GTX 970", "NVIDIA", new Ram(2, "Nvidia", "vRam", "DDR5x", 4, 5000, 7)),
            new Gpu(2, "Radeon RX 5700 XT", "AMD", new Ram(8, "GDDR6", "vRam", "GDDR6", 256, 1750, 14))
        };

        public List<Ram> rams { get; set; } = new List<Ram>
        {
            new Ram(
                id: 1,
                brand: "G.Skill",
                name: "Ripjaws V",
                ddrVersion: "DDR4",
                quantity: 8,
                speed: 3200,
                latency: 16
            ),
            new Ram(
                id: 2,
                brand: "Corsair",
                name: "Vengeance LPX",
                ddrVersion: "DDR4",
                quantity: 16,
                speed: 3200,
                latency: 16
            )
        };

        public List<Configuration> configs { get; set; } = new List<Configuration>();
    }
}
