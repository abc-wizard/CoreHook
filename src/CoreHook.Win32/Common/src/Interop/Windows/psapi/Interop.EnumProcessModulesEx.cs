using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public partial class Interop
{
    public partial class Psapi
    {
        [DllImport(Libraries.Psapi, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool EnumProcessModulesEx(
            SafeProcessHandle processHandle,
            [Out] IntPtr module,
            uint moduleArraySize,
            ref int moduleArraySizeNeeded,
            uint filterFlag);

        public partial class ModuleFilterFlags
        {
            public const uint Default = 0x00;
            public const uint Bit32 = 0x01;
            public const uint Bit64 = 0x02;
            public const uint All = 0x03;
        }
    }
}
