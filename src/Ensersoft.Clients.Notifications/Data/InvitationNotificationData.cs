namespace Ensersoft.Clients.Notifications.Data;

public class InvitationNotificationData
{
    public Uri JoinUrl { get; init; }
    public string FullName { get; init; }
    public InvitationNotificationData(Uri joinUrl, string fullName)
    {
        JoinUrl = joinUrl;
        FullName = fullName;
    }
}
