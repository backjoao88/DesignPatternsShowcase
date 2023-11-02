namespace FactoryPattern.Elements.WindowsElements;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows Button...");
    }

    public void Click()
    {
        Console.WriteLine("Clicked on a Windows Button...");
    }
}