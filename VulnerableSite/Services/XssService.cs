namespace VulnerableSite.Services;

public class XssService : IXssService
{
    private readonly List<string> _messages = [];

    public IEnumerable<string> Messages => _messages;

    public void AddMessage(string message)
    {
        _messages.Add(message);
    }
}
