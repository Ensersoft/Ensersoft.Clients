namespace Ensersoft.Clients.Notifications.Data;

public class ProjectValidationRequestedNotificationData
{
    public Uri ProjectAdminUrl { get; init; }
    public string ProjectTitle { get; init; }
    public ProjectValidationRequestedNotificationData(Uri projectAdminUrl, string projectTitle)
    {
        ProjectAdminUrl = projectAdminUrl;
        ProjectTitle = projectTitle;
    }
}
