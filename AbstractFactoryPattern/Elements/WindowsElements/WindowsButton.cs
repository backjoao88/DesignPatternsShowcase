namespace AbstractFactoryPattern.Elements.WindowsElements;

public class WindowsButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Clicked on a Windows Button...");
    }

    public void Render()
    {
        Console.WriteLine("Rendering Windows Button...");
    }
}