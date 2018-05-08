using System.Net.Http;

namespace WTS.Web
{
    public interface IWTSAPI
    {
        HttpClient InitializeClient();
    }
}