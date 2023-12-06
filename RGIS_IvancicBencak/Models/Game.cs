using System;
namespace RGIS_IvancicBencak
{
    public class Game
    {
        private int id;
        private String brand;
        private String title;
        private Configuration minimumRequirement;
        private String base64Image;
        private int popularity;

        public Game GetGame()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public int GetPopularity()
        {
            return this.popularity;
        }


    }
}

