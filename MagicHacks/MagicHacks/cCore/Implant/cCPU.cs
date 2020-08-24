using System.Management;


namespace MagicHacks.cCore.Implant
{
    internal sealed class cCPU
    {
        public static string getCPU()
        {
            try
            {
                using (ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor"))
                {
                    foreach (ManagementObject mObject in mSearcher.Get())
                    {
                        return mObject["Name"].ToString();
                    }
                    return "Unknown";
                }
            }
            catch { return "Unknown"; }
        }
    }
}
