using System;
using System.Runtime.Intrinsics.Arm;

namespace RGIS_IvancicBencak
{
    public class Configuration
    {
        private int id;
        private Cpu cpu;
        private Gpu gpu;
        private PowerSupply powerSupply;
        private Ram ram;
        private String case_;
        private BenchmarkScore benchmarkScore;

        public Configuration GetConfiguration()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public override string ToString()
        {
            return "Cpu: " + cpu.ToString() + ", gpu: " + gpu.ToString() + ", ram: " + ram.ToString();
        }

    }
}

