namespace AbstractFactoryPattern.Factory;

public class ElementFactory
{
    public IUiFactory CreateFactory(AppConfig config)
    {
        switch (config.HostType)
        {
            case AppHostType.Web:
                return new WebFactory();
            case AppHostType.Windows:
                return new WindowsFactory();
            default:
                throw new Exception("Factory not implemented.");
        }
    }
}