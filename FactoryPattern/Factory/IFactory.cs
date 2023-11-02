namespace FactoryPattern.Factory;

public interface IFactory<out T>
{
    public T Create(AppConfig config);
}