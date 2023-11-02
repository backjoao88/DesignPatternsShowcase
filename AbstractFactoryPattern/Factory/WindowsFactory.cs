using AbstractFactoryPattern.Elements;
using AbstractFactoryPattern.Elements.WebElements;
using AbstractFactoryPattern.Elements.WindowsElements;

namespace AbstractFactoryPattern.Factory;

public class WindowsFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WebCheckbox();
    }

    public IGrid CreateGrid()
    {
        return new WindowsGrid();
    }
}