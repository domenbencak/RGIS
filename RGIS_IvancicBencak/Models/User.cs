using System;
namespace RGIS_IvancicBencak
{
    public class User
    {
        private int id;
        private String username;
        private String password;
        private Configuration? personalConfiguration;
        private List<Game>? favoriteGames;
        private History? history;

        public void SetGeslo(ref String password)
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public User GetUser()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public void ShraniKonfiguracijo(Configuration configuration)
        {
            this.personalConfiguration = configuration;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

    }
}

