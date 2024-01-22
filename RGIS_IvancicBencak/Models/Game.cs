using System;

namespace RGIS_IvancicBencak
{
    public class Game
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public int Popularity { get; set; }
        public Configuration MinimumRequirement { get; set; }
        public string Base64Image { get; set; }

        // Constructor
        public Game(int id, string brand, string title, int popularity, Configuration minRequirement, string base64Image)
        {
            Id = id;
            Brand = brand;
            Title = title;
            Popularity = popularity;
            MinimumRequirement = minRequirement;
            Base64Image = base64Image;
        }

      

            public Configuration GetGameSpecifications(string selectedTitle)
            {
                if (this.Title == selectedTitle)
                {
                    return MinimumRequirement;
                }
                else
                {
                    // Handle the case where the provided title doesn't match
                    return null; // or throw an exception, return default values, etc.
                }
            }
        
    }
}
