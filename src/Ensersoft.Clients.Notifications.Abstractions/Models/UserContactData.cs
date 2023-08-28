namespace Ensersoft.Clients.Notifications.Abstractions.Models;

public record UserContactData
{
    public string Email { get; }

    public UserContactData(string email)
    {
        Email = email;
    }
}
