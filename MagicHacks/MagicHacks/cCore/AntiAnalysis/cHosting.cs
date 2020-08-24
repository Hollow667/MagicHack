using System.Net;

namespace MagicHacks.cCore.AntiAnalysis
{
    internal sealed class cHosting
    {
        public static bool Hosting()
        {
            string web = new WebClient()
                .DownloadString("http://ip-api.com/line/?fields=hosting");
            return web.Contains("true");
        }
    }
}
