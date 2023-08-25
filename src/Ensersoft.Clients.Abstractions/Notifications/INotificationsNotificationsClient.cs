using Ensersoft.Clients.Abstractions.Notifications.Models;

namespace Ensersoft.Clients.Abstractions.Notifications;

public interface INotificationsNotificationsClient
{
    Task SendNotification(SendNotificationsRequest request,
        CancellationToken cancellationToken = default);
}
