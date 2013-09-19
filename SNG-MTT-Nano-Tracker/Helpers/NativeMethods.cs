using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace SNGMTTNanoTracker.Helpers
{
    internal static class NativeMethods
    {
        public static readonly Int32 GWL_STYLE = -16;
        public static readonly UInt64 WS_VISIBLE = 0x10000000L;
        public static readonly UInt64 WS_BORDER = 0x00800000L;
        public static readonly UInt64 DESIRED_WS = WS_BORDER | WS_VISIBLE;

        public delegate Boolean EnumWindowsCallback(IntPtr hwnd, Int32 lParam);

        public static List<WindowWrapper> GetAllWindows()
        {
            List<WindowWrapper> windows = new List<WindowWrapper>();
            StringBuilder buffer = new StringBuilder(300);
            EnumWindows(delegate(IntPtr hwnd, Int32 lParam)
            {
                if ((GetWindowLongA(hwnd, GWL_STYLE) & DESIRED_WS) == DESIRED_WS)
                {
                    GetWindowText(hwnd, buffer, buffer.Capacity);
                    WindowWrapper wnd = new WindowWrapper();
                    wnd.handle = hwnd;
                    wnd.title = buffer.ToString();
                    windows.Add(wnd);
                }
                return true;
            }, 0);

            return windows;
        }

        [DllImport("user32.dll")]
        static extern Int32 EnumWindows(EnumWindowsCallback lpEnumFunc, Int32 lParam);

        [DllImport("user32.dll")]
        public static extern void GetWindowText(IntPtr hWnd, StringBuilder lpString, Int32 nMaxCount);

        [DllImport("user32.dll")]
        static extern UInt64 GetWindowLongA(IntPtr hWnd, Int32 nIndex);
    }

}
