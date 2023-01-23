using NUnit.Framework;
using VulnerableSite.Services;

namespace VulnerableSite.Tests.Services;

[TestFixture]
public class XssServiceTests
{
    private IXssService _service = default!;

    [SetUp]
    public void SetUp()
    {
        _service = new XssService();
    }

    [Test]
    public void GivenMessages_WhenMessagesAreAddedToService_ThenExpectedMessagesAreRetrieved()
    {
        // Given
        const string message1 = "message-1";
        const string message2 = "message-2";

        var expectedMessages = new[]
        {
            message1,
            message2
        };

        // When
        _service.AddMessage(message1);
        _service.AddMessage(message2);

        // Then
        Assert.That(_service.Messages, Is.EqualTo(expectedMessages));
    }
}
