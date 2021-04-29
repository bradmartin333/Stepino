using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Stepino
{
    class Clicking
    {
        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll")]
        private static extern void mouse_event(
               UInt32 dwFlags, // motion and click options
               UInt32 dx, // horizontal position or change
               UInt32 dy, // vertical position or change
               UInt32 dwData, // wheel movement
               IntPtr dwExtraInfo // application-defined information
        );

        public static void SendClick(Point location)
        {
            Cursor.Position = location;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, new System.IntPtr());
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, new System.IntPtr());
        }
    }
}
