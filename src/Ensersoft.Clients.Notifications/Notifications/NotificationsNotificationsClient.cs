using System.Net.Http.Json;
using Ensersoft.Clients.Notifications.Abstractions;
using Ensersoft.Clients.Notifications.Abstractions.Models;

namespace Ensersoft.Clients.Notifications.Notifications;

public class NotificationsNotificationsClient : NotificationsClientBase, INotificationsNotificationsClient
{
    protected override string BaseAddress => $"{base.BaseAddress}notifications/";

    public NotificationsNotificationsClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task SendNotification(SendNotificationsRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}send", UriKind.Relative);
        await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
    }
}
