namespace AbstractFactoryPattern.Elements.WebElements;

public class WebCheckbox : ICheckbox
{
    public void Check()
    {
        Console.WriteLine("Checking Web Checkbox...");
    }

    public void Render()
    {
        Console.WriteLine("Rendering Web Checkbox...");
    }
}