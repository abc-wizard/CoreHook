using System;
using System.Runtime.InteropServices;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32)]
        public static extern uint GetVersion();
    }
}