// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, SetLastError = true)]
        public static extern bool IsWow64Process(SafeProcessHandle hProcess, ref bool Wow64Process);
    }
}