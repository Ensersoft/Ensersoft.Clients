using Ensersoft.Clients.Notifications.Abstractions.Models;

namespace Ensersoft.Clients.Notifications.Abstractions;

public interface INotificationsNotificationsClient
{
    Task SendNotification(SendNotificationsRequest request,
        CancellationToken cancellationToken = default);
}
