using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBridgeSharp.CPPWrapper
{
    public class Rectangle : IDisposable
    {
        private IntPtr nativeObject;

        public Rectangle()
        {
            this.nativeObject = RectangleBridge.ConstructorRectangle();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void SetPosition(float x, float y)
        {
            RectangleBridge.SetPosition(this.nativeObject, x, y);
        }

        public void SetDimensions(float width, float height)
        {
            RectangleBridge.SetDimensions(this.nativeObject, width, height);
        }

        public bool PointIsInside(float x, float y)
        {
            return RectangleBridge.PointIsInside(this.nativeObject, x, y);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.nativeObject != IntPtr.Zero)
            {
                RectangleBridge.DestructorRectangle(this.nativeObject);
                this.nativeObject = IntPtr.Zero;
            }

            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
        }

        ~Rectangle()
        {
            Dispose(false);
        }
    }
}
