namespace FizzWare.NBuilder
{
    public interface IBuildable<T>
    {
        BuilderSetup BuilderSetup { get; set; }
        T Build();
    }
}