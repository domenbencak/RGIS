using System;
using System.Xml.Linq;

namespace RGIS_IvancicBencak
{
    public class Configuration
    {
        // Properties
        public int Id { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
        public PowerSupply? PowerSupply { get; set; }
        public Ram Ram { get; set; }
        public string? Case { get; set; }
        public BenchmarkScore? BenchmarkScore { get; set; }

        // Constructor
        public Configuration(int id, Cpu cpu, Gpu gpu, PowerSupply powerSupply, Ram ram, string case_, BenchmarkScore benchmarkScore)
        {
            Id = id;
            Cpu = cpu;
            Gpu = gpu;
            PowerSupply = powerSupply;
            Ram = ram;
            Case = case_;
            BenchmarkScore = benchmarkScore;
        }

        public Configuration(Cpu cpu, Gpu gpu, Ram ram)
        {
            Cpu = cpu;
            Gpu = gpu;
            Ram = ram;
        }

        public Configuration GetConfiguration()
        {
            // You may want to implement logic for getting a specific configuration here
            // Example: could be data from a database or hardcoded
            return new Configuration(
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
                    brand : "NVIDIA",
                    name : "GeForce GTX 970",
                    vRam : new Ram(2, "Nvidia", "vRam", "DDR5x", 4, 5000, 7)
                ),
                powerSupply: new PowerSupply
                (
                    id: 1,
                    brand : "EVGA",
                    title : "SuperNOVA 650 G3",
                    wattage : 650
                ),
                ram: new Ram
                (
                    id: 1,
                    brand : "Corsair",
                    name : "Vengeance LPX",
                    ddrVersion : "DDR4",
                    quantity : 2,
                    speed : 3200,
                    latency : 16
                ),
                case_: "NZXT H510",
                benchmarkScore: new BenchmarkScore
                (
                   id: 1,
                   cpuScore: 7600,
                   gpuScore: 8800
                )
            );
        }

        public override string ToString()
        {
            return $"Cpu: {Cpu}, Gpu: {Gpu}, Ram: {Ram}";
        }
    }
}
