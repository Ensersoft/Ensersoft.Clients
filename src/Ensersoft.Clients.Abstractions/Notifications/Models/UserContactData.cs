namespace Ensersoft.Clients.Abstractions.Notifications.Models;

public record UserContactData
{
    public string Email { get; }

    public UserContactData(string email)
    {
        Email = email;
    }
}
