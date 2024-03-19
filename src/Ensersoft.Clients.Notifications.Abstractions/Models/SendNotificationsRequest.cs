namespace Ensersoft.Clients.Notifications.Abstractions.Models;

public record SendNotificationsRequest
{
    public string NotificationEvent { get; }
    public object Data { get; }
    public UserData ContactData { get; }

    public SendNotificationsRequest(string notificationEvent, object data, UserData contactData)
    {
        NotificationEvent = notificationEvent;
        Data = data;
        ContactData = contactData;
    }
}
