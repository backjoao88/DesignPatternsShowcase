using FactoryPattern.Elements;
using FactoryPattern.Elements.WebElements;
using FactoryPattern.Elements.WindowsElements;

namespace FactoryPattern.Factory;

public class ButtonFactory : IFactory<IButton>
{
    public IButton Create(AppConfig config)
    {
        switch (config.HostType)
        {
            case AppHostType.Web:
                return new WebButton();
            case AppHostType.Windows:
                return new WindowsButton();
            default:
                throw new Exception("Operational system not found.");
        }
    }
}