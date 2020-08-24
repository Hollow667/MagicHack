using System.Management;

namespace MagicHacks.cCore.Implant
{
    internal sealed class cHWID
    {
        public static string getHWID()
        {
            try
            {
                using (ManagementObjectSearcher obj = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor"))
                {
                    foreach (ManagementObject mbj in obj.Get())
                    {
                        return mbj["ProcessorId"].ToString();
                    }
                    return "Unknown";
                }
            }
            catch { return "Unknown"; }
        }
    }
}
