using System;
using System.Runtime.InteropServices;

namespace ShowMeSomething.CPPWrapper
{
    public class Rectangle
    {
        [DllImport("TheBridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Exists();
    }
}
