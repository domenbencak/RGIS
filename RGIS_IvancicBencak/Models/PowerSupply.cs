using System;

namespace RGIS_IvancicBencak
{
    public class PowerSupply : Component
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public int Wattage;

        // Constructor
        public PowerSupply(int id, string brand, string title, int wattage)
        {
            Id = id;
            Brand = brand;
            Title = title;
            Wattage = wattage;
        }

        public PowerSupply GetPowerSupply()
        {
            throw new System.NotImplementedException("Not implemented");
        }
    }
}
