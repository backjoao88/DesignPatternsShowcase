using AbstractFactoryPattern.Elements;
using AbstractFactoryPattern.Elements.WebElements;

namespace AbstractFactoryPattern.Factory;

public class WebFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new WebButton();
    }
    public ICheckbox CreateCheckbox()
    {
        return new WebCheckbox();
    }
    public IGrid CreateGrid()
    {
        return new WebGrid();
    }
}