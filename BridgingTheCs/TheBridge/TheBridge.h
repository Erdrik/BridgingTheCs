#ifndef _THE_BRIDGE_H_
#define _THE_BRIDGE_H_

#include "..\DoThatForMe\DoThatForMe.h"

#if defined DLL_EXPORT
#define DECLDIR __declspec(dllexport)
#else
#define DECLDIR __declspec(dllimport)
#endif

extern "C" {
    DECLDIR bool Exists();

    DECLDIR Spatial::Rectangle* ConstructorRectangle();

    DECLDIR void DestructorRectangle(Spatial::Rectangle* rectangle);

    DECLDIR void SetPosition(Spatial::Rectangle* rectangle, float x, float y);

    DECLDIR void SetDimensions(Spatial::Rectangle* rectangle, float width, float height);

    DECLDIR bool PointIsInside(Spatial::Rectangle* rectangle, float x, float y);
}

#endif