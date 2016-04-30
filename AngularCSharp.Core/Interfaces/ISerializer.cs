namespace AngularCSharp.Core.Interfaces
{
    public interface ISerializer
    {
        T Deserialise<T>(string input);
    }
}
