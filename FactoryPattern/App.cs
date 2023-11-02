using FactoryPattern.Factory;

namespace FactoryPattern;

public abstract class App
{
    public static void Main(string[] args)
    {
        Console.WriteLine(">> Running Factory Pattern...");
        // Building a Windows Button
        {
            Console.WriteLine("> Creating a Windows Button...");
            AppConfig config = new AppConfig(AppHostType.Windows);
            ButtonFactory buttonFactory = new ButtonFactory();
            var myOsBasedButton = buttonFactory.Create(config);
            myOsBasedButton.Render();
        }
            
        // Building a Web Button
        {
            Console.WriteLine("> Creating a Web Button...");
            AppConfig config = new AppConfig(AppHostType.Web);
            ButtonFactory buttonFactory = new ButtonFactory();
            var myOsBasedButton = buttonFactory.Create(config);
            myOsBasedButton.Render();
        }

        // Building a Macos Button
        {
            AppConfig config = new AppConfig(AppHostType.MacOs);
            ButtonFactory buttonFactory = new ButtonFactory();
            var myOsBasedButton = buttonFactory.Create(config);
            myOsBasedButton.Render();
        }
    }
}