using System.Management;

namespace MagicHacks.cCore.Implant
{
    internal sealed class cGPU
    {
        public static string getGPU()
        {
            try
            {
                using (ManagementObjectSearcher obj = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController"))
                {
                    foreach (ManagementObject moj in obj.Get())
                    {
                        return moj["Name"].ToString();
                    }
                    return "Unknown";
                }
            }
            catch { return "Unknown"; }
        }
    }
}
