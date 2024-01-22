using System;
namespace RGIS_IvancicBencak
{
    public class Ram
    {
        private int Id { get; set; }
        private String Brand { get; set; }
        private String Name { get; set; }
        private String DdrVersion { get; set; }
        private int Quantity { get; set; }
        private int Speed { get; set; }
        private int Latency { get; set; }

        public Ram(int id, string brand, string name, string ddrVersion, int quantity, int speed, int latency)
        {
            Id = id;
            Brand = brand;
            Name = name;
            DdrVersion = ddrVersion;
            Quantity = quantity;
            Speed = speed;
            Latency = latency;
        }


        public Ram GetRam()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public override string ToString()
        {
            return DdrVersion + ", " + Quantity.ToString() + "GB.";
        }

    }
}

