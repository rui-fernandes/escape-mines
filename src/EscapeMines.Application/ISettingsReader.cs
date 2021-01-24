namespace EscapeMines.Application
{
    using EscapeMines.Domain;

    public interface ISettingsReader
    {
        GameSettings GetSettings();
    }
}
