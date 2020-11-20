using System;
using System.Runtime.InteropServices;

public partial class Interop
{
    public partial class KernelBase
    {
        [DllImport(Interop.Libraries.KernelBase, CharSet = CharSet.Unicode, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        public static extern int CompareStringW(uint locale, uint dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);        
    }
}