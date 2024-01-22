using System;
namespace RGIS_IvancicBencak
{
	public class Component
	{
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public int Popularity { get; set; }

        public Component GetComponent()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public String GetImage()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public int GetPopularity()
        {
            return this.Popularity;
        }

    }
}

