namespace Ensersoft.Clients.Notifications.Abstractions.Models;

public record SendNotificationsRequest
{
    public string NotificationEvent { get; }
    public object Data { get; }
    public UserData UserData { get; }

    public SendNotificationsRequest(string notificationEvent, object data, UserData userData)
    {
        NotificationEvent = notificationEvent;
        Data = data;
        UserData = userData;
    }
}
