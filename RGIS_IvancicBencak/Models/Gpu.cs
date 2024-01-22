using System;

namespace RGIS_IvancicBencak
{
    public class Gpu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public Ram VRam { get; set; }

        // Constructor
        public Gpu(int id, string name, string brand, Ram vRam)
        {
            Id = id;
            Name = name;
            Brand = brand;
            VRam = vRam;
        }

        // Method to get a Gpu (if needed)
        public Gpu GetGpu()
        {
            // Implementation to get a Gpu, if necessary
            throw new System.NotImplementedException("Not implemented");
        }

        public override string ToString()
        {
            return VRam.ToString() + " vRam.";
        }
    }
}
