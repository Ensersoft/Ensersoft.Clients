namespace Ensersoft.Clients.Notifications.Data;

public class ProjectVerificationNotificationData
{
    public Uri ProjectUrl { get; init; }
    public string ProjectTitle { get; init; }
    public ProjectVerificationNotificationData(Uri projectUrl, string projectTitle)
    {
        ProjectUrl = projectUrl;
        ProjectTitle = projectTitle;
    }
}
