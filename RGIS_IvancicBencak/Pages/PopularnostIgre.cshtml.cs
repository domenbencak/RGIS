using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS_IvancicBencak
{
    public class PopularnostIgreModel : PageModel
    {
        private readonly ILogger<MinimalneSpecifikacijeModel> _logger;

        public PopularnostIgreModel(ILogger<MinimalneSpecifikacijeModel> logger)
        {
            _logger = logger;
        }
        public bool ascending = false;
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
),
           new Game(
    id: 4,
    brand: "Square Enix",
    title: "Final Fantasy VII Remake",
    minRequirement: new Configuration(
        id: 3,
        cpu: new Cpu
        {
            Brand = "Intel",
            Name = "Core i5-9600K",
            Clockspeed = 3.7,
            Cores = 6,
            Threads = 6
        },
        gpu: new Gpu
        (
            id: 4,
            brand: "NVIDIA",
            name: "GeForce GTX 1660 Ti",
            vRam: new Ram(6, "GDDR5", "vRam", "GDDR5", 192, 12000, 12)
        ),
        powerSupply: new PowerSupply
        (
            id: 4,
            brand: "EVGA",
            title: "SuperNOVA 650 G5",
            wattage: 650
        ),
        ram: new Ram
        (
            id: 4,
            brand: "Corsair",
            name: "Vengeance LPX",
            ddrVersion: "DDR4",
            quantity: 2,
            speed: 3000,
            latency: 16
        ),
        case_: "NZXT H510",
        benchmarkScore: new BenchmarkScore
        (
            id: 4,
            cpuScore: 9000,
            gpuScore: 8500
        )
    ),
    base64Image: "c29tZSBpbWFnZSBkYXRh",
    popularity: 82
),
           new Game(
    id: 3,
    brand: "CD Projekt",
    title: "Cyberpunk 2077",
    minRequirement: new Configuration(
        id: 3,
        cpu: new Cpu
        {
            Brand = "AMD",
            Name = "Ryzen 7 3700X",
            Clockspeed = 3.6,
            Cores = 8,
            Threads = 16
        },
        gpu: new Gpu
        (
            id: 3,
            brand: "NVIDIA",
            name: "GeForce RTX 2080 Super",
            vRam: new Ram(8, "GDDR6", "vRam", "GDDR6", 256, 15500, 14)
        ),
        powerSupply: new PowerSupply
        (
            id: 3,
            brand: "EVGA",
            title: "SuperNOVA 850 G3",
            wattage: 850
        ),
        ram: new Ram
        (
            id: 3,
            brand: "Corsair",
            name: "Vengeance RGB Pro",
            ddrVersion: "DDR4",
            quantity: 4,
            speed: 3600,
            latency: 18
        ),
        case_: "NZXT H710i",
        benchmarkScore: new BenchmarkScore
        (
            id: 3,
            cpuScore: 9500,
            gpuScore: 9800
        )
    ),
    base64Image: "c29tZSBpbWFnZSBkYXRh",
    popularity: 92
)



        };
    }
}
