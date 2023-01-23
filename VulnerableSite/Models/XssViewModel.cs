namespace VulnerableSite.Models;

public class XssViewModel
{
    public IEnumerable<string> Messages { get; }

    public XssViewModel(IEnumerable<string> messages)
    {
        Messages = messages;
    }
}
