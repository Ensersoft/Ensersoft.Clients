using Ensersoft.Clients.Common.Base;
using Ensersoft.Clients.Common;

namespace Ensersoft.Clients.Notifications;

public class NotificationsClientBase : InternalApiClientBase
{
    protected override string HttpClientKey => InternalApiClients.NotificationsClient;

    public NotificationsClientBase(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }
}
