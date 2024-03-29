namespace VulnerableSite.Models;

public class XssViewModel(IEnumerable<string> messages)
{
    public IEnumerable<string> Messages { get; } = messages;
}
