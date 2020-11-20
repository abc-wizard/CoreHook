using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern SafeWaitHandle CreateRemoteThread(
            SafeProcessHandle processHandle,
            IntPtr lpThreadAttributes,
            UIntPtr dwStackSize,
            IntPtr lpStartAddress,
            IntPtr lpParameter,
            uint dwCreationFlags,
            IntPtr lpThreadId);
    }
}
