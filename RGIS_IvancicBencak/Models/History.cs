using System;
namespace RGIS_IvancicBencak
{
	public class History
	{
        private int id;
        private List<Game> gameHistory;
        private List<Configuration> configurationHistory;

        public History GetHistory()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public List<Game> GetGameHistory()
        {
            return this.gameHistory;
        }
        public List<Configuration> GetConfigurationHistory()
        {
            return this.configurationHistory;
        }

        private User 0..1;

	}
}

