namespace EscapeMines.Application.Services
{
    using EscapeMines.Domain;
    using Microsoft.Extensions.Logging;

    public class GameService : IGameService
    {
        private readonly ISettingsReader settingsReader;
        private readonly ILogger<GameService> logger;

        private Game game;

        public GameService(
            ISettingsReader settingsReader,
            ILogger<GameService> logger)
        {
            this.settingsReader = settingsReader;
            this.logger = logger;
        }

        public void NewGame()
        {
            var settings = this.settingsReader.GetSettings();

            this.game = new Game(settings);
        }

        public void Play()
        {
            switch (this.game.Play())
            {
                case GameResult.Sucess:
                    this.logger.LogInformation("The turtle reached the exit.");
                    break;

                case GameResult.MineHit:
                    this.logger.LogError("The turtle hit one mine.");
                    break;

                case GameResult.Danger:
                    this.logger.LogWarning("The turtle is in danger.");
                    break;
            }
        }
    }
}
