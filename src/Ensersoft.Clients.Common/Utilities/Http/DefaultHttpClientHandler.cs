using System.Net;

namespace Ensersoft.Clients.Common.Utilities.Http;

public class DefaultHttpClientHandler : HttpClientHandler
{
    public DefaultHttpClientHandler()
    {
        AutomaticDecompression =
            DecompressionMethods.Brotli |
            DecompressionMethods.Deflate |
            DecompressionMethods.GZip;
    }
}
