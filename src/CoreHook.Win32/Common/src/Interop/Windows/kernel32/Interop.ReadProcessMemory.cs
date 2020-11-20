using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool ReadProcessMemory(
            SafeProcessHandle processHandle,
            IntPtr address,
            [Out] byte[] buffer,
            UIntPtr size,
            out UIntPtr numberOfBytesRead);
    }
}
