namespace AbstractFactoryPattern.Elements.WindowsElements;

public class WindowsCheckbox : ICheckbox
{
    public void Check()
    {
        Console.WriteLine("Checking Windows Checkbox...");
    }

    public void Render()
    {
        Console.WriteLine("Rendering Windows Checkbox...");
    }
}