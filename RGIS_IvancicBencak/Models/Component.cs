using System;
namespace RGIS_IvancicBencak
{
	public class Component
	{
        private int id;
        private String brand;
        private String name;
        private String base64Image;

        private int popularity;

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
            return this.popularity;
        }

    }
}

