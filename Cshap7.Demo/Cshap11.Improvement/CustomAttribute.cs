namespace Cshap11.Improvement;

public class CustomAttribute<T> : Attribute
{
    public Type CurrentType => typeof(T);
}
