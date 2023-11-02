using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern;

public abstract class App
{
    public static void Main(string[] args)
    {
        Console.WriteLine(">> Running Abstract Factory Pattern...");
        {
            Console.WriteLine("> Testing Select ALl in Grid on a Windows Environment...");
            AppConfig config = new AppConfig(AppHostType.Windows);
            ElementFactory factory = new ElementFactory();
            var customFactory = factory.CreateFactory(config);
            var customBuiltGrid = customFactory.CreateGrid();
            customBuiltGrid.SelectAll();
        }
        {
            Console.WriteLine("> Testing Button Click on a Windows Environment...");
            AppConfig config = new AppConfig(AppHostType.Windows);
            ElementFactory factory = new ElementFactory();
            var customFactory = factory.CreateFactory(config);
            var customBuiltGrid = customFactory.CreateButton();
            customBuiltGrid.Click();
        }
        {
            Console.WriteLine("> Testing Select ALl in Grid on a Web Environment...");
            AppConfig config = new AppConfig(AppHostType.Web);
            ElementFactory factory = new ElementFactory();
            var customFactory = factory.CreateFactory(config);
            var customBuiltGrid = customFactory.CreateGrid();
            customBuiltGrid.SelectAll();
        }
        {
            Console.WriteLine("> Testing Button Click on a Web Environment...");
            AppConfig config = new AppConfig(AppHostType.Web);
            ElementFactory factory = new ElementFactory();
            var customFactory = factory.CreateFactory(config);
            var customBuiltGrid = customFactory.CreateButton();
            customBuiltGrid.Click();
        }
    }
}