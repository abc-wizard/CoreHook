using System;
using System.Runtime.InteropServices;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Interop.Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        public static extern ushort FindAtomW(string lpString);
    }
}