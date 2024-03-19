namespace Ensersoft.Clients.Notifications.Abstractions.Models;

public record UserData
{
    public long Id { get; set; }
    public string Email { get; set; } = default!;
    public string FullName { get; set; } = default!;

    public UserData(string email, string fullName, long? id)
    {
        Email = email;
        FullName = fullName;
        Id = id ?? 0;
    }
}
