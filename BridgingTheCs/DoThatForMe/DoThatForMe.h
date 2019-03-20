#ifndef _DO_THAT_FOR_ME_DLL_H_
#define _DO_THAT_FOR_ME_DLL_H_

namespace Spatial {
    class Rectangle {
    public:
        void SetPosition(float x, float y);
        void SetDimensions(float width, float height);

        bool PointIsInside(float x, float y);

    private:
        float x, y;
        float width, height;
    };
}

#endif
