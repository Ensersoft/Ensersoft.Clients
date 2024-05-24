namespace Ensersoft.Clients.Notifications.Data;

public class RegisterNotificationEmailNotificationData
{
    public string FullName { get; init; }
    public string ContactEmail { get; init; }
    public string Phone { get; init; }
    public string Organization { get; init; }
    public RegisterNotificationEmailNotificationData(string fullName, string contactEmail, string phone, string organization)
    {
        FullName = fullName;
        ContactEmail = contactEmail;
        Phone = phone;
        Organization = organization;
    }
}
