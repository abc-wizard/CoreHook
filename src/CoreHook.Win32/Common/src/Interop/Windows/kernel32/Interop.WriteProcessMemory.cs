using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "WriteProcessMemory")]
        public static extern bool WriteProcessMemory(
            SafeProcessHandle processHandle,
            IntPtr baseAddress, 
            byte[] buffer, 
            int size,
            out IntPtr numberOfBytesWritten);
    }
}
