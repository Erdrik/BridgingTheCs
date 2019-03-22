using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeSomething
{
    public class Marker
    {
        public Marker(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; private set; }
        public float Y { get; private set; }

        public void Move(float x, float y)
        {
            X += x;
            Y += y;
        }
    }
}
