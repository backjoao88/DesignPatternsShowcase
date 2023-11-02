namespace AbstractFactoryPattern.Elements.WebElements;

public class WebGrid: IGrid
{
    public void SelectAll()
    {
        Console.WriteLine("Selecting all elements from Web Grid...");
    }

    public void Render()
    {
        Console.WriteLine("Rendering Web Grid...");
    }
}