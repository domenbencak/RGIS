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

        public string GetGameSpecifications(string game)
        {
            // Vrne minimalne specifikacije glede na izbrano igro
            // Primer: lahko bi bili podatki iz podatkovne baze ali trde kode
            return this.minimumRequirement.ToString();
        }
    }
}

