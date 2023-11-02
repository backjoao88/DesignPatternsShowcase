namespace AbstractFactoryPattern.Elements.WindowsElements;

public class WindowsGrid : IGrid
{
    public void SelectAll()
    {
        Console.WriteLine("Selecting all elements from a Windows Grid...");
    }

    public void Render()
    {
        Console.WriteLine("Rendering all elements from a Windows Grid...");
    }
}