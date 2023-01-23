namespace VulnerableSite.Services;

public interface IXssService
{
    IEnumerable<string> Messages { get; }

    void AddMessage(string message);
}
