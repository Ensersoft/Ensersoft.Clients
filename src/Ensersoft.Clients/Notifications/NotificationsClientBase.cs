using Ensersoft.Clients.Base;

namespace Ensersoft.Clients.Notifications;

public class NotificationsClientBase : InternalApiClientBase
{
    protected override string HttpClientKey => InternalApiClients.NotificationsClient;

    public NotificationsClientBase(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }
}
