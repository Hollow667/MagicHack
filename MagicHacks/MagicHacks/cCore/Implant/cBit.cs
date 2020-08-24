using System;
using Microsoft.Win32;

namespace MagicHacks.cCore.Implant
{
    internal sealed class cBit
    {
        public static string getBit()
        {
            if (Registry.LocalMachine.OpenSubKey(@"HARDWARE\Description\System\CentralProcessor\0").GetValue("Identifier").ToString().Contains("x86"))
            {
                return "x86";
            }
            else
            {
                return "x64";
            }
        }
    }
}
