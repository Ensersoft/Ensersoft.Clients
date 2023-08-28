namespace Ensersoft.Clients.Notifications.Abstractions.Models;

public record SendNotificationsRequest
{
    public string NotificationEvent { get; }
    public object Data { get; }
    public UserContactData ContactData { get; }

    public SendNotificationsRequest(string notificationEvent, object data, UserContactData contactData)
    {
        NotificationEvent = notificationEvent;
        Data = data;
        ContactData = contactData;
    }
}
