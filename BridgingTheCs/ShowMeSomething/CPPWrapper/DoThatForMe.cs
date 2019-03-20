using System;
using System.Runtime.InteropServices;

namespace ShowMeSomething.CPPWrapper
{
    public static class DoThatForMe
    {
        [DllImport("DoThatForMe.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Exists();
    }
}
