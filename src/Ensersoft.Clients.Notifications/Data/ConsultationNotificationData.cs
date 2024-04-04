namespace Ensersoft.Clients.Notifications.Data;

public class ConsultationNotificationData
{
    public string FullName { get; init; }
    public string ContactEmail { get; init; }
    public string Phone { get; init; }
    public string Organization { get; init; }
    public string Description { get; init; }
    public ConsultationNotificationData(string fullName, string contactEmail, string phone, string organization, string description)
    {
        FullName = fullName;
        ContactEmail = contactEmail;
        Phone = phone;
        Organization = organization;
        Description = description;
    }
}
