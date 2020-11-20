using System;
using System.Runtime.InteropServices;
using System.Text;

public partial class Interop
{
    public partial class Kernel32
    {
        [DllImport(Interop.Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        public static extern uint GetAtomNameW(ushort nAtom, StringBuilder lpBuffer, int nSize);
    }
}