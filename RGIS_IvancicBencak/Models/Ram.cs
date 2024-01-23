using System;
namespace RGIS_IvancicBencak
{
    public class Ram
    {
        public int Id { get; set; }
        public String Brand { get; set; }
        public String Name { get; set; }
        public String DdrVersion { get; set; }
        public int Quantity { get; set; }
        public int Speed { get; set; }
        public int Latency { get; set; }

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

