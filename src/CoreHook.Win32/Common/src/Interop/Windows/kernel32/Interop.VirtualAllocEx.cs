using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(
            SafeProcessHandle processHandle,
            IntPtr address,
            UIntPtr size,
            uint allocationType,
            uint protect);
        
        public partial class MemoryAllocationType
        {
            public const uint Commit = 0x1000;
            public const uint Reserve = 0x2000;
            public const uint Decommit = 0x4000;
            public const uint Release = 0x8000;
            public const uint Reset = 0x80000;
            public const uint Physical = 0x400000;
            public const uint TopDown = 0x100000;
            public const uint WriteWatch = 0x200000;
            public const uint LargePages = 0x20000000;
        }

        public partial class MemoryProtection
        {
            public const uint Execute = 0x10;
            public const uint ExecuteRead = 0x20;
            public const uint ExecuteReadWrite = 0x40;
            public const uint ExecuteWriteCopy = 0x80;
            public const uint NoAccess = 0x01;
            public const uint ReadOnly = 0x02;
            public const uint ReadWrite = 0x04;
            public const uint WriteCopy = 0x08;
            public const uint GuardModifierflag = 0x100;
            public const uint NoCacheModifierflag = 0x200;
            public const uint WriteCombineModifierflag = 0x400;
        }
    }
}
