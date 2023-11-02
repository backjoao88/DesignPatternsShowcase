using AbstractFactoryPattern.Elements;

namespace AbstractFactoryPattern.Factory;

public interface IUiFactory
{
    public IButton CreateButton();
    public ICheckbox CreateCheckbox();
    public IGrid CreateGrid();
}
