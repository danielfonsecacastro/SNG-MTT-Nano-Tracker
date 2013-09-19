using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace SNGMTTNanoTracker.Helpers
{
    public class WindowWrapper : IWin32Window
    {
        internal IntPtr handle;
        internal String title;

        public IntPtr Handle
        {
            get { return handle; }
        }

        public String Title
        {
            get { return title; }
        }
    }
}
