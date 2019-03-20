using System;
using System.Runtime.InteropServices;

namespace ShowMeSomething.CPPWrapper
{
    public class RectangleBridge
    {
        [DllImport("TheBridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Exists();

        [DllImport("TheBridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConstructorRectangle();

        [DllImport("TheBridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestructorRectangle(IntPtr rectangle);

        [DllImport("TheBridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetPosition(IntPtr rectangle, float x, float y);

        [DllImport("TheBridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetDimensions(IntPtr rectangle, float width, float height);

        [DllImport("TheBridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool PointIsInside(IntPtr rectangle, float x, float y);
    }
}
