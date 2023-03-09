using System.Net.NetworkInformation;

namespace Hemligheter.Helpers
{
    public static class ConnectivityHelper
    {
        public static bool IsConnectedToInternet()
        {
            Ping myPing = new Ping();
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            try
            {
                PingReply reply = myPing.Send("8.8.8.8", timeout, buffer, pingOptions);
                return reply?.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
        }
    }
}
