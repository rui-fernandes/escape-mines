namespace EscapeMines
{
    using EscapeMines.Application;
    using EscapeMines.Application.Services;
    using EscapeMines.Infrastructure;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public static class Program
    {
        private const string DefaultSettingsPath = ".\\Settings\\GameSettings.txt";

        public static void Main(string[] args)
        {
            var settingsPath = GetSettingsPath(args);
            var host = CreateHostBuilder(settingsPath).Build();

            var gameManager = host.Services.GetRequiredService<IGameService>();

            gameManager.NewGame();
            gameManager.Play();
        }

        private static IHostBuilder CreateHostBuilder(string settingsPath)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((__, services) =>
                {
                    services.AddSingleton<ISettingsReader>((_) => new SettingsFileReader(settingsPath));
                    services.AddSingleton<IGameService, GameService>();
                });
        }

        private static string GetSettingsPath(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                return DefaultSettingsPath;
            }

            return args[0];
        }
    }
}
