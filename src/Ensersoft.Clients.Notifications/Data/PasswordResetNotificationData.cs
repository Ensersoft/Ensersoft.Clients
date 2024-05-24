namespace Ensersoft.Clients.Notifications.Data;

public class PasswordResetNotificationData
{
    public Uri ResetUrl { get; init; }
    public string FullName { get; init; }
    public PasswordResetNotificationData(Uri resetUrl, string fullName)
    {
        ResetUrl = resetUrl;
        FullName = fullName;
    }
}
