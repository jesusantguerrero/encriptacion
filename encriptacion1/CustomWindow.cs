using System;
using System.Runtime.InteropServices;

namespace encriptacion1
{
    class CustomWindow
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}