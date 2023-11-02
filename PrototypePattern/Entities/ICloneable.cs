namespace PrototypePattern.Entities;

public interface ICloneable<T> where T : class
{
    public T Clone();
}