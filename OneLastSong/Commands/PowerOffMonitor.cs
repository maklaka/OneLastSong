using System;
using System.Runtime.InteropServices;

namespace OneLastSong.Commands
{
    public class PowerOffMonitor : ICommand
    {
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const uint SystemCommand = 0x0112;

        private readonly IntPtr MonitorPower = (IntPtr)0xF170;
        
        private readonly IntPtr Off = (IntPtr)2;
        private readonly IntPtr Standby = (IntPtr)1;

        private readonly IntPtr controlHandle;

        public PowerOffMonitor(IntPtr controlHandle)
        {
            this.controlHandle = controlHandle;
        }

        public void Execute()
        {
            SendMessage(controlHandle, SystemCommand, MonitorPower, Off);
        }
    }
}