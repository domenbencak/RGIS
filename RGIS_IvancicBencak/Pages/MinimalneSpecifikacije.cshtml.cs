using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS_IvancicBencak.Pages;

public class MinimalneSpecifikacijeModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public MinimalneSpecifikacijeModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

