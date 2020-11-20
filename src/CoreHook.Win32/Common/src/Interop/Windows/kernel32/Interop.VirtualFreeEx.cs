using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool VirtualFreeEx(
            SafeProcessHandle processHandle,
            IntPtr address,
            UIntPtr size,
            uint freeType);

        public partial class FreeType
        {
            public const uint Decommit = 0x4000;
            public const uint Release = 0x8000;
        }
    }
}
