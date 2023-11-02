namespace AbstractFactoryPattern;

public enum AppHostType
{
    Web,
    Windows,
    MacOs
}

public class AppConfig
{
    public AppHostType HostType { get; set; }

    public AppConfig(AppHostType hostType)
    {
        HostType = hostType;
    }
}