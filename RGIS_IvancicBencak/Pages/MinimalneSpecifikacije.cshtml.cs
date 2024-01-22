using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace RGIS_IvancicBencak
{
    public class MinimalneSpecifikacijeModel : PageModel
    {
        private readonly ILogger<MinimalneSpecifikacijeModel> _logger;

        public MinimalneSpecifikacijeModel(ILogger<MinimalneSpecifikacijeModel> logger)
        {
            _logger = logger;
        }

        public Game SelectedGame { get; set; }

        // List of games
        public List<Game> games { get; set; } = new List<Game>
        {
            new Game(
                id: 1,
                brand: "Ubisoft",
                title: "Assassin's Creed Valhalla",
                minRequirement: new Configuration(
                    id: 1,
                    cpu: new Cpu
                    {
                        Brand = "AMD",
                        Name = "Ryzen 5 2600",
                        Clockspeed = 3.4,
                        Cores = 6,
                        Threads = 12
                    },
                    gpu: new Gpu
                    (
                        id: 1,
                        brand: "NVIDIA",
                        name: "GeForce GTX 970",
                        vRam: new Ram(2, "Nvidia", "vRam", "DDR5x", 4, 5000, 7)
                    ),
                    powerSupply: new PowerSupply
                    (
                        id: 1,
                        brand: "EVGA",
                        title: "SuperNOVA 650 G3",
                        wattage: 650
                    ),
                    ram: new Ram
                    (
                        id: 1,
                        brand: "Corsair",
                        name: "Vengeance LPX",
                        ddrVersion: "DDR4",
                        quantity: 16,
                        speed: 3200,
                        latency: 16
                    ),
                    case_: "NZXT H510",
                    benchmarkScore: new BenchmarkScore
                    (
                        id: 1,
                        cpuScore: 7600,
                        gpuScore: 8800
                    )
                ),
                base64Image: "c29tZSBpbWFnZSBkYXRh",
                popularity: 92
            ),
           new Game(
    id: 2,
    brand: "Rockstar Games",
    title: "Red Dead Redemption 2",
    minRequirement: new Configuration(
        id: 2,
        cpu: new Cpu
        {
            Brand = "Intel",
            Name = "Core i7-4770K",
            Clockspeed = 3.5,
            Cores = 4,
            Threads = 8
        },
        gpu: new Gpu
        (
            id: 2,
            brand: "AMD",
            name: "Radeon RX 5700 XT",
            vRam: new Ram(8, "GDDR6", "vRam", "GDDR6", 256, 1750, 14)
        ),
        powerSupply: new PowerSupply
        (
            id: 2,
            brand: "Corsair",
            title: "RM750x",
            wattage: 750
        ),
        ram: new Ram
        (
            id: 2,
            brand: "G.Skill",
            name: "Ripjaws V",
            ddrVersion: "DDR4",
            quantity: 2,
            speed: 3200,
            latency: 16
        ),
        case_: "Cooler Master H500",
        benchmarkScore: new BenchmarkScore
        (
            id: 2,
            cpuScore: 8500,
            gpuScore: 9200
        )
    ),
    base64Image: "c29tZSBpbWFnZSBkYXRh",
    popularity: 88
)

        };

        public string GetGameSpecifications(string game)
        {
            var selectedGame = games.Find(g => g.Title == game);

            return selectedGame.Title ?? "No game found.";
        }

        public JsonResult OnGetGameSpecifications(string game)
        {
            game = game.Trim();

            var selectedGame = games.Find(g => g.Title.Equals(game, StringComparison.OrdinalIgnoreCase));

            return new JsonResult(selectedGame);
        }
    }
}

