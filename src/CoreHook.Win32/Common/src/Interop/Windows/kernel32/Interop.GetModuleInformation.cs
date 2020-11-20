// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "K32GetModuleInformation")]
        private static extern bool GetModuleInformation(SafeProcessHandle processHandle, IntPtr moduleHandle, out NtModuleInfo ntModuleInfo, int size);

        public static unsafe bool GetModuleInformation(SafeProcessHandle processHandle, IntPtr moduleHandle, out NtModuleInfo ntModuleInfo) =>
            GetModuleInformation(processHandle, moduleHandle, out ntModuleInfo, sizeof(NtModuleInfo));

        public struct NtModuleInfo
        {
            public IntPtr BaseOfDll;
            public int SizeOfImage;
            public IntPtr EntryPoint;
        }
    }
}
