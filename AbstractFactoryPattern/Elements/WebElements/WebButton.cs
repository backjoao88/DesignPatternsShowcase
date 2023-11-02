namespace AbstractFactoryPattern.Elements.WebElements;

public class WebButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Web Button...");
    }

    public void Click()
    {
        Console.WriteLine("Clicked on a Web Button...");
    }
}